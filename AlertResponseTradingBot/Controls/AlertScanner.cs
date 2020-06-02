using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plugin;
using CefSharp.WinForms;
using CefSharp;
using Core;
using System.Threading;
using CoreDiscord;
using CoreTwitter;
using System.Diagnostics;
using MetroFramework.Forms;

namespace TradeAlertResponder.Controls
{
    public partial class AlertScanner : UserControl
    {

        private IAlertScanPlugin Plugin;
        private ChromiumWebBrowser ChromeBrowser;
        public bool IsScanning = false;
        private NotifyIcon Notification = new NotifyIcon();

        public AlertScanner(IAlertScanPlugin _Plugin)
        {
            InitializeComponent();

            Notification.Visible = false;
            Plugin = _Plugin;
            lblPluginTextFriendlyName.Text = Plugin.Name;
            lblAuthor.Text = "Created By: " + Plugin.AuthorName;

            if(Plugin.UseBrowserScanning || Plugin.UseCustomHTML)
            {
                InitializeChrome();
            }
            else
            {
                btnHome.Visible = false;
            }
                

        }

        private void InitializeChrome()
        {
            //CefSettings settings = new CefSettings();
            //string CachePath = Constants.AppFolder(Constants.AppDirectory.Browser);

            //settings.CachePath = CachePath;
            //settings.PersistSessionCookies = true;

            //// Initialize cef with the provided settings
            //Cef.Initialize(settings);
            //// Create a browser component
            ///

            if(Plugin.UseCustomHTML)
            {
                ChromeBrowser = new ChromiumWebBrowser("<br/>")
                {

                    RequestHandler = new MyCefTradingViewBrowserRequestHandler()

                };
                ChromeBrowser.LoadHtml(Plugin.CustomHTML);
            }
            else
            {
                ChromeBrowser = new ChromiumWebBrowser(Plugin.StartURL)
                {

                    RequestHandler = new MyCefTradingViewBrowserRequestHandler()

                };
            }

            // Add it to the form and fill it to the form window.
            pnlBrowser.Controls.Add(ChromeBrowser);
            ChromeBrowser.Dock = DockStyle.Fill;
        }

