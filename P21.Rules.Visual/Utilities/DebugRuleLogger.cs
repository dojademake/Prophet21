using P21Custom.Extensions;
using System;
using System.Diagnostics;

namespace P21.Rules.Visual.Utilities
{
    public class DebugRuleLogger : RuleLogger
    {
        private readonly BaseRule _ruleToLog;

        public DebugRuleLogger(BaseRule rule) : base(rule)
        {
            _ruleToLog = rule;
        }

        public override void LogMessage(LogLevel level, string message, Exception exception)
        {
            string errorMessage = $"{level}: {message} {Environment.NewLine}";
            if (exception != null)
            {
                errorMessage += exception.ToString();
            }
            Debug.WriteLine(errorMessage);
        }
    }
}