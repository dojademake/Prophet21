using P21Custom.Extensions;
using P21Custom.Extensions.BusinessRule.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace P21.Rules.Visual.Utilities
{
    public class RuleLogger : IRuleLogger
    {
        private readonly Type _declaringType;
        public Type DeclaringType => _declaringType;

        private bool _isInitialized;
        public bool Initialized
        {
            get { return _isInitialized; }
            set { _isInitialized = value; }
        }

        private readonly BaseRule _ruleToLog;
        public BaseRule RuleToLog => _ruleToLog;

        private readonly LogLevel _theshold;
        public LogLevel Threshold => _theshold;

        public RuleLogger() { }
        public RuleLogger(Type type, BaseRule ruleToLog)
        {
            _declaringType = type;
            if (ruleToLog != null)
            {
                _theshold = ruleToLog.LogSeverity;
            }
        }

        public void LogCritical(string criticalMessage, Exception exception)
        {
            LogMessage(LogLevel.Critical, criticalMessage, exception);
        }

        private void LogMessage(LogLevel level, string message) { LogMessage(level, message, null); }
        private void LogMessage(LogLevel level, string message, Exception exception)
        {
            if (level > LogLevel.Unknown)
            {
                message = $"{level}: {message}";
            }
            if (RuleToLog != null)
            {
                if (!string.IsNullOrWhiteSpace(message))
                {
                    RuleToLog.Log.AddAndPersist(message);
                }
                if (exception != null)
                {
                    RuleToLog.Log.AddAndPersist(exception.ToString());
                }
            }
            else
            {
                Console.WriteLine(message);
            }
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
    }
}