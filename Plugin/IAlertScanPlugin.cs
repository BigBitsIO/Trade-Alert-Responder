using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin
{
    public interface IAlertScanPlugin
    {
        string Name { get; }
        string ShortName { get; }
        string Description { get; }
        bool UseBrowserScanning { get; }
        bool UseCustomHTML { get; }
        string CustomHTML { get; }
        string StartURL { get; }
        int DelayBetweenScansInMilliseconds { get; }
        AlertScanResult Scan(string Source, string BotRootElement);
        AlertScanResult Scan(string BotRootElement);
    }

    public class AlertScanResult
    {
        public bool SourceIsValid { get; set; } = false;
        public List<Alert> AlertsScanned { get; set; } = new List<Alert>();
    }
}
