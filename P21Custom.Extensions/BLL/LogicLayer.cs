using System;
using System.Configuration;
using System.IO;
using System.Reflection;

namespace P21Custom.Extensions.BusinessRule.BLL
{
    internal class LogicLayer
    {
        private Configuration _appConfig;
        private string _p21Environment;

        internal LogicLayer(BaseRule rule, IRuleLogger logger)
        {
            Rule = rule;
            Logger = logger;

            if (rule != null)
            {
                _p21Environment = rule.Session.Database;
            }
        }

        public string BusinessRulesPath { get; private set; }
        public IRuleLogger Logger { get; private set; }

        internal Configuration AppConfiguration
        {
            get
            {
                if (_appConfig == null)
                {
                    string fileName = Assembly.GetExecutingAssembly().Location;
                    string folderName = String.Empty;
                    string configPath = $"{fileName}.config";
                    if (File.Exists(configPath))
                    {
                        _appConfig = ConfigurationManager.OpenExeConfiguration(fileName);
                    }
                    else
                    {
                        try
                        {
                            folderName = BusinessRulesPath;
                            configPath = Path.Combine(folderName, Path.GetFileName(fileName));
                            if (File.Exists(configPath))
                                _appConfig = ConfigurationManager.OpenExeConfiguration(configPath);
                        }
                        catch (Exception ex)
                        {
                            if (Logger.Initialized)
                            {
                                Rule.HandleException(ex, MethodBase.GetCurrentMethod(), Rule);
                            }
                        }
                    }
                    if (string.IsNullOrWhiteSpace(configPath))
                    {
                        configPath = $"{folderName} - {fileName}";
                    }
                    if (_appConfig == null)
                    {
                        if (Logger.Initialized)
                        {
                            Logger.LogError($"Could not load the Business Rules Config file {configPath} for the {_p21Environment} environment");
                        }
                        else
                        {
                            throw new FileNotFoundException($"Could not load the Business Rules Config file for the {_p21Environment} environment", configPath);
                        }
                    }
                }
                return _appConfig;
            }
        }

        private BaseRule Rule { get; }
    }
}