        private void btnScanForAlerts_Click(object sender, EventArgs e)
        {
            //HideFocus();

            if (IsScanning)
            {
                IsScanning = false;
                btnScanForAlerts.IconColor = System.Drawing.Color.White;
            }
            else
            {
                IsScanning = true;
                btnScanForAlerts.IconColor = System.Drawing.Color.Lime;
                Task.Run(() => ScanForAlerts());
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (Plugin.UseBrowserScanning || Plugin.UseCustomHTML)
            {
                if(Plugin.UseCustomHTML)
                {
                    ChromeBrowser.LoadHtml(Plugin.CustomHTML);
                }
                else
                {
                    ChromeBrowser.Load(Plugin.StartURL);
                }
                
            }
        }

        private async Task ScanForAlerts()
        {
            AlertScanResult ASR = new AlertScanResult();
            while (IsScanning)
            {
                List<Alert> ScannedAlerts = new List<Alert>();
                List<Alert> AlertsAtScan = new List<Alert>();
                string source = "";

                if (Plugin.UseBrowserScanning) // Only scans browser HTML in custom mode if it is specifically set
                {
                    
                    try
                    {
                        
                        source = await ChromeBrowser.GetBrowser().MainFrame.GetSourceAsync();

                        ASR = Plugin.Scan(source, MainNew.AlertSettings.MyBotName);
                        if (ASR.SourceIsValid)
                            ScannedAlerts.AddRange(ASR.AlertsScanned);

                        
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else
                {
                    //Custom scanning method
                    try
                    {
                        ASR = Plugin.Scan(MainNew.AlertSettings.MyBotName);
                        if (ASR.SourceIsValid)
                            ScannedAlerts.AddRange(ASR.AlertsScanned);
                    }
                    catch(Exception ex)
                    {

                    }
                }

                if(ScannedAlerts.Any())
                {
                    AlertsAtScan = MainNew.Alerts; // Doing this helps with exceptions - should reconsider if alerts get duplicated.

                    Parallel.ForEach(ScannedAlerts, ThisAlert =>//Alert ThisAlert in ScannedAlerts)
                    {
                        if (ThisAlert != null)
                            if (ThisAlert.Id != "" && ThisAlert.TimeOnAlert != "")
                                if (!AlertsAtScan.Any(a => a.TimeOnAlert == ThisAlert.TimeOnAlert && a.Exchange == ThisAlert.Exchange && a.Ticker == ThisAlert.Ticker))
                                {
                                    MainNew.Alerts.Add(ThisAlert);
                                    Task.Run(() => ProcessAlert(ThisAlert));
                                }
                    });
                }

                Thread.Sleep(Plugin.DelayBetweenScansInMilliseconds > 1000 ? Plugin.DelayBetweenScansInMilliseconds : 1000);
            }
        }

        private async Task ProcessAlert(Alert Alert)
        {
            try
            {
                if (MainNew.AlertSettings.NotificationOnAlert)
                    Task.Run(() => SystemNotification(Alert));

                bool DiscordOnAlert = MainNew.AlertSettings.DiscordOnAlert;
                bool AddURLScreenshotToDiscord = MainNew.DiscordSettings.ScreenshotsInAlerts;
                bool TweetOnAlert = MainNew.AlertSettings.TweetOnAlert;
                bool AddURLScreenshotToTweet = MainNew.TwitterSettings.ScreenshotsInAlerts;

                bool WillGenerateMessage = (TweetOnAlert && MainNew.TwitterSettings.Enabled && MainNew.TwitterSettings.VerifiedByUserAsWorking)
                    || (DiscordOnAlert && MainNew.DiscordSettings.Enabled && MainNew.DiscordSettings.VerifiedByUserAsWorking);
                bool WillHaveScreenShot = WillGenerateMessage && (AddURLScreenshotToDiscord || AddURLScreenshotToTweet);

                bool WillTweet = (TweetOnAlert && MainNew.TwitterSettings.Enabled && MainNew.TwitterSettings.VerifiedByUserAsWorking);
                bool WillDiscord = (DiscordOnAlert && MainNew.DiscordSettings.Enabled && MainNew.DiscordSettings.VerifiedByUserAsWorking);




                if (WillGenerateMessage)
                {
                    string DirectoryPath = Constants.AppFolder(Constants.AppDirectory.Screenshots);

                    CoreScreen.Screen.ScreenshotResult ScreenshotResult = WillHaveScreenShot ? MainNew.Screen.Screenshot(Alert.URL, DirectoryPath, MainNew.ScreenshotSettings.IncludeLogoWatermark, Constants.WatermarkFilePath, MainNew.ScreenshotSettings.CropStartPoint, MainNew.ScreenshotSettings.CropSize, MainNew.ScreenshotSettings.DoCropImage).GetAwaiter().GetResult() : null;

                    DateTime NowTime = DateTime.UtcNow;

                    string Message = (MainNew.AlertSettings.MyBotName != "" ? MainNew.AlertSettings.MyBotName : "") + (MainNew.AlertSettings.MyBotStatus != "" ? " [" + MainNew.AlertSettings.MyBotStatus + "]" : "") + (Alert.BaseAsset != "" ? " $" + Alert.BaseAsset : "") + (Alert.BaseAssetFullName != "" ? " #" + Alert.BaseAssetFullName : "") +
                                        "\n" +
                                        (Alert.Ticker != "" ? "\nTicker: " + Alert.Ticker : "") +
                                        ((Alert.Action.ToString() != "" || Alert.Action.ToString() == "None") ? "\nAction: " + Alert.Action : "") +
                                        (Alert.Resolution != "" ? "\nResolution: " + Alert.Resolution : "") +
                                        (Alert.Price != "" ? "\nPrice: " + Alert.Price : "") +
                                        (MainNew.AlertSettings.ShowUTCTimeStamp ? "\nDate: " + NowTime.ToShortDateString() + " " + NowTime.ToShortTimeString() + " UTC" : "") +
                                        (Alert.URL != "" ? "\n\nURL: " + Alert.URL : "") +
                                        (Alert.Note != "" ? "\nNote: " + Alert.Note : "") +
                                        (MainNew.AlertSettings.ReferralURL != "" ? "\nReferrals: " + MainNew.AlertSettings.ReferralURL : "") +
                                        (MainNew.AlertSettings.Disclaimertext != "" ? "\n\n" + MainNew.AlertSettings.Disclaimertext : "");

                    if (WillTweet)
                    {
                        if (AddURLScreenshotToTweet)
                        {
                            if (ScreenshotResult != null)
                            {
                                if (ScreenshotResult.Succeeded)
                                {
                                    Task.Run(() => MainNew.Twitter.TweetWithPngImage(Message, ScreenshotResult.ImageFilePath));
                                }
                                else
                                {
                                    //still send message here
                                    Task.Run(() => MainNew.Twitter.Tweet(Message));
                                }
                            }
                            else
                            {
                                //still send message here
                                Task.Run(() => MainNew.Twitter.Tweet(Message));
                            }
                        }
                        else
                        {
                            //still send message here
                            Task.Run(() => MainNew.Twitter.Tweet(Message));
                        }
                    }
                    if (WillDiscord)
                    {
                        if (AddURLScreenshotToDiscord)
                        {
                            if (ScreenshotResult != null)
                            {
                                if (ScreenshotResult.Succeeded)
                                {
                                    Task.Run(() => MainNew.Discord.SendFile(ScreenshotResult.ImageFilePath, Message, MainNew.DiscordSettings.TagHere, MainNew.DiscordSettings.TagEveryone));
                                }
                                else
                                {
                                    //still send message here
                                    Task.Run(() => MainNew.Discord.SendMessage(Message, MainNew.DiscordSettings.TagHere, MainNew.DiscordSettings.TagEveryone));
                                }
                            }
                            else
                            {
                                //still send message here
                                Task.Run(() => MainNew.Discord.SendMessage(Message, MainNew.DiscordSettings.TagHere, MainNew.DiscordSettings.TagEveryone));
                            }
                        }
                        else
                        {
                            //still send message here
                            Task.Run(() => MainNew.Discord.SendMessage(Message, MainNew.DiscordSettings.TagHere, MainNew.DiscordSettings.TagEveryone));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string stopper = "stopped";
            }

        }

        private async Task SystemNotification(Alert Alert)
        {
            Notification.ShowBalloonTip(1000, Constants.ProjectName + " " + MainNew.AlertSettings.MyBotName + " - Alert!", "The application has found a new alert.  " + (Alert.Ticker != "" ? "Ticker: " + Alert.Ticker : "") + ((Alert.Action.ToString() != "" || Alert.Action.ToString() == "None") ? " Action: " + Alert.Action : ""), ToolTipIcon.Info);
        }

        private void lblAuthor_Click(object sender, EventArgs e)
        {
            if (Uri.IsWellFormedUriString(Plugin.AuthorURL, UriKind.Absolute))
                Process.Start(Plugin.AuthorURL);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MetroForm SettingsForm = new MetroForm();
            SettingsForm.Controls.Add(Plugin.PluginInstanceSettings);
            Plugin.PluginInstanceSettings.Dock = DockStyle.Fill;
            SettingsForm.Show();
        }
    }
}
