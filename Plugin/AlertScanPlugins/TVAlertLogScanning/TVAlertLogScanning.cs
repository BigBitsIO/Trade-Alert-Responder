using Core;
using Plugin.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin.AlertScanPlugins
{
    public class TVAlertLogScanning : IAlertScanPlugin
    {
        public LocalSettings LocalSettings;

        public TVAlertLogScanning()
        {
            LocalSettings = new LocalSettings();
        }

        public string Name
        {
            get
            {
                return "TradingView Alert Log Scanning";
            }
        }

        public string ShortName
        {
            get
            {
                return "TV Alert Log";
            }
        }

        public string Description
        {
            get
            {
                return "Scans a user's TradingView alert log to return a list of all alerts found.";
            }
        }

        public string StartURL
        {
            get
            {
                return "https://www.tradingview.com"; // use about:none if it will not be scanning a web source that is visible
            }
        }

        public bool UseCustomHTML
        {
            get
            {
                return false;
            }
        }

        public string CustomHTML
        {
            get
            {
                return "<h3>TEST</h3>";
            }
        }

        public bool UseBrowserScanning
        {
            get
            {
                return true;
            }
        }

        public int DelayBetweenScansInMilliseconds
        {
            get
            {
                return Plugin.Properties.Settings.Default.TVAlertLogScanningDelay;
            }
        }

        public string AuthorName
        {
            get
            {
                return "Big Bits";
            }
        }

        public string AuthorURL
        {
            get
            {
                return "https://www.bigbits.io";
            }
        }

        public UserControl PluginGlobalSettings()
        {
            return new TVAlertLogScanningGlobalSettings();
        }

        public UserControl PluginInstanceSettings()
        {

            return new TVAlertLogScanningLocalSettings(ref LocalSettings);
        }

        public AlertScanResult Scan(string Source, string BotRootElement)
        {
            AlertScanResult ASR = new AlertScanResult();

            if(Source.Contains("widgetbar-widget-alerts_log"))
            {
                ASR.SourceIsValid = true;
            }
            else
            {
                ASR.SourceIsValid = false;
                return ASR; // No need to scan if source is not valid, stop here - will return empty alert list.
            }

            // At this point, our html source is "valid" so try to scan for alerts within.
            ASR.AlertsScanned = GetTradingViewAlerts(Source, BotRootElement, ShortName).GetAwaiter().GetResult();
            return ASR;
        }

        public AlertScanResult Scan(string BotRootElement)
        {
            //Here you would do a custom scan.
            return new AlertScanResult();
        }


        public static async Task<List<Alert>> GetTradingViewAlerts(string source, string BotRootElement, string Source)
        {


            // Get the table for alerts
            int From = source.IndexOf("widgetbar-widget-alerts_log") + "widgetbar-widget-alerts_log".Length;
            int To = source.Substring(From).IndexOf("widgetbar-page") + From;

            string AlertTable = "";
            if (From >= 0 && To > From)
                AlertTable = source.Substring(From, To - From);



            // Get the table body for alerts
            if (AlertTable.Contains("&lt;tbody&gt;"))
            {
                AlertTable = AlertTable.Replace("&lt;", "<").Replace("&gt;", ">");
            }
            int AlertTableFrom = AlertTable.IndexOf("<tbody>") + "<tbody>".Length;
            int AlertTableTo = AlertTable.IndexOf("</tbody>");

            string AlertTableBody = "";
            if (AlertTableFrom >= 0 && AlertTableTo > AlertTableFrom)
                AlertTableBody = AlertTable.Substring(AlertTableFrom, AlertTableTo - AlertTableFrom);







            // Get all table rows for individual alerts
            List<string> AlertTableRows = new List<string>();
            if (AlertTableBody != "")
            {
                bool ItemFound = true;

                while (ItemFound && AlertTableBody.Length > 20)
                {

                    if (AlertTableBody.Contains("&lt;tr&gt;"))
                    {
                        AlertTableBody = AlertTableBody.Replace("&lt;", "<").Replace("&gt;", ">");
                    }
                    int AlertTableBodyFrom = AlertTableBody.IndexOf("<tr") + "<tr".Length;
                    int AlertTableBodyTo = AlertTableBody.IndexOf("</tr");


                    if (AlertTableBodyFrom >= 0 && AlertTableBodyTo > AlertTableBodyFrom)
                    {
                        AlertTableRows.Add(AlertTableBody.Substring(AlertTableBodyFrom, AlertTableBodyTo - AlertTableBodyFrom));
                        AlertTableBody = AlertTableBody.Substring(AlertTableBodyTo + "</tr".Length);
                    }
                    else
                    {
                        ItemFound = false;
                    }
                }
            }

            List<Alert> ArtAlerts = new List<Alert>();
            foreach (string Row in AlertTableRows)
            {

                Alert ThisAlert = await AlertExtractor.ExtractAlertsFromString(Row, BotRootElement, Source);
                if (ThisAlert != null)
                    ArtAlerts.Add(ThisAlert);

            }


            return ArtAlerts;
        }
    }

    public class LocalSettings
    {
        public bool UseCustomScanDelay { get; set; } = false;
        public int CustomScanDelay { get; set; } = Properties.Settings.Default.TVAlertLogScanningDelay;
    }
}
