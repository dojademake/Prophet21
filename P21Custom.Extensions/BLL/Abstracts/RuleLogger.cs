using P21.Extensions.BusinessRule;
using System;
using System.Configuration;

namespace P21Custom.Extensions.BusinessRule
{
    public abstract class RuleLogger<TCategoryName> : IRuleLogger<TCategoryName>
    {
        private readonly LogLevel _theshold;
        private bool _isInitialized;
        private string _loggerName;
        private Rule _ruleToLog;

        public RuleLogger()
        {
            this.DeclaringType = typeof(TCategoryName);
            _loggerName = DeclaringType.Name;
        }

        public RuleLogger(Rule rule) : this()
        { _ruleToLog = rule; }

        public Type DeclaringType { get; private set; }

        public bool Initialized
        {
            get { return _isInitialized; }
            set { _isInitialized = value; }
        }

        public Rule RuleToLog => _ruleToLog;
        Rule IRuleLogger.RuleToLog { get => _ruleToLog; set { _ruleToLog = value; } }
        public LogLevel Threshold => _theshold;

        public IDisposable BeginScope<TState>(TState state) where TState : class
        {
            return null;
        }

        public void Log(string message)
        {
            //TODO: include a setting if unknown levels should be recorded.
            LogMessage(LogLevel.Unknown, message, null);
        }

        public void Log(LogLevel level, string message, Exception exception)
        {
            LogMessage(level, message, exception);
        }

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