using P21Custom.Extensions;
using P21Custom.Extensions.BusinessRule;
using System;
using System.Diagnostics;

namespace P21.Rules.Visual.Utilities
{
    public class DebugRuleLogger : RuleLogger<DebugRuleLogger>
    {
        public override void LogMessage(LogLevel level, string message, Exception exception)
        {
            string errorMessage = $"{level}: {message} {Environment.NewLine}";
            if (exception != null)
            {
                errorMessage += exception.ToString();
            }
            if (RuleToLog != null)
            {
                errorMessage += RuleToLog.XmlData;
            }

            Debug.WriteLine(errorMessage);
        }
    }
}