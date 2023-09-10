using P21Custom.Extensions.BusinessRule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P21Custom.Extensions.BusinessRule
{
    /// <summary>
    /// Sample RuleLogger implementation that uses the built-in file logging for a rule in the logs subdirectory of the executing assembly.
    /// Not a good candidate for Web Visual Rules in the cloud since the file will be on the IIS server that is typically not accessible from the SFTP site.
    /// </summary>
    public class PersistRuleLogger : RuleLogger<PersistRuleLogger>
    {
        public string FileName => RuleToLog.Log.Name;

        //public P21.Extensions.BusinessRule.Rule RuleToLog { get; private set; }

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
                Debug.WriteLine($"{MethodBase.GetCurrentMethod().DeclaringType.FullName} does not have a Rule.");
                Debug.WriteLine(errorMessage);
            }
        }
    }
}
