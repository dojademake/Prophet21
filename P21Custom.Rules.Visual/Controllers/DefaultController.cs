using P21Custom.Entity.Database;
using P21Custom.Entity.Services;
using P21.Extensions.BusinessRule;
using P21.Extensions.Web;
using P21.Rules.Visual.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace P21.Rules.Visual.Controllers
{
    public class DefaultController : BaseRuleController
    {
        private readonly BusinessRuleService service = new BusinessRuleService();

        public DefaultController()
        {
            service.CurrentRule = Rule;
            //service.RequestData = Request;
        }

        // GET: Default
        public ActionResult Index()
        {
            try
            {
                var result = service.GetAllRules().ToList();
                return View(result);

            }
            catch (Exception ex)
            {
                return HandleException(String.Empty, ex, service.MaskedConnectionString);
            }
        }

        // GET: Default/Details/5
        public ActionResult Details()
        {
            return View(Rule);
        }

        // GET: Default/Create
        public ActionResult Create()
        {
            if (!Rule.IsInitialized())
            {
                string content = FileUtility.ReadFileFromAppData("DefaultBusinessRule.xml");

                if (content != null)
                {
                    SqlConnectionStringBuilder remoteConnection = new SqlConnectionStringBuilder(ConfigurationManager.AppSettings["RemoteConnectionString"]);
                    Rule.Initialize(content, new Extensions.DataAccess.DBCredentials(remoteConnection.UserID, remoteConnection.Password, remoteConnection.DataSource, remoteConnection.InitialCatalog));
                }
                else
                {
                    return View("Error", new HandleErrorInfo(new Exception("Error initializing Web Visual Rule"), "Default", "Create"));
                }
            }
            return View(Rule);
        }

        // POST: Default/Create
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Default/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Default/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Default/Delete/5
        public ActionResult Delete(string id)
        {
            string extension = "dll";
            if (string.IsNullOrEmpty(id))
            {
                id = "bin";
            }
            else
            {
                if (id.Contains(","))
                {
                    extension = id.Split(',')[1];
                    id = id.Split(',')[0];
                }
            }

            string binPath = Server.MapPath($"~/{id}");
            string[] dllFiles = Directory.GetFiles(binPath, $"*.{extension}");

            var versions = new List<FileVersionInfo>();
            foreach (string dllFile in dllFiles)
            {
                try
                {
                    FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(dllFile);
                    versions.Add(fileVersionInfo);

                    // Display properties
                    Console.WriteLine("File: " + dllFile);
                    Console.WriteLine("Product Name: " + fileVersionInfo.ProductName);
                    Console.WriteLine("Product Version: " + fileVersionInfo.ProductVersion);
                    Console.WriteLine("File Version: " + fileVersionInfo.FileVersion);
                    Console.WriteLine("Comments: " + fileVersionInfo.Comments);
                    Console.WriteLine("Company Name: " + fileVersionInfo.CompanyName);
                    Console.WriteLine("Original Filename: " + fileVersionInfo.OriginalFilename);
                    Console.WriteLine("------------------------------------");
                }
                catch (Exception ex)
                {
                    // Handle exceptions if necessary
                    Console.WriteLine("Error reading file: " + dllFile);
                    Console.WriteLine("Error details: " + ex.Message);
                    Console.WriteLine("------------------------------------");
                }
            }

            return View(versions);
        }

        private string GetFileVersion(string filePath)
        {
            try
            {
                var assembly = Assembly.LoadFile(filePath);
                var version = assembly.GetName().Version;
                return version.ToString();
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        // POST: Default/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        private ActionResult HandleException(string key, Exception ex, string errorMessage)
        {
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                ModelState.AddModelError(key, errorMessage);
            }
            if (ex != null)
            {
                ModelState.AddModelError(key, ex);
                ModelState.AddModelError(ex.GetType().Name, ex.Message);
            }
            return View();
        }
    }
}
