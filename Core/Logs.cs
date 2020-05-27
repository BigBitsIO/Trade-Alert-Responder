using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class Logs
    {
        public enum LogLevel
        {
            Debug,
            Info,
            Warning,
            Error,
            Advertisement,
            SponsorMessage
        }

        public class LogMessage
        {
            public DateTime DateLogged { get; set; }
            public LogLevel Level { get; set; }
            public string Message { get; set; }
        }

        static Logs()
        {
            LogMessages = new System.ComponentModel.BindingList<LogMessage>();
        }

        public static System.ComponentModel.BindingList<LogMessage> LogMessages { get; }
        private static log4net.ILog log = log4net.LogManager.GetLogger(typeof(Logs));
        public static event EventHandler<System.ComponentModel.AddingNewEventArgs> NewLog;

        public static void Log(LogLevel level, string message, Exception ex = null)
        {
            LogMessage logMessage = new LogMessage { DateLogged = System.DateTime.Now, Level = level, Message = message };
            LogMessages.Add(logMessage);
            NewLog?.Invoke(null, new System.ComponentModel.AddingNewEventArgs { NewObject = logMessage });
            switch (level)
            {
                case LogLevel.Debug: log.Debug(message, ex); break;
                case LogLevel.Info: log.Info(message, ex); break;
                case LogLevel.Warning: log.Warn(message, ex); break;
                case LogLevel.Error: log.Error(message, ex); break;
                case LogLevel.SponsorMessage: log.Info(message, ex); break;
                case LogLevel.Advertisement: log.Info(message, ex); break;
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

        public static Color LogColor(LogLevel Level)
        {
            switch (Level)
            {
                case LogLevel.Debug: return Color.Pink;
                case LogLevel.Info: return Color.Teal;
                case LogLevel.Warning: return Color.Orange;
                case LogLevel.Error: return Color.Red;
                case LogLevel.SponsorMessage: return Color.LimeGreen;
                case LogLevel.Advertisement: return Color.PaleGoldenrod;
                default: return Color.White;
            }
        }

        public static LogLevel LevelFromString(string LevelString)
        {
            switch (LevelString)
            {
                case "Info":
                    return LogLevel.Info;
                case "Debug":
                    return LogLevel.Debug;
                case "Warning":
                    return LogLevel.Warning;
                case "Error":
                    return LogLevel.Error;
                case "SponsorMessage":
                    return LogLevel.SponsorMessage;
                case "Advertisement":
                    return LogLevel.Advertisement;
                default:
                    return LogLevel.Info;
            }
        }
    }
}
