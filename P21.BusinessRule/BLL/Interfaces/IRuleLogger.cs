using System;
using System.Configuration;

namespace P21.BusinessRule.BLL
{
	internal interface IRuleLogger
	{
		Type DeclaringType { get; }
		bool Initialized { get; set; }
		BaseRule RuleToLog { get; }
		LogLevel Threshold { get; }

		void LogCritical(string criticalMessage, Exception exception);

		void LogDebug(string debugMessage);

		void LogError(string errorMessage);

		void LogWarning(string warningMessage);

		IRuleLogger Setup(Configuration appConfiguration);
	}
}