using Microsoft.Extensions.Logging;
using NLog;
using UBContracts;

namespace UBLoggingService
{
    public class LoggerManager :ILoggerManager
    {
        private static readonly Microsoft.Extensions.Logging.ILogger logger = (Microsoft.Extensions.Logging.ILogger)LogManager.GetCurrentClassLogger();

        public void LogDebug(string message)
        {
            logger.LogDebug(message);
        }

        public void LogError(string message)
        {
            logger.LogError(message);
        }

        public void LogInfo(string message)
        {
            logger.LogInformation(message);
        }

        public void LogWarn(string message)
        {
            logger.LogWarning(message);
        }
    }
}
