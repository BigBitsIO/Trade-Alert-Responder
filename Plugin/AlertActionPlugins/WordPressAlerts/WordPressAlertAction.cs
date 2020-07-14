using Core;
using CoreWordPress;
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
    public class WordPressAlertAction : IAlertActionPlugin
    {

        public static WordPress WordPress = NewWordPress();

        public string Name
        {
            get
            {
                return "WordPress Alerts";
            }
        }

        public string ShortName
        {
            get
            {
                return "WordPress Alerts";
            }
        }

        public string Description
        {
            get
            {
                return "Will send a message to a text channel in WordPress.";
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
                Properties.Settings.Default.WordPressAlertsEnabled = value;
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
            return new WordPressAlertActionAbout();
        }

        public AlertActionResult Action(Alert Alert, ScreenshotResult ScreenshotResult, string Message)
        {

            // TODO: figure out how to have custom HTML, titles, tags/categories, etc...
            // TODO: have it actually post
            try
            {
                if (Properties.Settings.Default.WordPressAlertsUseScreenshot)
                {
                    if (ScreenshotResult != null)
                    {
                        if (ScreenshotResult.Succeeded)
                        {
                            //Task.Run(() => WordPress.SendFile(ScreenshotResult.ImageFilePath, Message, Properties.Settings.Default.WordPressAlertTagHere, Properties.Settings.Default.WordPressAlertTagEveryone));
                        }
                        else
                        {
                            //still send message here
                            //Task.Run(() => WordPress.SendMessage(Message, Properties.Settings.Default.WordPressAlertTagHere, Properties.Settings.Default.WordPressAlertTagEveryone));
                        }
                    }
                    else
                    {
                        //still send message here
                        //Task.Run(() => WordPress.SendMessage(Message, Properties.Settings.Default.WordPressAlertTagHere, Properties.Settings.Default.WordPressAlertTagEveryone));
                    }
                }
                else
                {
                    //still send message here
                    //Task.Run(() => WordPress.SendMessage(Message, Properties.Settings.Default.WordPressAlertTagHere, Properties.Settings.Default.WordPressAlertTagEveryone));
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
            return new WordPressAlertActionSettings();
        }

        private bool GetEnabledSetting()
        {
            return Properties.Settings.Default.WordPressAlertsEnabled;
        }

        private bool GetUseScreenshotSetting()
        {
            return Properties.Settings.Default.WordPressAlertsUseScreenshot;
        }

        public static WordPress NewWordPress()
        {
            try
            {
                return new WordPress(Properties.Settings.Default.WordPressAlertAPIURL, Properties.Settings.Default.WordPressAlertAPIUser, Properties.Settings.Default.WordPressAlertAPIUserPassword);
            }
            catch(Exception ex)
            {
                return new WordPress("", "","");
            }
            
        }

    }
}
