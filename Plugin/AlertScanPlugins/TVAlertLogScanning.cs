using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.AlertScanPlugins
{
    public class TVAlertLogScanning : IAlertScanPlugin
    {
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

        public int DelayBetweenScansInMilliseconds
        {
            get
            {
                return 1000;
            }
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
            ASR.AlertsScanned = GetTradingViewAlerts(Source, BotRootElement).GetAwaiter().GetResult();
            return ASR;
        }


        public static async Task<List<Alert>> GetTradingViewAlerts(string source, string BotRootElement)
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

                Alert ThisAlert = await Alert.ExtractAlertsFromString(Row, BotRootElement);
                if (ThisAlert != null)
                    ArtAlerts.Add(ThisAlert);

            }


            return ArtAlerts;
        }
    }
}
