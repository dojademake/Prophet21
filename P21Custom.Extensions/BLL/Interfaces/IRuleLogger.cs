using P21.Extensions.BusinessRule;
using System;
using System.Configuration;

namespace P21Custom.Extensions.BusinessRule.BLL
{
    public interface IRuleLogger
    {
        bool Initialized { get; set; }
        Rule RuleToLog { get; }
        LogLevel Threshold { get; }

        void LogCritical(string criticalMessage, Exception exception);

        void LogDebug(string debugMessage);

        void LogError(string errorMessage);

        void LogWarning(string warningMessage);

        IRuleLogger Setup(Configuration appConfiguration);
    }
}