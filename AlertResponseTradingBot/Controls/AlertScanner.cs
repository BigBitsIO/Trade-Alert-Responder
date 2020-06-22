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
        
        private MetroForm SettingsForm = new MetroForm();
        private MetroForm AboutForm = new MetroForm();

        public AlertScanner(IAlertScanPlugin _Plugin)
        {
            InitializeComponent();

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
                {
                    Task.Run(() => SystemNotification(Alert));
                }


                string DirectoryPath = Constants.AppFolder(Constants.AppDirectory.Screenshots);
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

                

                // Using Alert Action Plugin Model...
                List<IAlertActionPlugin> AlertActionPlugins = AlertActionPluginLoader.Plugins.Where(a => a.Enabled).ToList();
                if(AlertActionPlugins.Any())
                {
                    // Attempts a screenshot if any enabled plugins say they will use it.  Otherwise returns null.
                    CoreScreen.Screen.ScreenshotResult ScreenshotResult = AlertActionPlugins.Any(a => a.UseScreenshot) ? MainNew.Screen.Screenshot(Alert.URL, DirectoryPath, MainNew.ScreenshotSettings.IncludeLogoWatermark, Constants.WatermarkFilePath, MainNew.ScreenshotSettings.CropStartPoint, MainNew.ScreenshotSettings.CropSize, MainNew.ScreenshotSettings.DoCropImage).GetAwaiter().GetResult() : null;
                    Parallel.ForEach(AlertActionPlugins, (Plugin) =>
                    {
                        Task.Run(() => Plugin.Action(Alert, ScreenshotResult, Message));
                    });
                }
            }
            catch (Exception ex)
            {
                string stopper = "stopped";
            }

        }

        private async Task SystemNotification(Alert Alert)
        {
            NotifyIcon Notification = new NotifyIcon();
            Notification.Visible = true;
            Notification.Icon = System.Drawing.SystemIcons.Information;
            Notification.ShowBalloonTip(1000, Constants.ProjectName + " " + MainNew.AlertSettings.MyBotName + " - Alert!", "The application has found a new alert.  " + (Alert.Ticker != "" ? "Ticker: " + Alert.Ticker : "") + ((Alert.Action.ToString() != "" || Alert.Action.ToString() == "None") ? " Action: " + Alert.Action : ""), ToolTipIcon.Info);
            Thread.Sleep(5000);
            Notification.Dispose();
        }

        private void lblAuthor_Click(object sender, EventArgs e)
        {
            if (Uri.IsWellFormedUriString(Plugin.AuthorURL, UriKind.Absolute))
                Process.Start(Plugin.AuthorURL);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm = new MetroForm();
            SettingsForm.Resizable = false;
            SettingsForm.ShadowType = MetroFormShadowType.DropShadow;
            SettingsForm.MinimizeBox = false;
            SettingsForm.MaximizeBox = false;
            UserControl SettingsControl = Plugin.PluginInstanceSettings();
            SettingsForm.Size = new Size(SettingsControl.Size.Width + 100, SettingsControl.Height + 100);
            SettingsForm.Controls.Add(SettingsControl);
            SettingsControl.Dock = DockStyle.Fill;
            SettingsForm.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm = new MetroForm();
            AboutForm.Resizable = false;
            AboutForm.ShadowType = MetroFormShadowType.DropShadow;
            AboutForm.MinimizeBox = false;
            AboutForm.MaximizeBox = false;
            UserControl AboutControl = Plugin.About();
            AboutForm.Size = new Size(AboutControl.Size.Width + 100, AboutControl.Height + 100);
            AboutForm.Controls.Add(AboutControl);
            AboutControl.Dock = DockStyle.Fill;
            AboutForm.Show();
        }
    }
}
