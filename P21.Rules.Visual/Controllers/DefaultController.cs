using Moq;
using Newtonsoft.Json;
using P21.Extensions.Web;
using P21.Rules.Visual.Utilities;
using P21Custom.Entity.Services;
using P21Custom.Extensions.BusinessRule;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

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
            _logger.LogDebug(ViewBag.Message);

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

        // GET: Default/Create
        //[RequireHttps]
        public ActionResult Create(string id)
        {
            try
            {
                SetupTestControls();

                string content = string.Empty;

                int uid;
                if (int.TryParse(id, out uid))
                {
                    content = FileUtility.ReadFileFromAppData($"{uid}.xml");

                    if (content == null)
                    {
                        var busRule = _service.FindRule(uid);
                        if (busRule != null)
                        {
                            content = FileUtility.ReadFileFromAppData($"{busRule.rule_name}.xml");
                            if (content == null)
                            {
                                content = _service.GenerateXmlForRule(uid);
                            }
                        }
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(id))
                    {
                        content = FileUtility.ReadFileFromAppData($"{id}.xml");
                    }
                    else
                    {
                        content = FileUtility.ReadFileFromAppData("DefaultBusinessRule.xml");
                    }
                }

                if (content != null)
                {
                    SqlConnectionStringBuilder remoteConnection = new SqlConnectionStringBuilder(ConfigurationManager.AppSettings["RemoteConnectionString"]);
                    Rule.Initialize(content, new P21.Extensions.DataAccess.DBCredentials(remoteConnection.UserID, remoteConnection.Password, remoteConnection.DataSource, remoteConnection.InitialCatalog));
                    //if (Rule.IsInitialized())
                    {
                        Uri rulePage = new Uri(Rule.RuleState.RulePageUrl);
                        if (rulePage != null)
                        {
                            ViewBag.Action = GetInitializePath(rulePage);
                            ViewBag.SoaUrl = GetSchemeHostAndPort(rulePage);
                        }
                    }
                }
                else
                {
                    if (!Rule.IsInitialized())
                    {
                        return View("Error", new HandleErrorInfo(new Exception($"Error initializing Web Visual Rule '{id}'"), "Default", "Create"));
                    }
                }

                if (Rule != null)
                {
                    return View(Rule);
                }
            }
            catch (Exception ex)
            {
                return HandleException(String.Empty, ex, id);
            }
            return View();
        }

        private static string GetInitializePath(Uri rulePage)
        {
            // Get the segments from the Uri.
            string[] segments = rulePage.Segments;

            // Find the segment "Initialize" and take everything from there.
            string result = "";
            bool startAdding = false;
            foreach (string segment in segments)
            {
                if (segment.Trim('/').Equals("Initialize", StringComparison.OrdinalIgnoreCase))
                {
                    startAdding = true;
                }

                if (startAdding)
                {
                    result += segment;
                }
            }

            // Append the query string if it exists
            if (!String.IsNullOrEmpty(rulePage.Query))
            {
                result += rulePage.Query;
            }

            return result;
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
                    if (!Rule.IsInitialized())
                    {
                        var token = await GetTokenAsync(collection["txtSOAURL"], collection["txtUserName"], collection["txtPassword"]);
                        if (!token.ToLower().Contains("error"))
                        {
                            return InitializeRule(collection, token);
                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, $"Requesting a token resulted in the following message: '{token}'. Verify that your username, password, and the API URL are correct for the middleware in your environment.");
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

        // GET: Default/Details/5
        public ActionResult Details()
        {
            return View(Rule);
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

        public ActionResult Files(string id)
        {
            return Delete(id);
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

        public ActionResult Home()
        {
            return View();
        }

        // GET: Default
        public ActionResult Index()
        {
            try
            {
                var result = _service.GetAllRules().Where(br => br.rule_page_url != null).ToList();
                return View(result);
            }
            catch (Exception ex)
            {
                return HandleException(String.Empty, ex, _service.MaskedConnectionString);
            }
        }

        public ActionResult List()
        {
            return View("Index");
        }

        public ActionResult Test(string id)
        {
            return Create(id);
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

            _logger.LogCritical(errorMessage, ex);

            return View();
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

        private void SetupTestControls()
        {
            try
            {
                Uri uri = Request.Url;
                ViewBag.rootVBRURL = GetSchemeHostAndPort(uri);

                ViewBag.BusinessRulesList = new SelectList(_service.GetAllRules(), "business_rule_uid", "rule_name");
            }
            catch (Exception ex)
            {
                ViewBag.rootVBRURL = ex.ToString();
                ViewBag.BusinessRulesList = new SelectList(new List<string> { ex.Message });
            }
        }

        private static string GetSchemeHostAndPort(Uri uri)
        {
            return $"{uri.Scheme}://{uri.Host}:{uri.Port}/";
        }
    }
}