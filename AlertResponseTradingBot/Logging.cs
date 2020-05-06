using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAlertResponder
{
    public static class Logging
    {

        public enum LogLevel
        {
            Debug,
            Info,
            Warning,
            Error
        }

        public class LogMessage
        {
            public DateTime DateLogged { get; set; }
            public LogLevel Level { get; set; }
            public string Message { get; set; }
        }

        static Logging()
        {
            LogMessages = new System.ComponentModel.BindingList<LogMessage>();
        }

        public static System.ComponentModel.BindingList<LogMessage> LogMessages { get; }
        private static log4net.ILog log = log4net.LogManager.GetLogger(typeof(Logging));
        public static event EventHandler<System.ComponentModel.AddingNewEventArgs> LogMessageAdded;

        public static void Log(LogLevel level, string message, Exception ex = null)
        {
            LogMessage logMessage = new LogMessage { DateLogged = System.DateTime.Now, Level = level, Message = message };
            LogMessages.Add(logMessage);
            LogMessageAdded?.Invoke(null, new System.ComponentModel.AddingNewEventArgs { NewObject = logMessage });
            switch (level)
            {
                case LogLevel.Debug: log.Debug(message, ex); break;
                case LogLevel.Info: log.Info(message, ex); break;
                case LogLevel.Warning: log.Warn(message, ex); break;
                case LogLevel.Error: log.Error(message, ex); break;
            }
        }

        public static void Debug(string message, Exception ex = null)
        {
            Log(LogLevel.Debug, message, ex);
        }
        public static void Info(string message, Exception ex = null)
        {
            Log(LogLevel.Info, message, ex);
        }
        public static void Warn(string message, Exception ex = null)
        {
            Log(LogLevel.Warning, message, ex);
        }
        public static void Error(string message, Exception ex = null)
        {
            Log(LogLevel.Error, message, ex);
        }

    }
}
