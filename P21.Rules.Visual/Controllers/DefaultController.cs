using P21Custom.Entity.Services;
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
using P21Custom.Extensions.BusinessRule.BLL;
using System.Web.Services.Description;
using Unity.Resolution;
using Unity;
using P21Custom.Entity.Database;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Web.Routing;
using Moq;

namespace P21.Rules.Visual.Controllers
{
    public class DefaultController : BaseRuleController
    {
        private readonly IRuleLogger _logger;
        private readonly BusinessRuleService _service = new BusinessRuleService();

        public DefaultController(IRuleLogger logger)
        {
            _logger = logger;
            _service.CurrentRule = Rule;
        }


        public ActionResult About()
        {
            ViewBag.Message = "Web hosting and protocol values listed below.";

            return View();
        }

        public ActionResult Contact(string id)
        {

            if (string.IsNullOrWhiteSpace(id))
            {
                ViewBag.Message = "Resources and documentation.";
                return View("GetStarted");
            }
            else
            {
                ViewBag.Message = "Corporate Office";
                return View();
            }
        }

        public ActionResult Home()
        {
            return View();
        }

        // GET: Default
        public ActionResult Index()
        {
            try
            {
                var result = _service.GetAllRules().ToList();
                return View(result);

            }
            catch (Exception ex)
            {
                return HandleException(String.Empty, ex, _service.MaskedConnectionString);
            }
        }

        // GET: Default/Details/5
        public ActionResult Details()
        {
            return View(Rule);
        }

        // GET: Default/Create
        //[RequireHttps]
        public ActionResult Create()
        {
            SetupTestControls();

            if (!Rule.IsInitialized())
            {
                string content = FileUtility.ReadFileFromAppData("DefaultBusinessRule.xml");

                if (content != null)
                {
                    SqlConnectionStringBuilder remoteConnection = new SqlConnectionStringBuilder(ConfigurationManager.AppSettings["RemoteConnectionString"]);
                    Rule.Initialize(content, new P21.Extensions.DataAccess.DBCredentials(remoteConnection.UserID, remoteConnection.Password, remoteConnection.DataSource, remoteConnection.InitialCatalog));
                }
                else
                {
                    return View("Error", new HandleErrorInfo(new Exception("Error initializing Web Visual Rule"), "Default", "Create"));
                }
            }
            return View(Rule);
        }

        private void SetupTestControls()
        {
            Uri uri = Request.Url;
            ViewBag.rootVBRURL = $"{uri.Scheme}://{uri.Host}:{uri.Port}/";

            ViewBag.BusinessRulesList = new SelectList(_service.GetAllRules(), "business_rule_uid", "rule_name");
        }

        // POST: Default/Create
        [HttpPost]
        [ValidateInput(false)]
        public async Task<ActionResult> Create(FormCollection collection)
        {
            try
            {
                SetupTestControls();
                if (ModelState.IsValid)
                {
                    if (Rule.IsInitialized())
                    {
                        //return View(collection["UID"]);

                    }
                    else
                    {
                        var token = await GetTokenAsync(collection["txtSOAURL"], collection["txtUserName"], collection["txtPassword"]);
                        if (!token.ToLower().Contains("error"))
                        {
                            return InitializeRule(collection, token);
                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, $"Requesting token resulted in '{token}' message.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return HandleException(String.Empty, ex, collection["txtSOAURL"]);
            }
            return View(Rule);
        }

        private ActionResult InitializeRule(FormCollection collection, string token)
        {
            try
            {
                // Get ruleController and ruleAction values from the collection["action"] value
                var actionUrl = new Uri($"{ViewBag.rootVBRURL}/{collection["action"]}", UriKind.RelativeOrAbsolute);
                var queryParameters = HttpUtility.ParseQueryString(actionUrl.Query);
                string ruleController = queryParameters["ruleController"];
                string ruleAction = queryParameters["ruleAction"];

                // Create a mock Request object and add form data to it
                NameValueCollection form = new NameValueCollection
                {
                    ["vbrData"] = collection["vbrData"],
                    ["token"] = token,
                    ["soaURL"] = collection["soaURL"]
                };

                var mockRequest = new Mock<HttpRequestBase>();
                mockRequest.Setup(r => r.Form).Returns(form);
                var mockHttpContext = new Mock<HttpContextBase>();
                mockHttpContext.Setup(c => c.Request).Returns(mockRequest.Object);

                // Create an instance of the target controller
                InitializeController targetController = new InitializeController();

                // Set its ControllerContext
                targetController.ControllerContext = new ControllerContext(mockHttpContext.Object, new RouteData(), targetController);

                // Execute the target action method
                ActionResult result = targetController.Index(ruleController, ruleAction);

                // Handle the result, e.g., by redirecting to another action
                return RedirectToAction(ruleAction, ruleController);
            }
            catch (Exception ex)
            {
                return HandleException(String.Empty, ex, collection["action"]);
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

                return RedirectToAction("Index", "Initialize", new { ruleController = collection.GetKey(0), ruleAction = collection.GetValue("ruleAction") });
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
                }
                catch (Exception ex)
                {
                    //TODO: log message
                    versions.Add(FileVersionInfo.GetVersionInfo(ex.Message));
                }
            }

            string rootPath = Server.MapPath("~"); // Map the root path of the application
            string[] subdirectories = Directory.GetDirectories(binPath);

            ViewBag.Subdirectories = subdirectories; // Pass the subdirectories to the view


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

        public async Task<string> GetTokenAsync(string soaURL, string userName, string password)
        {
            var tokenUrl = soaURL + "api/security/token/v2";

            var httpClient = new HttpClient();
            var payload = new
            {
                UserName = userName,
                Password = password
            };
            var jsonPayload = JsonConvert.SerializeObject(payload);
            var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(tokenUrl, content);
            if (response.IsSuccessStatusCode)
            {
                var responseJson = await response.Content.ReadAsStringAsync();
                return responseJson; // This will be your token
            }
            else
            {
                return "Error"; // Or handle the error appropriately
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
