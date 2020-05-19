using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class TradingViewAlerts
    {


        public static async Task<List<Alert>> GetTradingViewAlerts(string source, string BotRootElement)
        {
            //Task.Run(() => Aggregator.TestFreezerScreenshot("https://www.tradingview.com/chart/SOicDNGP/"));
            //Aggregator.TestDiscord();


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

                Alert ThisAlert = await AlertExtractor.ExtractAlertsFromString(Row, BotRootElement);
                if (ThisAlert != null)
                    ArtAlerts.Add(ThisAlert);


            }


            return ArtAlerts;

            string stoppper = "stopped";
        }

        public static async Task<List<StockScreenerAlert>> GetTradingViewStockScreenerAlerts(string source, string BotRootElement)
        {

            source = source.Replace("&lt;", "<").Replace("&gt;", ">");

            // Get the table for StockScreenerAlerts
            int From = source.IndexOf("tv-screener__content-pane") + "tv-screener__content-pane".Length;
            int To = source.Substring(From).IndexOf("</table>") + From;

            string StockScreenerAlertTable = "";
            if (From >= 0 && To > From)
                StockScreenerAlertTable = source.Substring(From, To - From);



            // Get the table body for StockScreenerAlerts
            if (StockScreenerAlertTable.Contains("&lt;tbody&gt;"))
            {
                StockScreenerAlertTable = StockScreenerAlertTable.Replace("&lt;", "<").Replace("&gt;", ">");
            }
            int StockScreenerAlertTableFrom = StockScreenerAlertTable.IndexOf("tv-data-table__tbody") + "tv-data-table__tbody".Length;
            int StockScreenerAlertTableTo = StockScreenerAlertTable.IndexOf("</tbody>");

            string StockScreenerAlertTableBody = "";
            if (StockScreenerAlertTableFrom >= 0 && StockScreenerAlertTableTo > StockScreenerAlertTableFrom)
                StockScreenerAlertTableBody = StockScreenerAlertTable.Substring(StockScreenerAlertTableFrom, StockScreenerAlertTableTo - StockScreenerAlertTableFrom);







            // Get all table rows for individual StockScreenerAlerts
            List<string> StockScreenerAlertTableRows = new List<string>();
            if (StockScreenerAlertTableBody != "")
            {
                bool ItemFound = true;

                while (ItemFound && StockScreenerAlertTableBody.Length > 20)
                {

                    if (StockScreenerAlertTableBody.Contains("&lt;tr&gt;"))
                    {
                        StockScreenerAlertTableBody = StockScreenerAlertTableBody.Replace("&lt;", "<").Replace("&gt;", ">");
                    }
                    int StockScreenerAlertTableBodyFrom = StockScreenerAlertTableBody.IndexOf("<tr") + "<tr".Length;
                    int StockScreenerAlertTableBodyTo = StockScreenerAlertTableBody.IndexOf("</tr");


                    if (StockScreenerAlertTableBodyFrom >= 0 && StockScreenerAlertTableBodyTo > StockScreenerAlertTableBodyFrom)
                    {
                        StockScreenerAlertTableRows.Add(StockScreenerAlertTableBody.Substring(StockScreenerAlertTableBodyFrom, StockScreenerAlertTableBodyTo - StockScreenerAlertTableBodyFrom));
                        StockScreenerAlertTableBody = StockScreenerAlertTableBody.Substring(StockScreenerAlertTableBodyTo + "</tr".Length);
                    }
                    else
                    {
                        ItemFound = false;
                    }
                }
            }

            List<StockScreenerAlert> StockScreenerAlerts = new List<StockScreenerAlert>();
            Parallel.ForEach(StockScreenerAlertTableRows, Row =>
            {

                StockScreenerAlert ThisStockScreenerAlert = StockScreenerAlert.ExtractStockScreenerAlertsFromString(Row).GetAwaiter().GetResult();
                if (ThisStockScreenerAlert != null)
                    StockScreenerAlerts.Add(ThisStockScreenerAlert);


            });


            return StockScreenerAlerts;

            string stoppper = "stopped";
        }



    }
}
