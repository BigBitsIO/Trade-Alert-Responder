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

    [Serializable]
    public class Alert
    {
        public string Ticker { get; set; } = "";
        public AlertType Action { get; set; } = AlertType.None; // Default to None
        public string Price { get; set; } = ""; 
        public string Exchange { get; set; } = "";
        public DateTime CreationTime { get; set; } = new DateTime();
        public string BaseAsset { get; set; } = "";
        public string QuoteAsset { get; set; } = "";
        public string BaseAssetFullName { get; set; } = "";
        public string Resolution { get; set; } = "";
        public string Note { get; set; } = "";
        public string URL { get; set; } = "";

        public string Id { get; set; } = "";
        public string TimeOnAlert { get; set; } = "";
        
        

        public Alert()
        {
            CreationTime = DateTime.UtcNow;
        }

        public static async Task<Alert> ExtractAlertsFromString(string Search, string BotRootElement)
        {
            string Root = BotRootElement.ToLower();
            if (Search != "")
            {
                Alert ThisAlert = new Alert();

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
                        ThisAlert.Action = AlertType.Buy;
                    }
                    else if (ActionString == "Sell")
                    {
                        ThisAlert.Action = AlertType.Sell;
                    }
                    else
                    {
                        ThisAlert.Action = AlertType.None;
                    }


                    // URL for chart if any
                    int URLFrom = BodyText.IndexOf("<url>") + "<url>".Length;
                    int URLTo = BodyText.IndexOf("</url>");

                    string URLString = "";
                    if (URLFrom >= 0 && URLTo > URLFrom)
                        URLString = BodyText.Substring(URLFrom, URLTo - URLFrom);

                    ThisAlert.URL = URLString;


                    // Note for chart if any
                    int NoteFrom = BodyText.IndexOf("<note>") + "<note>".Length;
                    int NoteTo = BodyText.IndexOf("</note>");

                    string NoteString = "";
                    if (NoteFrom >= 0 && NoteTo > NoteFrom)
                        NoteString = BodyText.Substring(NoteFrom, NoteTo - NoteFrom);

                    ThisAlert.Note = NoteString;

                    // Base for chart if any
                    int BaseFrom = BodyText.IndexOf("<base>") + "<base>".Length;
                    int BaseTo = BodyText.IndexOf("</base>");

                    string BaseString = "";
                    if (BaseFrom >= 0 && BaseTo > BaseFrom)
                        BaseString = BodyText.Substring(BaseFrom, BaseTo - BaseFrom);

                    ThisAlert.BaseAsset = BaseString;

                    // Quote for chart if any
                    int QuoteFrom = BodyText.IndexOf("<quote>") + "<quote>".Length;
                    int QuoteTo = BodyText.IndexOf("</quote>");

                    string QuoteString = "";
                    if (QuoteFrom >= 0 && QuoteTo > QuoteFrom)
                        QuoteString = BodyText.Substring(QuoteFrom, QuoteTo - QuoteFrom);

                    ThisAlert.QuoteAsset = QuoteString;

                    // Ticker for chart if any
                    int TickerFrom = BodyText.IndexOf("<ticker>") + "<ticker>".Length;
                    int TickerTo = BodyText.IndexOf("</ticker>");

                    string TickerString = "";
                    if (TickerFrom >= 0 && TickerTo > TickerFrom)
                        TickerString = BodyText.Substring(TickerFrom, TickerTo - TickerFrom);

                    ThisAlert.Ticker = TickerString;

                    // Resolution for chart if any
                    int ResolutionFrom = BodyText.IndexOf("<res>") + "<res>".Length;
                    int ResolutionTo = BodyText.IndexOf("</res>");

                    string ResolutionString = "";
                    if (ResolutionFrom >= 0 && ResolutionTo > ResolutionFrom)
                        ResolutionString = BodyText.Substring(ResolutionFrom, ResolutionTo - ResolutionFrom);

                    ThisAlert.Resolution = ResolutionString;

                    // Price for chart if any
                    int PriceFrom = BodyText.IndexOf("<price>") + "<price>".Length;
                    int PriceTo = BodyText.IndexOf("</price>");

                    string PriceString = "";
                    if (PriceFrom >= 0 && PriceTo > PriceFrom)
                        PriceString = BodyText.Substring(PriceFrom, PriceTo - PriceFrom);

                    ThisAlert.Price = PriceString;

                    // AssetFullName for chart if any
                    int AssetFullNameFrom = BodyText.IndexOf("<basefull>") + "<basefull>".Length;
                    int AssetFullNameTo = BodyText.IndexOf("</basefull>");

                    string AssetFullNameString = "";
                    if (AssetFullNameFrom >= 0 && AssetFullNameTo > AssetFullNameFrom)
                        AssetFullNameString = BodyText.Substring(AssetFullNameFrom, AssetFullNameTo - AssetFullNameFrom);

                    ThisAlert.BaseAssetFullName = AssetFullNameString;

                    // Exchange for chart if any
                    int ExchangeFrom = BodyText.IndexOf("<ex>") + "<ex>".Length;
                    int ExchangeTo = BodyText.IndexOf("</ex>");

                    string ExchangeString = "";
                    if (ExchangeFrom >= 0 && ExchangeTo > ExchangeFrom)
                        ExchangeString = BodyText.Substring(ExchangeFrom, ExchangeTo - ExchangeFrom);

                    ThisAlert.Exchange = ExchangeString;

                    // Time for chart if any
                    int TimeFrom = BodyText.IndexOf("<time>") + "<time>".Length;
                    int TimeTo = BodyText.IndexOf("</time>");

                    string TimeString = "";
                    if (TimeFrom >= 0 && TimeTo > TimeFrom)
                        TimeString = BodyText.Substring(TimeFrom, TimeTo - TimeFrom);

                    ThisAlert.TimeOnAlert = TimeString;

                    // Set Id
                    if (BotString != "")
                        ThisAlert.Id = Guid.NewGuid().ToString();
                }
                catch (Exception ex)
                {
                    return null;
                }

                return ThisAlert;
            }
            else
            {
                return null;
            }
        }
    }
}
