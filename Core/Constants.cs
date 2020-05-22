using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Constants
    {
        public enum AppDirectory
        {
            Browser,
            Data,
            Screenshots,
            ScreenshotSettings,
            ScreenshotSettingsLogo,
            DataAlerts,
            DataOrders,
            DataDiscordSettings,
            DataExchangeSettings,
            DataTwitterSettings,
            DataAlertSettings,
            AlertScanPlugins,
            AlertActionPlugins,
            Logs
        }

        public const string ProjectUserFriendlyName = "Trade Alert Responder";
        public const string ProjectName = "TradeAlertResponder";
        public const string ProjectFolderName = "TradeAlertResponder"; // IF CHANGED UPDATE IN log4net in app.config
        public static string WatermarkFilePath = Constants.AppFolder(Constants.AppDirectory.ScreenshotSettingsLogo) + "Logo.png";
        public static string AlertScanPluginFolder = Constants.AppFolder(Constants.AppDirectory.AlertScanPlugins);
        public static string AlertActionPluginFolder = Constants.AppFolder(Constants.AppDirectory.AlertActionPlugins);
        public static string LogsFolder = Constants.AppFolder(Constants.AppDirectory.Logs);
        public const string Version = "1.0.0";

        public static string AppFolder(AppDirectory Directory)
        {
            string Path = "";
            switch(Directory)
            {
                case AppDirectory.Browser:
                    Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/" + Constants.ProjectFolderName + "/TradingViewBroswerCache";
                    ConfirmDirectory(Path);
                    return Path + "/";
                case AppDirectory.Data:
                    Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/" + Constants.ProjectFolderName + "/Data";
                    ConfirmDirectory(Path);
                    return Path + "/";
                case AppDirectory.Logs:
                    Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/" + Constants.ProjectFolderName + "/Logs";
                    ConfirmDirectory(Path);
                    return Path + "/";
                case AppDirectory.Screenshots:
                    Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/" + Constants.ProjectFolderName + "/ScreenShots";
                    ConfirmDirectory(Path);
                    return Path + "/";
                case AppDirectory.ScreenshotSettings:
                    Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/" + Constants.ProjectFolderName + "/Data/ScreenshotSettings";
                    ConfirmDirectory(Path);
                    return Path + "/";
                case AppDirectory.ScreenshotSettingsLogo:
                    Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/" + Constants.ProjectFolderName + "/Data/ScreenshotSettings/Logo";
                    ConfirmDirectory(Path);
                    return Path + "/";
                case AppDirectory.DataAlerts:
                    Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/" + Constants.ProjectFolderName + "/Data/Alerts";
                    ConfirmDirectory(Path);
                    return Path + "/";
                case AppDirectory.DataOrders:
                    Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/" + Constants.ProjectFolderName + "/Data/Orders";
                    ConfirmDirectory(Path);
                    return Path + "/";
                case AppDirectory.DataDiscordSettings:
                    Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/" + Constants.ProjectFolderName + "/Data/DsSettings";
                    ConfirmDirectory(Path);
                    return Path + "/";
                case AppDirectory.DataExchangeSettings:
                    Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/" + Constants.ProjectFolderName + "/Data/ExSettings";
                    ConfirmDirectory(Path);
                    return Path + "/";
                case AppDirectory.DataTwitterSettings:
                    Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/" + Constants.ProjectFolderName + "/Data/TwSettings";
                    ConfirmDirectory(Path);
                    return Path + "/";
                case AppDirectory.DataAlertSettings:
                    Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/" + Constants.ProjectFolderName + "/Data/AlertSettings";
                    ConfirmDirectory(Path);
                    return Path + "/";
                case AppDirectory.AlertScanPlugins:
                    Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/" + Constants.ProjectFolderName + "/Plugins/AlertScanners";
                    ConfirmDirectory(Path);
                    return Path + "/";
                case AppDirectory.AlertActionPlugins:
                    Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/" + Constants.ProjectFolderName + "/Plugins/AlertActions";
                    ConfirmDirectory(Path);
                    return Path + "/";
                default:
                    return "";
            }
        }

        private static void ConfirmDirectory(string Path)
        {
            if (!Directory.Exists(Path))
                Directory.CreateDirectory(Path);
        }

    }
}
