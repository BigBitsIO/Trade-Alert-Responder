using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin
{
    public interface IAlertScanPlugin
    {
        // Use dll config for settings that apply to all instances of a plugin         
        //      Ex: All instances of this plugin should have a scan delay of 1000ms
        // Create a custom class as a property in your interface implementation to use to save instanced scanner settings  
        //      Ex: This instance of the plugin should have a scan delay of 2000ms, or this instance of a twitter scan should search for the term #Bitcoin
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

        UserControl PluginGlobalSettings();
        UserControl PluginInstanceSettings();
        UserControl About();



        string AuthorName { get; }
        string AuthorURL { get; }
    }

    public class AlertScanResult
    {
        public bool SourceIsValid { get; set; } = false;
        public List<Alert> AlertsScanned { get; set; } = new List<Alert>();
    }
}
