using Core;
using CoreWebRequest;
using Plugin.AlertScanPlugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CoreScreen.Screen;

namespace Plugin.AlertActionPlugins
{
    public class WebhookAlertAction : IAlertActionPlugin
    {


        public string Name
        {
            get
            {
                return "Webhook Alerts";
            }
        }

        public string ShortName
        {
            get
            {
                return "Webhook Alerts";
            }
        }

        public string Description
        {
            get
            {
                return "Will send a message to a Webhook.";
            }
        }

        public bool Enabled
        {
            get
            {
                return GetEnabledSetting();
            }
            set
            {
                Properties.Settings.Default.WebhookAlertsEnabled = value;
                Properties.Settings.Default.Save();
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

        public bool UseScreenshot
        {
            get
            {
                return false; // Must be present due to interface
            }
        }

        public UserControl About()
        {
            return new WebhookAlertActionAbout();
        }

        public AlertActionResult Action(Alert Alert, ScreenshotResult ScreenshotResult, string Message)
        {
            try
            {

                List<WebhookItem> Webhooks = WebhookItem.ParseWebhookInfo(Alert.WebhookURL, Alert.WebhookMessage, Alert.WebhookJSON);

                foreach (WebhookItem wh in Webhooks)
                {
                    if (wh.IsJSON)
                    {
                        Task.Run(() => WebRequest.POST(wh.URL, "", true, wh.Message));
                    }
                    else
                    {
                        Task.Run(() => WebRequest.POST(wh.URL, wh.Message));
                    }
                }

                AlertActionResult AAR = new AlertActionResult();
                AAR.Succeeded = true;
                AAR.ErrorMessage = "";

                return AAR;
            }
            catch (Exception ex)
            {
                return new AlertActionResult();
            }
            

        }

        public UserControl PluginSettings()
        {
            return new WebhookAlertActionSettings();
        }

        private bool GetEnabledSetting()
        {
            return Properties.Settings.Default.WebhookAlertsEnabled;
        }

    }

    public class WebhookItem
    {
        public string URL { get; set; } = "";
        public string Message { get; set; } = "";

        public bool IsJSON { get; set; } = false;

        public static List<WebhookItem> ParseWebhookInfo(string URLs, string Messages, string IsJSONs)
        {
            try
            {
                bool URLFound = true;
                int i = 1;
                string LastURL = "";
                string LastMessage = "";
                string LastIsJSON = "";
                List<WebhookItem> Webhooks = new List<WebhookItem>();

                while(URLFound)
                {
                    WebhookItem WI = new WebhookItem();
                    bool iFound = false;

                    int URLFrom = URLs.IndexOf("<" + i.ToString() + ">") + ("<" + i.ToString() + ">").Length;
                    int URLTo = URLs.IndexOf("</" + i + ">");

                    string URLString = "";
                    if (URLFrom >= 0 && URLTo > URLFrom)
                    {
                        URLString = URLs.Substring(URLFrom, URLTo - URLFrom);
                        LastURL = URLString;
                        iFound = true;
                    }
                    else
                        URLString = i > 1 ? LastURL : "";

                    WI.URL = URLString;


                    int MessageFrom = Messages.IndexOf("<" + i.ToString() + ">") + ("<" + i.ToString() + ">").Length;
                    int MessageTo = Messages.IndexOf("</" + i + ">");

                    string MessageString = "";
                    if (MessageFrom >= 0 && MessageTo > MessageFrom)
                    { 
                        MessageString = Messages.Substring(MessageFrom, MessageTo - MessageFrom);
                        LastMessage = MessageString;
                        iFound = true;
                    }
                    else
                        MessageString = i > 1 ? LastMessage : "";

                    WI.Message = MessageString;

                    int IsJSONFrom = IsJSONs.IndexOf("<" + i.ToString() + ">") + ("<" + i.ToString() + ">").Length;
                    int IsJSONTo = IsJSONs.IndexOf("</" + i + ">");

                    string IsJSONString = "";
                    if (IsJSONFrom >= 0 && IsJSONTo > IsJSONFrom)
                    { 
                        IsJSONString = IsJSONs.Substring(IsJSONFrom, IsJSONTo - IsJSONFrom);
                        LastIsJSON = IsJSONString;
                        iFound = true;
                    }
                    else
                        IsJSONString = i > 1 ? IsJSONString : "";

                    WI.IsJSON = IsJSONString.ToLower() == "true" || IsJSONString == "1";

                    URLFound = iFound;

                    i++;

                    if (iFound)
                        Webhooks.Add(WI);

                }

                return Webhooks;
            }
            catch(Exception ex)
            {
                return new List<WebhookItem>();
            }
            
        }
    }
}
