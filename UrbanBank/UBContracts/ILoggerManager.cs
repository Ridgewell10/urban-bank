using System;

namespace UBContracts
{
    public interface  ILoggerManager
    {
            void LogInfo(string message);
            void LogWarn(string message);
            void LogDebug(string message);
            void LogError(string message);
        
    }
}
