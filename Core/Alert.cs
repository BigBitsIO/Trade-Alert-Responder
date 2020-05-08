using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public enum AlertType
    {
        Buy,
        Sell,
        None,
        Notice,
        TEST
    }

    public class Alert
    {
        public AlertType Action { get; set; } = AlertType.None; // Default to None
        public string Id { get; set; } = "";
        public string URL { get; set; } = "";
        public string Note { get; set; } = "";
        public string Resolution { get; set; } = "See chart.";
        public string Price { get; set; } = "";
        public string QuoteAsset { get; set; } = "";
        public string BaseAsset { get; set; } = "";
        public string DesiredAmount { get; set; } = "";
        public string DesiredPrice { get; set; } = "";
        public string TradingPair { get; set; } = "";
        public string BaseAssetFullName { get; set; } = "";
        public string TimeOnAlert { get; set; } = "";
        public string Exchange { get; set; } = "";
        public DateTime CreationTime { get; set; } = new DateTime();

        public Alert()
        {
            CreationTime = DateTime.UtcNow;
        }

        public static async Task<Alert> ExtractAlertsFromString(string Search, string BotRootElement)
        {
            string Root = BotRootElement.ToLower();
            if (Search != "")
            {
                Alert ThisAction = new Alert();

                try
                {
                    // Gets text, replaces values if they were encoded, then searches for useful parts of text to grab values from
                    string BodyText = Search;
                    if (BodyText.Contains("&lt;" + Root + "&gt;"))
                    {
                        BodyText = BodyText.Replace("&lt;", "<").Replace("&gt;", ">");
                    }
                    int From = BodyText.IndexOf("<" + Root + ">") + ("<" + Root + ">").Length;
                    int To = BodyText.IndexOf("</" + Root + ">");

                    string BotString = "";
                    if (From >= 0 && To > From)
                        BotString = BodyText.Substring(From, To - From);

                    // Action to take
                    int ActionFrom = BodyText.IndexOf("<act>") + "<act>".Length;
                    int ActionTo = BodyText.IndexOf("</act>");

                    string ActionString = "";
                    if (ActionFrom >= 0 && ActionTo > ActionFrom)
                        ActionString = BodyText.Substring(ActionFrom, ActionTo - ActionFrom);

                    if (ActionString == "Buy")
                    {
                        ThisAction.Action = AlertType.Buy;
                    }
                    else if (ActionString == "Sell")
                    {
                        ThisAction.Action = AlertType.Sell;
                    }
                    else
                    {
                        ThisAction.Action = AlertType.None;
                    }

                    // Symbol to trade
                    //int SymbolFrom = BodyText.IndexOf("<symbol>") + "<symbol>".Length;
                    //int SymbolTo = BodyText.IndexOf("</symbol>");

                    //string SymbolString = "";
                    //if (SymbolFrom >= 0 && SymbolTo > SymbolFrom)
                    //    SymbolString = BodyText.Substring(SymbolFrom, SymbolTo - SymbolFrom);

                    //ThisAction.Symbol = SymbolString;


                    // URL for chart if any
                    int URLFrom = BodyText.IndexOf("<url>") + "<url>".Length;
                    int URLTo = BodyText.IndexOf("</url>");

                    string URLString = "";
                    if (URLFrom >= 0 && URLTo > URLFrom)
                        URLString = BodyText.Substring(URLFrom, URLTo - URLFrom);

                    ThisAction.URL = URLString;


                    // Note for chart if any
                    int NoteFrom = BodyText.IndexOf("<note>") + "<note>".Length;
                    int NoteTo = BodyText.IndexOf("</note>");

                    string NoteString = "";
                    if (NoteFrom >= 0 && NoteTo > NoteFrom)
                        NoteString = BodyText.Substring(NoteFrom, NoteTo - NoteFrom);

                    ThisAction.Note = NoteString;

                    // DesiredAmount for chart if any
                    int DesiredAmountFrom = BodyText.IndexOf("<da>") + "<da>".Length;
                    int DesiredAmountTo = BodyText.IndexOf("</da>");

                    string DesiredAmountString = "";
                    if (DesiredAmountFrom >= 0 && DesiredAmountTo > DesiredAmountFrom)
                        DesiredAmountString = BodyText.Substring(DesiredAmountFrom, DesiredAmountTo - DesiredAmountFrom);

                    ThisAction.DesiredAmount = DesiredAmountString;

                    // DesiredPrice for chart if any
                    int DesiredPriceFrom = BodyText.IndexOf("<dp>") + "<dp>".Length;
                    int DesiredPriceTo = BodyText.IndexOf("</dp>");

                    string DesiredPriceString = "";
                    if (DesiredPriceFrom >= 0 && DesiredPriceTo > DesiredPriceFrom)
                        DesiredPriceString = BodyText.Substring(DesiredPriceFrom, DesiredPriceTo - DesiredPriceFrom);

                    ThisAction.DesiredPrice = DesiredPriceString;

                    // Base for chart if any
                    int BaseFrom = BodyText.IndexOf("<base>") + "<base>".Length;
                    int BaseTo = BodyText.IndexOf("</base>");

                    string BaseString = "";
                    if (BaseFrom >= 0 && BaseTo > BaseFrom)
                        BaseString = BodyText.Substring(BaseFrom, BaseTo - BaseFrom);

                    ThisAction.BaseAsset = BaseString;

                    // Quote for chart if any
                    int QuoteFrom = BodyText.IndexOf("<quote>") + "<quote>".Length;
                    int QuoteTo = BodyText.IndexOf("</quote>");

                    string QuoteString = "";
                    if (QuoteFrom >= 0 && QuoteTo > QuoteFrom)
                        QuoteString = BodyText.Substring(QuoteFrom, QuoteTo - QuoteFrom);

                    ThisAction.QuoteAsset = QuoteString;

                    // TradingPair for chart if any
                    int TradingPairFrom = BodyText.IndexOf("<pair>") + "<pair>".Length;
                    int TradingPairTo = BodyText.IndexOf("</pair>");

                    string TradingPairString = "";
                    if (TradingPairFrom >= 0 && TradingPairTo > TradingPairFrom)
                        TradingPairString = BodyText.Substring(TradingPairFrom, TradingPairTo - TradingPairFrom);

                    ThisAction.TradingPair = TradingPairString;

                    // Resolution for chart if any
                    int ResolutionFrom = BodyText.IndexOf("<res>") + "<res>".Length;
                    int ResolutionTo = BodyText.IndexOf("</res>");

                    string ResolutionString = "";
                    if (ResolutionFrom >= 0 && ResolutionTo > ResolutionFrom)
                        ResolutionString = BodyText.Substring(ResolutionFrom, ResolutionTo - ResolutionFrom);

                    ThisAction.Resolution = ResolutionString;

                    // Price for chart if any
                    int PriceFrom = BodyText.IndexOf("<price>") + "<price>".Length;
                    int PriceTo = BodyText.IndexOf("</price>");

                    string PriceString = "";
                    if (PriceFrom >= 0 && PriceTo > PriceFrom)
                        PriceString = BodyText.Substring(PriceFrom, PriceTo - PriceFrom);

                    ThisAction.Price = PriceString;

                    // AssetFullName for chart if any
                    int AssetFullNameFrom = BodyText.IndexOf("<basefull>") + "<basefull>".Length;
                    int AssetFullNameTo = BodyText.IndexOf("</basefull>");

                    string AssetFullNameString = "";
                    if (AssetFullNameFrom >= 0 && AssetFullNameTo > AssetFullNameFrom)
                        AssetFullNameString = BodyText.Substring(AssetFullNameFrom, AssetFullNameTo - AssetFullNameFrom);

                    ThisAction.BaseAssetFullName = AssetFullNameString;

                    // Exchange for chart if any
                    int ExchangeFrom = BodyText.IndexOf("<ex>") + "<ex>".Length;
                    int ExchangeTo = BodyText.IndexOf("</ex>");

                    string ExchangeString = "";
                    if (ExchangeFrom >= 0 && ExchangeTo > ExchangeFrom)
                        ExchangeString = BodyText.Substring(ExchangeFrom, ExchangeTo - ExchangeFrom);

                    ThisAction.Exchange = ExchangeString;

                    // Time for chart if any
                    int TimeFrom = BodyText.IndexOf("<time>") + "<time>".Length;
                    int TimeTo = BodyText.IndexOf("</time>");

                    string TimeString = "";
                    if (TimeFrom >= 0 && TimeTo > TimeFrom)
                        TimeString = BodyText.Substring(TimeFrom, TimeTo - TimeFrom);

                    ThisAction.TimeOnAlert = TimeString;


                    //// Time for chart if any
                    //int TimeTrimIndex = BodyText.IndexOf("alert-log-item-date\">");
                    //int TimeTrimLength = 20;
                    //string TimeString = BodyText.Substring(TimeTrimIndex + "alert-log-item-date\">".Length, TimeTrimLength);
                    //int TimeFrom = 0;
                    //int TimeTo = TimeString.IndexOf("<");

                    //string TimeResult = "";
                    //if (TimeFrom >= 0 && TimeTo > TimeFrom)
                    //    TimeResult = TimeString.Substring(TimeFrom, TimeTo - TimeFrom);

                    //ThisAction.TimeOnAlert = TimeResult;

                    // Set Id
                    if (BotString != "")
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
