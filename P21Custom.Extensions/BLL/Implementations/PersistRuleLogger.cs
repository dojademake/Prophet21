using System;
using System.Diagnostics;

namespace P21Custom.Extensions.BusinessRule
{
    /// <summary>
    /// Sample RuleLogger implementation that uses the built-in file logging for a rule in the logs subdirectory of the executing assembly.
    /// Not a good candidate for Web Visual Rules in the cloud since the file will be on the IIS server that is typically not accessible from the SFTP site.
    /// </summary>
    public class PersistRuleLogger : RuleLogger<PersistRuleLogger>
    {
        public string FileName => RuleToLog.Log.Name;

        public override void LogMessage(LogLevel level, string message, Exception exception)
        {
            string errorMessage = $"{level} - {message} {Environment.NewLine}";
            if (exception != null)
            {
                errorMessage += exception.ToString();
            }
            if (RuleToLog != null && RuleToLog.Log != null)
            {
                if (RuleToLog.Session != null)
                {
                    errorMessage = $"{RuleToLog.Session.UserID} {errorMessage}";
                }
                RuleToLog.Log.AddAndPersist(errorMessage);
            }
            else
            {
                Debug.WriteLine($"The rule for {DeclaringType.FullName} has not been initiated and thus will not be written to a file in the logs directory.");
                Debug.WriteLine(errorMessage);
            }
        }
    }
}