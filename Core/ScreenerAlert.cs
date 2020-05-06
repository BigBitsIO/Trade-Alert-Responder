using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{

    public class StockScreenerAlert
    {
        public AlertType Action { get; set; } = AlertType.None; // Default to None
        public string Id { get; set; } = "";
        public string URL { get; set; } = ""; // Allow user to customize in our app
        public string Note { get; set; } = ""; // Allow user to customize in our app
        public string Resolution { get; set; } = "";
        public string Price { get; set; } = "";
        public string QuoteAsset { get; set; } = "";
        public string BaseAsset { get; set; } = "";
        public string DesiredAmount { get; set; } = "";
        public string DesiredPrice { get; set; } = "";
        public string TradingPairOrSymbol { get; set; } = ""; // Also ticker
        public string BaseAssetFullName { get; set; } = "";
        public string TimeOnAlert { get; set; } = ""; // This can be set to the scan time when they are first received.  Alerts will only fire when the list of alerts on the screen has new ones
        public string Exchange { get; set; } = "";
        public DateTime CreationTime { get; set; } = new DateTime();

        public StockScreenerAlert()
        {
            CreationTime = DateTime.UtcNow;
        }

        public static async Task<StockScreenerAlert> ExtractStockScreenerAlertsFromString(string Search)
        {
            if (Search != "")
            {
                StockScreenerAlert ThisAction = new StockScreenerAlert();

                try
                {
                    // Gets text, replaces values if they were encoded, then searches for useful parts of text to grab values from
                    string BodyText = Search;
                    //BodyText = BodyText.Replace("&lt;", "<").Replace("&gt;", ">");


                    // Action to take
                    int TradingPairOrSymbolFrom = BodyText.IndexOf("data-symbol=\"") + "data-symbol=\"".Length;
                    string SearchTradingPairOrSymbolFrom = BodyText.Substring(TradingPairOrSymbolFrom);
                    //TradingPairOrSymbolFrom = SearchTradingPairOrSymbolFrom.IndexOf("\">");
                    //SearchTradingPairOrSymbolFrom = SearchTradingPairOrSymbolFrom.Substring(TradingPairOrSymbolFrom);
                    int TradingPairOrSymbolTo = SearchTradingPairOrSymbolFrom.IndexOf("\"") + TradingPairOrSymbolFrom;

                    string TradingPairOrSymbolString = "";
                    if (TradingPairOrSymbolFrom >= 0 && TradingPairOrSymbolTo > TradingPairOrSymbolFrom)
                        TradingPairOrSymbolString = BodyText.Substring(TradingPairOrSymbolFrom, TradingPairOrSymbolTo - TradingPairOrSymbolFrom);

                    ThisAction.TradingPairOrSymbol = TradingPairOrSymbolString;

                   
                    ThisAction.Id = Guid.NewGuid().ToString();
                }
                catch (Exception ex)
                {
                    return null;
                }

                return ThisAction;
            }
            else
            {
                return null;
            }
        }
    }
}
