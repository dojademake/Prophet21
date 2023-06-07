using System.Configuration;

namespace P21.BusinessRule.BLL
{
	internal class LogicLayer
	{
		private Configuration _appConfig;

		internal LogicLayer(BaseRule rule, IRuleLogger logger)
		{
			Rule = rule;
			Logger = logger;
		}

		private BaseRule Rule { get; }
		public IRuleLogger Logger { get; private set; }

		//internal Configuration AppConfiguration
		//{
		//	get
		//	{
		//		if (_appConfig == null)
		//		{
		//			string fileName = Assembly.GetExecutingAssembly().Location;
		//			string folderName = String.Empty;
		//			string configPath = $"{fileName}.config";
		//			if (File.Exists(configPath))
		//			{
		//				_appConfig = ConfigurationManager.OpenExeConfiguration(fileName);
		//			}
		//			else
		//			{
		//				try
		//				{
		//					folderName = BusinessRulesPath;
		//					configPath = Path.Combine(folderName, Path.GetFileName(fileName));
		//					if (File.Exists(configPath))
		//						_appConfig = ConfigurationManager.OpenExeConfiguration(configPath);
		//				}
		//				catch (Exception ex)
		//				{
		//					if (LogInitialized)
		//					{
		//						Rule.HandleException(ex, MethodBase.GetCurrentMethod(), Rule);
		//					}
		//				}
		//			}
		//			if (string.IsNullOrWhiteSpace(configPath))
		//			{
		//				configPath = $"{folderName} - {fileName}";
		//			}
		//			if (_appConfig == null)
		//			{
		//				if (LogInitialized)
		//				{
		//					Rule.Logging.Log4Error($"Could not load the Business Rules Config file {configPath} for the {_p21Environment} environment");
		//				}
		//				else
		//				{
		//					throw new FileNotFoundException($"Could not load the Business Rules Config file for the {_p21Environment} environment", configPath);
		//				}
		//			}
		//		}
		//		return _appConfig;
		//	}
		//}
	}
}