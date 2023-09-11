using P21.Extensions.BusinessRule;
using System;
using System.Configuration;

namespace P21Custom.Extensions.BusinessRule
{
    public interface IRuleLogger
    {
        bool Initialized { get; set; }
        Rule RuleToLog { get; set; }
        LogLevel Threshold { get; }

        void LogCritical(string criticalMessage, Exception exception);

        void LogDebug(string debugMessage);

        void LogError(string errorMessage);

        void LogWarning(string warningMessage);

        IRuleLogger Setup(Configuration appConfiguration);
    }

    /// <summary>
    /// A generic interface for logging where the category name is derived from the specified
    /// <typeparamref name="TCategoryName"/> type name.
    /// Generally used to enable activation of a named <see cref="IRuleLogger"/> from dependency injection.
    /// </summary>
    /// <typeparam name="TCategoryName">The type whose name is used for the logger category name.</typeparam>
    public interface IRuleLogger<out TCategoryName> : IRuleLogger
    {
        Type DeclaringType { get; }

        /// <summary>
        /// Begins a logical operation scope.
        /// </summary>
        /// <param name="state">The identifier for the scope.</param>
        /// <typeparam name="TState">The type of the state to begin scope for.</typeparam>
        /// <returns>An <see cref="IDisposable"/> that ends the logical operation scope on dispose.</returns>
        IDisposable BeginScope<TState>(TState state) where TState : class;

        // Your logger methods go here
        void Log(string message);

        /// <summary>
        /// Writes a log entry.
        /// </summary>
        /// <param name="logLevel">Entry will be written on this level.</param>
        /// <param name="message">The text to be logged.</param>
        /// <param name="exception">The exception related to this entry.</param>
        void Log(LogLevel level, string message, Exception exception);
    }
}