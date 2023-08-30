using P21Custom.Extensions.BusinessRule.BLL;
using P21.Extensions.BusinessRule;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace P21Custom.Extensions
{
	public abstract class BaseRule : Rule, IDisposable
	{
		private LogicLayer _logic;
		private LogLevel _logLevel;
		private bool disposedValue;

		public LogLevel LogSeverity
		{
			get
			{
				if (_logLevel == LogLevel.Unknown)
				{
					try
					{
						_logLevel = Logger.Threshold;
					}
					catch
					{
						_logLevel = LogLevel.Error;
					}
				}
				return _logLevel;
			}
		}

		internal IRuleLogger Logger { get; private set; }

		internal LogicLayer Logic
		{
			get
			{
				if (_logic == null)
				{
					_logic = new LogicLayer(this, Logger);
				}
				return _logic;
			}
		}

		public void Dispose()
		{
			// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		public override string GetName()
		{
			return this.GetType().Name;
		}

		public RuleResult HandleException(Exception ex, MethodBase method, BaseRule rule)
		{
			RuleResult result = new RuleResult() { Message = ex.ToString(), Success = false };
			result.Message = HandleException(ex, method, string.Empty);

			try
			{
				if (Logger.Initialized && LogSeverity < LogLevel.Information)  // Debug, Trace
				{
					result.Success = false;
				}
			}
			catch (Exception exc)
			{
				result.Message += $"Could not log exception '{ex.Message}' because: {exc.Message}";
			}
			return result;
		}

		internal string AppSetting(string key, string defaultValue)
		{
			if (key == null)
				return defaultValue;

			string result = defaultValue;
			try
			{
				var settings = Logic.AppConfiguration.AppSettings.Settings;
				if (settings.AllKeys.Contains(key))
				{
					result = settings[key].Value;
				}
				else
				{
					if (Logger.Initialized)
					{
						Logger.LogWarning($"The '{key}' key is not defined in the {Logic.AppConfiguration.FilePath} config file");
					}
				}

				if (string.IsNullOrEmpty(result) && !string.IsNullOrWhiteSpace(defaultValue))
				{
					result = defaultValue;
					if (Logger.Initialized)
					{
						Logger.LogDebug($"Default value '{defaultValue}' returned for '{key}' setting.");
					}
				}
			}
			catch (Exception ex)
			{
				HandleException(ex, MethodBase.GetCurrentMethod(), $"Failed to retrieve '{key}' setting");
			}
			return result;
		}

		internal string HandleException(Exception exception, MethodBase method, string message = "")
		{
			string result = message;

			try
			{
				string methodName = method.DeclaringType.Name;

				result = message;

				if (string.IsNullOrWhiteSpace(result))
				{
					var level = LogSeverity;

					switch (level)
					{
						case LogLevel.Trace:
							result = exception.ToString(); 
							break;

						case LogLevel.Debug:
							result = $"{methodName}.{method.Name} failed with message {exception.GetBaseException().Message}";
							break;

						case LogLevel.Information:
							result = exception.GetBaseException().Message;
							break;

						case LogLevel.Warning:
							result = $"{methodName} failed with message {exception.Message}";
							break;

						case LogLevel.Error:
							result = $"There was a probem recorded in the '{AppSetting("LogPath","Custom Logging")}' file.";
							break;

						case LogLevel.Critical:
							result = $"Something went wrong. Please contact support.";
							break;
					}
				}

				if (Logger.Initialized)
				{
					Logger.LogCritical(message, exception);
				}
				else
				{
					result = $"Unable to log: {result}";
				}
			}
			catch (Exception exc)
			{
				string originalException = string.Empty;
				if (exception != null)
				{
					originalException = exception.Message;
				}
				result = $"WARNING: an exception occurred while handling exception. {result} {originalException}";
				if (Logger.Initialized)
				{
					Logger.LogCritical(result, new Exception(exception.Message, exc));
				}
			}
			return result;
		}
		
		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					// TODO: dispose managed state (managed objects)
				}

				// TODO: free unmanaged resources (unmanaged objects) and override finalizer
				// TODO: set large fields to null
				disposedValue = true;
			}
		}

		// // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
		// ~BaseRule()
		// {
		//     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
		//     Dispose(disposing: false);
		// }
	}
}