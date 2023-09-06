using P21.Extensions.BusinessRule;
using P21Custom.Extensions;
using P21Custom.Extensions.BusinessRule.BLL;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Reflection;

namespace P21.Rules.Visual.Utilities
{
    public class RuleLogger : IRuleLogger
    {
        private string _loggerName;
        private readonly Rule _ruleToLog;
        private readonly LogLevel _theshold;
        private bool _isInitialized;

        public RuleLogger()
        { _loggerName = Assembly.GetExecutingAssembly().FullName; }

        public bool Initialized
        {
            get { return _isInitialized; }
            set { _isInitialized = value; }
        }
        public Rule RuleToLog => _ruleToLog;
        public LogLevel Threshold => _theshold;
        public void LogCritical(string criticalMessage, Exception exception)
        {
            LogMessage(LogLevel.Critical, criticalMessage, exception);
        }

        public void LogDebug(string debugMessage)
        {
            LogMessage(LogLevel.Debug, debugMessage);
        }

        public void LogError(string errorMessage)
        {
            LogMessage(LogLevel.Error, errorMessage);
        }

        public void LogWarning(string warningMessage)
        {
            LogMessage(LogLevel.Warning, warningMessage);
        }

        public IRuleLogger Setup(Configuration appConfiguration)
        {
            //TODO: determine log level and store from web.config
            Initialized = true;
            return this;
        }
        public void SetLoggerName(string nameOfLog)
        {
            _loggerName = nameOfLog;
        }

        private void LogMessage(LogLevel level, string message)
        { LogMessage(level, message, null); }

        private void LogMessage(LogLevel level, string message, Exception exception)
        {
            if (level >= Threshold && Threshold < LogLevel.None)
            {
                if (level > LogLevel.Unknown)
                {
                    message = $"{level.ToString().ToUpper()}: {message} {Environment.NewLine}";
                }
                if (exception != null)
                {
                    switch (Threshold)
                    {
                        case LogLevel.Unknown:
                            message += exception.GetType().Name;
                            break;
                        case LogLevel.Trace:
                            message += exception.ToString();
                            break;
                        case LogLevel.Debug:
                            message += exception.StackTrace;
                            break;
                        case LogLevel.Information:
                            message += exception.GetBaseException().Message;
                            break;
                        case LogLevel.Warning:
                            message += exception.Message;
                            break;
                        case LogLevel.Error:
                            message += exception.GetType().FullName;
                            break;
                        case LogLevel.Critical:
                            message += "Something went wrong!";
                            break;
                        case LogLevel.None:
                            break;
                        default:
                            break;
                    }
                }

                if (!string.IsNullOrWhiteSpace(message))
                {
                    if (RuleToLog != null)
                    {
                        {
                            RuleToLog.Log.AddAndPersist(message);
                        }
                    }
                    else
                    {
                        if (Debugger.IsAttached)
                        {
                            Console.WriteLine(message);
                        }
                        else
                        {
                            if (_loggerName == null)
                            {
                                _loggerName = "Application";
                            }
                            EventLog eventLog = new EventLog(_loggerName);
                            eventLog.WriteEntry(message);
                            eventLog.Dispose();
                        }
                    }
                }
            }
        }
    }
}