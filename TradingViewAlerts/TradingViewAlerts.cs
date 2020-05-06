using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtAction;

namespace TradingViewAlerts
{
    public class TradingViewAlerts
    {


        public static async Task<List<ArtAction.ArtAction>> GetTradingViewAlerts(string source)
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

            List<ArtAction.ArtAction> ArtActions = new List<ArtAction.ArtAction>();
            foreach (string Row in AlertTableRows)
            {

                ArtAction.ArtAction ThisAction = await ArtAction.ArtAction.ExtractActionsFromString(Row);
                if (ThisAction != null)
                    ArtActions.Add(ThisAction);


            }


            return ArtActions;

            string stoppper = "stopped";
        }



    }
}
