using P21.Extensions.BusinessRule;
using P21Custom.Extensions;
using P21Custom.Extensions.BusinessRule.BLL;
using System;
using System.Configuration;

namespace P21.Rules.Visual.Utilities
{
    public abstract class RuleLogger : IRuleLogger
    {
        private readonly Rule _ruleToLog;
        private readonly LogLevel _theshold;
        private bool _isInitialized;

        public RuleLogger(Rule rule)
        { _ruleToLog = rule; }

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

        }

        private void LogMessage(LogLevel level, string message)
        { LogMessage(level, message, null); }

        public abstract void LogMessage(P21Custom.Extensions.LogLevel level, string message, Exception exception);
    }
}