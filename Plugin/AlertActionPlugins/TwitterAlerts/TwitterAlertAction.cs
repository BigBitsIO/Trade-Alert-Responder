using Core;
using CoreTwitter;
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
    public class TwitterAlertAction : IAlertActionPlugin
    {

        public static Twitter Twitter = NewTwitter();

        public string Name
        {
            get
            {
                return "Twitter Alerts";
            }
        }

        public string ShortName
        {
            get
            {
                return "Twitter Alerts";
            }
        }

        public string Description
        {
            get
            {
                return "Will send a tweet on Twitter.";
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
                Properties.Settings.Default.TwitterAlertsEnabled = value;
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
                return GetUseScreenshotSetting();
            }
        }

        public UserControl About()
        {
            return new TwitterAlertActionAbout();
        }

        public AlertActionResult Action(Alert Alert, ScreenshotResult ScreenshotResult, string Message)
        {
            try
            {
                if (Properties.Settings.Default.TwitterAlertsUseScreenshot)
                {
                    if (ScreenshotResult != null)
                    {
                        if (ScreenshotResult.Succeeded)
                        {
                            Task.Run(() => Twitter.TweetWithPngImage(Message, ScreenshotResult.ImageFilePath));
                        }
                        else
                        {
                            //still send message here
                            Task.Run(() =>Twitter.Tweet(Message));
                        }
                    }
                    else
                    {
                        //still send message here
                        Task.Run(() => Twitter.Tweet(Message));
                    }
                }
                else
                {
                    //still send message here
                    Task.Run(() => Twitter.Tweet(Message));
                }

                AlertActionResult AAR = new AlertActionResult();
                AAR.Succeeded = true;
                AAR.ErrorMessage = "";

                return AAR;
            }
            catch(Exception ex)
            {
                return new AlertActionResult();
            }
        }

        public UserControl PluginSettings()
        {
            return new TwitterAlertActionSettings();
        }

        private bool GetEnabledSetting()
        {
            return Properties.Settings.Default.TwitterAlertsEnabled;
        }

        private bool GetUseScreenshotSetting()
        {
            return Properties.Settings.Default.TwitterAlertsUseScreenshot;
        }

        public static Twitter NewTwitter()
        {
            try
            {
                return new Twitter(Properties.Settings.Default.TwitterAlertsConsumerKey, Properties.Settings.Default.TwitterAlertsConsumerSecret, Properties.Settings.Default.TwitterAlertsAccessToken, Properties.Settings.Default.TwitterAlertsAccessTokenSecret);
            }
            catch (Exception ex)
            {
                return new Twitter("", "", "", "");
            }

        }

    }
}
