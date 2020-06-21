using Core;
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
                //if (Properties.Settings.Default.TwitterAlertsUseScreenshot)
                //{
                //    if (ScreenshotResult != null)
                //    {
                //        if (ScreenshotResult.Succeeded)
                //        {
                //            Task.Run(() => Twitter.SendFile(ScreenshotResult.ImageFilePath, Message, Properties.Settings.Default.TwitterAlertTagHere, Properties.Settings.Default.TwitterAlertTagEveryone));
                //        }
                //        else
                //        {
                //            //still send message here
                //            Task.Run(() => Twitter.SendMessage(Message, Properties.Settings.Default.TwitterAlertTagHere, Properties.Settings.Default.TwitterAlertTagEveryone));
                //        }
                //    }
                //    else
                //    {
                //        //still send message here
                //        Task.Run(() => Twitter.SendMessage(Message, Properties.Settings.Default.TwitterAlertTagHere, Properties.Settings.Default.TwitterAlertTagEveryone));
                //    }
                //}
                //else
                //{
                //    //still send message here
                //    Task.Run(() => Twitter.SendMessage(Message, Properties.Settings.Default.TwitterAlertTagHere, Properties.Settings.Default.TwitterAlertTagEveryone));
                //}

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

    }
}
