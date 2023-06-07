using System;
using System.Configuration;

namespace P21.BusinessRule.BLL
{
	internal interface IRuleLogger
	{
		Type DeclaringType { get; }
		BaseRule RuleToLog { get; }
		LogLevel Threshold { get; }

		void LogCritical(string criticalMessage, Exception exception);

		IRuleLogger Setup(Configuration appConfiguration);
	}
}