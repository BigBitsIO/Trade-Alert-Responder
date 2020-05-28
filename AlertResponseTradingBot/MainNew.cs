using Core;
using CefSharp;
using CefSharp.WinForms;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreDiscord;
using CoreTwitter;
using System.Runtime.CompilerServices;
using CoreScreen;
using System.Diagnostics;
using FontAwesome.Sharp;
using System.Drawing;
using CoreTelegram;
using System.IO.MemoryMappedFiles;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using Plugin;
using TradeAlertResponder.Controls;
using System.Xml.Serialization;
using CoreGithub;
using MetroFramework.Controls;

namespace TradeAlertResponder
{
    public partial class MainNew : MetroForm
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(MainNew));

        // BROWSER SPECIFIC
        // Video Tab Specific
        private ChromiumWebBrowser ChromeBrowserVideos;

        // PLUGINS
        AlertScanPluginLoader ASPL = new AlertScanPluginLoader();
        AlertActionPluginLoader AAPL = new AlertActionPluginLoader();

        // Bot Actions that have been scanned
        public static List<Alert> Alerts = new List<Alert>();
        int LastAlertsSaveCount = 0;
        int LastAlertsTextUpdateCount = 0;

        //Grid Data
        private BindingSource AlertsSource = new BindingSource();
        private bool AlertTableConfigured = false;

        // Social Media Settings
        public static TwitterSettings TwitterSettings { get; set; } = new TwitterSettings();
        public static DiscordSettings DiscordSettings { get; set; } = new DiscordSettings();
        public static Discord Discord = new Discord("", 0, 0);
        public static Twitter Twitter = new Twitter("", "", "", "");
        public Telegram Telegram = new Telegram("");

        // Alert Settings
        public static AlertSettings AlertSettings = new AlertSettings();

        // Screenshot Settings
        public static ScreenshotSettings ScreenshotSettings = new ScreenshotSettings();

        // Screenshot class
        public static CoreScreen.Screen Screen = new CoreScreen.Screen();

        //Heartbeat
        private bool Heartbeating = true;

        //Version
        private Version AppVersion;

        private bool MemMapOpen = false;


        public MainNew()
        {
            InitializeComponent();
            LoadVersionInfo().GetAwaiter().GetResult();
            ASPL.LoadPlugins();
            AAPL.LoadPlugins();

            InitializeChromium();

            grdAlerts.DataSource = AlertsSource;

            LoadAlerts().GetAwaiter().GetResult();
            LoadSettings().GetAwaiter().GetResult();
            


            tabMainView.SelectedIndex = 0;

            HideItems().GetAwaiter().GetResult();

            Task.Run(() => AppHeartbeat());

            SelectNavButton(btnTradingViewTab);

            HideFocus();

            

            Notification.Icon = SystemIcons.Application; // Required for balloon notification to show

            //Telegram.ChannelMessage("Testing form load.");
            Core.Logs.Log(Core.Logs.LogLevel.Info, "Form finished loading.");
        }

        private async Task LoadVersionInfo()
        {
            lblApplicationNameAndVersion.Text = Constants.ProjectUserFriendlyName + " " + Constants.Version;
            if (IsVersionCurrent(out AppVersion))
            {
                // hide version upgrade control
                lblUpdate.Visible = false;
            }
            else
            {
                // show version upgrade control with link to new version release
                lblUpdate.Visible = true;
                lblUpdate.Text = "New version " + AppVersion.ToString() + " available!";
            }
        }

        private bool IsVersionCurrent(out Version Version)
        {
            Version Current;
            Version Latest;
            string LatestVersion = "";

            try
            {
                LatestVersion = Github.GetVersion().GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
            }
            

            if (Version.TryParse(Constants.Version, out Current) && Version.TryParse(LatestVersion, out Latest) && LatestVersion != "")
            {
                int result = Latest.CompareTo(Current);
                if (result > 0)
                {
                    Version = Latest;
                    return false;//Latest is greater
                }
                else
                {
                    Version = Current;
                    return true; // Is current, or in a dev environment with newer version in current
                }
            }

            Version = Current;
            return true;
        }

        private async Task AppHeartbeat()
        {

            Task.Run(() => SaveAlertsPeriodically());

            

            while (Heartbeating) // should aways be true, always keep loop running while process is running
            {
                if (AlertSettings.MemMapEnabled && !MemMapOpen)  // Only have the memory map file created if it's enabled
                {
                    Task.Run(() => MemoryMapFile());
                }
            }
        }

        private async Task MemoryMapFile()
        {
            MemMapOpen = true;

            //https://codingvision.net/tips-and-tricks/c-send-data-between-processes-w-memory-mapped-file
            //const int MMF_MAX_SIZE = 1024;  // allocated memory for this memory mapped file (bytes)
            const int MMF_VIEW_SIZE = 1024; // how many bytes of the allocated memory can this process access

            using (MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateNew(Constants.ProjectName + "MemFile", 1000000))
            {
                using (MemoryMappedViewStream mmvStream = memoryMappedFile.CreateViewStream(0, MMF_VIEW_SIZE))
                {
                    try
                    {
                        
                        while (AlertSettings.MemMapEnabled) // keep the file open, and update every X ms using thread sleep.  When disabled, will break loop, closing mem file
                        {
                            List<Alert> MemAlerts = Alerts;
                            // serialize the variable 'message1' and write it to the memory mapped file
                            //BinaryFormatter formatter = new BinaryFormatter();
                            //formatter.Serialize(mmvStream, MemAlerts);

                            XmlSerializer XLM = new XmlSerializer(typeof(List<Alert>));
                            XLM.Serialize(mmvStream, MemAlerts);
                            mmvStream.Seek(0, SeekOrigin.Begin); // sets the current position back to the beginning of the stream


                            Thread.Sleep(1000); // Wait 1 second before updating
                        };
                        
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            MemMapOpen = false;
        }

        private async Task SaveAlertsPeriodically()
        {
            while(true)
            {
                Task.Run(() => SaveAlerts());
                Thread.Sleep(5000);
            }
            
        }
        private async Task HideItems()
        {
            // If we need to hide anything, do it here
        }

        private async Task LoadSettings()
        {
            LoadTwitterSettings().GetAwaiter().GetResult();
            LoadDiscordSettings().GetAwaiter().GetResult();
            LoadAlertSettings().GetAwaiter().GetResult();
            LoadScreenshotSettings().GetAwaiter().GetResult();
        }

        private void LoadAlertsGrid(DataTable AlertsTable)
        {
            AlertsSource.DataSource = AlertsTable;
        }

        private void LoadAlertsGrid()
        {
            
            if(InvokeRequired)
            {
                DataTable AlertsTable = DataHelper.ConvertToDataTable(Alerts);
                Invoke(new Action<DataTable>(LoadAlertsGrid), AlertsTable); // Calls the above function
            }
            else
            {
                DataTable AlertsTable = DataHelper.ConvertToDataTable(Alerts);
                AlertsSource.DataSource = AlertsTable;
            }
                    

            

            if(AlertTableConfigured == false)
            {
                try
                {


                    grdAlerts.Columns["Ticker"].DisplayIndex = 0;
                    grdAlerts.Columns["Action"].DisplayIndex = 1;
                    grdAlerts.Columns["Price"].DisplayIndex = 2;
                    grdAlerts.Columns["Exchange"].DisplayIndex = 3;
                    grdAlerts.Columns["CreationTime"].DisplayIndex = 4;
                    grdAlerts.Columns["BaseAsset"].DisplayIndex = 5;
                    grdAlerts.Columns["QuoteAsset"].DisplayIndex = 6;
                    grdAlerts.Columns["BaseAssetFullName"].DisplayIndex = 7;
                    grdAlerts.Columns["Resolution"].DisplayIndex = 8;
                    grdAlerts.Columns["Note"].DisplayIndex = 9;
                    grdAlerts.Columns["URL"].DisplayIndex = 10;

                    grdAlerts.Columns["Id"].DisplayIndex = 11;
                    grdAlerts.Columns["TimeOnAlert"].DisplayIndex = 12;
                    grdAlerts.Columns["Id"].Visible = false;
                    grdAlerts.Columns["TimeOnAlert"].Visible = false;
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    AlertTableConfigured = true;
                }
            }
            

        }

        private async Task LoadAlerts()
        {
            Alerts = await FileHelper.ImportAlerts();
            LastAlertsSaveCount = Alerts.Count;

            LoadAlertsGrid();
            await SetAlertTabText();
        }

        private async Task LoadAlertSettings()
        {
            AlertSettings = await FileHelper.ImportAlertSettings();
        }

        private async Task LoadDiscordSettings()
        {
            DiscordSettings = await FileHelper.ImportDiscordSettings();
            if (DiscordSettings != null)
            {
                Discord = new Discord(DiscordSettings.BotToken, DiscordSettings.GuildServerId, DiscordSettings.TextChannelId);
            }
            else
            {
                DiscordSettings = new DiscordSettings();
            }
            //
        }
        private async Task LoadTwitterSettings()
        {
            TwitterSettings = await FileHelper.ImportTwitterSettings();
            if (TwitterSettings != null)
            {
                Twitter = new Twitter(TwitterSettings.ConsumerKey, TwitterSettings.ConsumerSecret, TwitterSettings.AccessToken, TwitterSettings.AccessTokenSecret);
            }
            else
            {
                TwitterSettings = new TwitterSettings();
            }

        }

        private async Task LoadScreenshotSettings()
        {
            ScreenshotSettings = await FileHelper.ImportScreenshotSettings();
        }

        private async Task SetAlertTabText()
        {
            if (Alerts.Count > LastAlertsTextUpdateCount)
            {
                //pnlAlertsTab.Invoke(new Action(() => pnlAlertsTab.Text = "Alerts (" + Alerts.Count.ToString() + ")"));
                LastAlertsTextUpdateCount = Alerts.Count;
            }
        }

        private async Task SaveAlerts()
        {
            await FileHelper.ExportAlerts(Alerts);
            LastAlertsSaveCount = Alerts.Count;

            LoadAlertsGrid();
        }

        private void HideFocus()
        {
            btnFocus.Select();
        }

        private void InitializeChromium()
        {
            // ------------- TRADINGVIEW TAB -----------------
            CefSettings settings = new CefSettings();
            string CachePath = Constants.AppFolder(Constants.AppDirectory.Browser);

            settings.CachePath = CachePath;
            settings.PersistSessionCookies = true;

            // Initialize cef with the provided settings
            Cef.Initialize(settings);

            // ------------ OTHER TABS --------------------
            ChromeBrowserVideos = new ChromiumWebBrowser();
            pnlVideoBrowser.Controls.Add(ChromeBrowserVideos);
            ChromeBrowserVideos.Dock = DockStyle.Fill;
            ChromeBrowserVideos.LoadHtml("<html><iframe width=\"100%\" height=\"100%\" src=\"https://www.youtube.com/embed/videoseries?list=PLM0BBafRCnRNhvMxyiqScZWV_h41raut6\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe></html>");

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Heartbeating = false;

            try
            {
                ChromeBrowserVideos.Dispose();
            }
            catch (Exception ex)
            {

            }

            try
            {
                Cef.Shutdown();
            }
            catch (Exception ex)
            {

            }                

            try
            {
                Screen.QuitChrome().GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {

            }
            

            SaveAlerts().GetAwaiter().GetResult();
        }

        private void btnDiscordTest_Click(object sender, EventArgs e)
        {
            HideFocus();

            if (DiscordSettings.Enabled && DiscordSettings.VerifiedByUserAsWorking)
                Task.Run(() => Discord.SendMessage("Test", false));
        }

        private void btnTwitterTest_Click(object sender, EventArgs e)
        {
            HideFocus();

            if (TwitterSettings.Enabled && TwitterSettings.VerifiedByUserAsWorking)
            {
                //Task.Run(() => Twitter.Tweet("Test"));
                string DirectoryPath = Constants.AppFolder(Constants.AppDirectory.Screenshots);
                Task.Run(() => Twitter.TweetWithPngImage("Testing Trade Alert Responder with image.", Screen.Screenshot("https://www.tradingview.com", DirectoryPath, ScreenshotSettings.IncludeLogoWatermark, Constants.WatermarkFilePath, ScreenshotSettings.CropStartPoint, ScreenshotSettings.CropSize, ScreenshotSettings.DoCropImage).GetAwaiter().GetResult().ImageFilePath));
            }
        }

        private void btnDiscordSettings_Click(object sender, EventArgs e)
        {
            HideFocus();

            DiscordSettings RESULT = DiscordSettings;
            DiscordSettingsForm DSF = new DiscordSettingsForm(ref RESULT);
            //DialogResult DR = DSF.ShowDialog();
            DSF.Show();
            Discord = new Discord(DiscordSettings.BotToken, DiscordSettings.GuildServerId, DiscordSettings.TextChannelId);
        }

        private void btnTwitterSettings_Click(object sender, EventArgs e)
        {
            HideFocus();

            TwitterSettings RESULT = TwitterSettings;
            TwitterSettingsForm TSF = new TwitterSettingsForm(ref RESULT);
            //DialogResult DR = TSF.ShowDialog();
            TSF.Show();
            Twitter = new Twitter(TwitterSettings.ConsumerKey, TwitterSettings.ConsumerSecret, TwitterSettings.AccessToken, TwitterSettings.AccessTokenSecret);
        }

        private void btnTradingViewTab_Click(object sender, EventArgs e)
        {
            HideFocus();
            SelectNavButton((IconButton)sender);

        }

        private void btnAlertsTab_Click(object sender, EventArgs e)
        {
            HideFocus();
            SelectNavButton((IconButton)sender);
        }

        private void btnSettingsTab_Click(object sender, EventArgs e)
        {
            HideFocus();
            SelectNavButton((IconButton)sender);
        }

        private void btnVideoTab_Click(object sender, EventArgs e)
        {
            HideFocus();
            SelectNavButton((IconButton)sender);
        }

        private void SelectNavButton(IconButton Button)
        {
            switch (Button.Name)
            {
                case "btnTradingViewTab":
                    tabMainView.SelectedTab = pnlAlertScanTab;
                    AlertScannerContainer ASC = new AlertScannerContainer();
                    pnlAlertScanTab.Controls.Add(ASC);
                    ASC.Dock = DockStyle.Fill;
                    break;
                case "btnAlertsTab":
                    tabMainView.SelectedTab = pnlAlertsTab;
                    break;
                case "btnSettingsTab":
                    tabMainView.SelectedTab = pnlSettingsTab;
                    break;
                case "btnVideoTab":
                    tabMainView.SelectedTab = pnlVideoTab;
                    break;
                case "btnContributeTab":
                    tabMainView.SelectedTab = pnlAboutTab;
                    tabAbout.SelectedTab = pnlAboutInfoTab;
                    break;
                case "btnShopTab":
                    tabMainView.SelectedTab = pnlShopTab;
                    break;
                case "btnAboutTab":
                    tabMainView.SelectedTab = pnlAboutTab;
                    break;
            }

            btnTradingViewTab.IconColor = Button.Name == "btnTradingViewTab" ? System.Drawing.Color.FromArgb(255,0,51,160) : System.Drawing.Color.White;
            btnAlertsTab.IconColor = Button.Name == "btnAlertsTab" ? System.Drawing.Color.FromArgb(255,0,51,160) : System.Drawing.Color.White;
            btnSettingsTab.IconColor = Button.Name == "btnSettingsTab" ? System.Drawing.Color.FromArgb(255,0,51,160) : System.Drawing.Color.White;
            btnVideoTab.IconColor = Button.Name == "btnVideoTab" ? System.Drawing.Color.FromArgb(255,0,51,160) : System.Drawing.Color.White;
            btnContributeTab.IconColor = Button.Name == "btnContributeTab" ? System.Drawing.Color.FromArgb(255,0,51,160) : System.Drawing.Color.White;
            btnShopTab.IconColor = Button.Name == "btnShopTab" ? System.Drawing.Color.FromArgb(255,0,51,160) : System.Drawing.Color.White;
            btnAboutTab.IconColor = Button.Name == "btnAboutTab" ? System.Drawing.Color.FromArgb(255, 0, 51, 160) : System.Drawing.Color.White;
        }

        private void btnPineScriptTutorialPlaylist_Click(object sender, EventArgs e)
        {
            HideFocus();
            ChromeBrowserVideos.LoadHtml("<html><iframe width=\"100%\" height=\"100%\" src=\"https://www.youtube.com/embed/videoseries?list=PLM0BBafRCnRNhvMxyiqScZWV_h41raut6\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe></html>");
        }

        private void btnIndicatorsExplainedPlaylist_Click(object sender, EventArgs e)
        {
            HideFocus();
            ChromeBrowserVideos.LoadHtml("<html><iframe width=\"100%\" height=\"100%\" src=\"https://www.youtube.com/embed/videoseries?list=PLM0BBafRCnRNFHv5lG54qYqbCebOMxz-U\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe></html>");
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bigbits.io");
        }

        private void btnAlertsReset_Click(object sender, EventArgs e)
        {
            Alerts = new List<Alert>();
            Task.Run(() => FileHelper.ExportAlerts(Alerts));
            LoadAlertsGrid();
        }

        private void btnAlertInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alert element: <" + AlertSettings.MyBotName.ToLower() + "></" + AlertSettings.MyBotName.ToLower() + ">" +
                "\nAll alert properties must be within the alert element above." +
                "\n" +
                "\nAlert properties" +
                "\nTicker: <ticker></ticker>" +
                "\nBase Asset: <base></base>" +
                "\nQuote Asset: <quote></quote>" +
                "\nBase Full Name: <basefull></basefull>" +
                "\nPrice: <price></price>" +
                "\nAction/Signal: <act></act>" +
                "\nURL: <url></url>" +
                "\nNote: <note></note>" +
                "\nResolution: <res></res>" +
                "\nExchange: <ex></ex>" +
                "\nTime: <time></time>"
                , "Alert Info", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
        }

        private void btnShopTab_Click(object sender, EventArgs e)
        {
            HideFocus();
            //SelectNavButton((IconButton)sender);
            Process.Start("https://bigbits.io/product-category/all/bigbits/?orderby=price-desc");
        }

        private void btnAlertSettings_Click(object sender, EventArgs e)
        {
            HideFocus();

            AlertSettings RESULT = AlertSettings;
            AlertSettingsForm DSF = new AlertSettingsForm(ref RESULT);
            //DialogResult DR = DSF.ShowDialog();
            DSF.Show();
        }

        private void btnScreenshotSettings_Click(object sender, EventArgs e)
        {
            HideFocus();

            ScreenshotSettings RESULT = ScreenshotSettings;
            ScreenshotSettingsForm DSF = new ScreenshotSettingsForm(ref RESULT);
            //DialogResult DR = DSF.ShowDialog();
            DSF.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Normal;
            this.Focus(); this.Show();
        }

        private void btnContributeTab_Click(object sender, EventArgs e)
        {
            HideFocus();
            SelectNavButton(btnAboutTab);
        }

        private void pnlNavigation_DoubleClick(object sender, EventArgs e)
        {
            //var result = Github.GetVersion().GetAwaiter().GetResult();
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/BigBitsIO/Trade-Alert-Responder/releases/tag/" + AppVersion.ToString());
        }

        private void lblUpdate_MouseLeave(object sender, EventArgs e)
        {
            lblUpdate.ForeColor = Color.Yellow;
        }

        private void lblUpdate_MouseEnter(object sender, EventArgs e)
        {
            lblUpdate.ForeColor = Color.LightSkyBlue;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            HideFocus();
            SelectNavButton((IconButton)sender);
        }
    }
}
