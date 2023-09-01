using P21Custom.Extensions;
using P21Custom.Extensions.BusinessRule.BLL;
using System;
using System.Configuration;

namespace P21.Rules.Visual.Utilities
{
    public class RuleLogger : IRuleLogger
    {
        //private readonly Type _declaringType;
        //public Type DeclaringType => _declaringType;

        //private readonly BaseRule _ruleToLog;
        private readonly LogLevel _theshold;
        private bool _isInitialized;

        public RuleLogger()
        { }

        //public RuleLogger(BaseRule ruleToLog)
        //{
        //    //_declaringType = type;
        //    if (ruleToLog != null)
        //    {
        //        _theshold = ruleToLog.LogSeverity;
        //    }
        //}

        public bool Initialized
        {
            get { return _isInitialized; }
            set { _isInitialized = value; }
        }
        //public BaseRule RuleToLog => _ruleToLog;
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

        private void LogMessage(LogLevel level, string message)
        { LogMessage(level, message, null); }

        private void LogMessage(LogLevel level, string message, Exception exception)
        {
            if (level > LogLevel.Unknown)
            {
                message = $"{level}: {message}";
            }
            //if (RuleToLog != null)
            //{
            //    if (!string.IsNullOrWhiteSpace(message))
            //    {
            //        RuleToLog.Log.AddAndPersist(message);
            //    }
            //    if (exception != null)
            //    {
            //        RuleToLog.Log.AddAndPersist(exception.ToString());
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(message);
            //}
        }
    }
}