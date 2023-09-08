using P21.Extensions.BusinessRule;
using P21Custom.Extensions;
using P21Custom.Extensions.BusinessRule.BLL;
using System;
using System.Configuration;
using System.Reflection;

namespace P21.Rules.Visual.Utilities
{
    public abstract class RuleLogger : IRuleLogger
    {
        private readonly Rule _ruleToLog;
        private readonly LogLevel _theshold;
        private bool _isInitialized;
        private string _loggerName;

        public RuleLogger()
        { _loggerName = Assembly.GetExecutingAssembly().FullName; }

        public RuleLogger(Rule rule) : this()
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

        public abstract void LogMessage(P21Custom.Extensions.LogLevel level, string message, Exception exception);

        public void LogWarning(string warningMessage)
        {
            LogMessage(LogLevel.Warning, warningMessage);
        }

        public void SetLoggerName(string nameOfLog)
        {
            _loggerName = nameOfLog;
        }

        public IRuleLogger Setup(Configuration appConfiguration)
        {
            //TODO: determine log level and store from web.config
            Initialized = true;
            return this;
        }

        private void LogMessage(LogLevel level, string message)
        { LogMessage(level, message, null); }
    }
}