using P21.Entity.Database;
using P21.Entity.Services;
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

namespace P21.Rules.Visual.Controllers
{
    public class DefaultController : BaseRuleController
    {
        private BusinessRuleService service = new BusinessRuleService();

        public DefaultController()
        {
            service.CurrentRule = Rule;
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
        public ActionResult Delete(int id)
        {
            return View();
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
