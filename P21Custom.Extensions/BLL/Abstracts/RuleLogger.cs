﻿using P21.Extensions.BusinessRule;
using System;
using System.Configuration;
using System.Reflection;

namespace P21Custom.Extensions.BusinessRule
{
    public abstract class RuleLogger : IRuleLogger
    {
        private readonly LogLevel _theshold;
        private bool _isInitialized;
        private string _loggerName;
        private Rule _ruleToLog;
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
        Rule IRuleLogger.RuleToLog { get => _ruleToLog; set { _ruleToLog = value; } }
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

        //public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool IsEnabled(LogLevel logLevel)
        //{
        //    throw new NotImplementedException();
        //}

        //public IDisposable BeginScope<TState>(TState state) where TState : class
        //{
        //    throw new NotImplementedException();
        //}
    }
}