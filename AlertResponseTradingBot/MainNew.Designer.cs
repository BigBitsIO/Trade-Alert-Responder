using TradeAlertResponder.Controls;

namespace TradeAlertResponder
{
    partial class MainNew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainNew));
            this.grdOrders = new MetroFramework.Controls.MetroGrid();
            this.Notification = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlNavigation = new MetroFramework.Controls.MetroPanel();
            this.btnAboutTab = new FontAwesome.Sharp.IconButton();
            this.btnShopTab = new FontAwesome.Sharp.IconButton();
            this.btnContributeTab = new FontAwesome.Sharp.IconButton();
            this.btnVideoTab = new FontAwesome.Sharp.IconButton();
            this.btnSettingsTab = new FontAwesome.Sharp.IconButton();
            this.btnAlertsTab = new FontAwesome.Sharp.IconButton();
            this.btnTradingViewTab = new FontAwesome.Sharp.IconButton();
            this.pnlContent = new MetroFramework.Controls.MetroPanel();
            this.tabMainView = new System.Windows.Forms.TabControl();
            this.pnlSettingsTab = new System.Windows.Forms.TabPage();
            this.pnlSettingsPanel = new MetroFramework.Controls.MetroPanel();
            this.btnScreenshotSettings = new FontAwesome.Sharp.IconButton();
            this.btnAlertSettings = new FontAwesome.Sharp.IconButton();
            this.btnTwitterTest = new FontAwesome.Sharp.IconButton();
            this.btnDiscordTest = new FontAwesome.Sharp.IconButton();
            this.btnDiscordSettings = new FontAwesome.Sharp.IconButton();
            this.btnTwitterSettings = new FontAwesome.Sharp.IconButton();
            this.pnlAboutTab = new System.Windows.Forms.TabPage();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.tabAbout = new MetroFramework.Controls.MetroTabControl();
            this.pnlAboutInfoTab = new System.Windows.Forms.TabPage();
            this.pnlAboutInfo = new MetroFramework.Controls.MetroPanel();
            this.appInfo = new TradeAlertResponder.Controls.AppInfo();
            this.pnlAboutLogsTab = new System.Windows.Forms.TabPage();
            this.pnlAboutLogs = new MetroFramework.Controls.MetroPanel();
            this.logs = new TradeAlertResponder.Controls.Logs();
            this.pnlAboutDisclaimerTab = new System.Windows.Forms.TabPage();
            this.pnlAboutDisclaimer = new MetroFramework.Controls.MetroPanel();
            this.disclaimer1 = new TradeAlertResponder.Controls.Disclaimer();
            this.pnlContributeTab = new System.Windows.Forms.TabPage();
            this.pnlContributeBrowser = new MetroFramework.Controls.MetroPanel();
            this.pnlAlertsTab = new System.Windows.Forms.TabPage();
            this.btnAlertsReset = new FontAwesome.Sharp.IconButton();
            this.grdAlerts = new MetroFramework.Controls.MetroGrid();
            this.pnlShopTab = new System.Windows.Forms.TabPage();
            this.pnlShopBrowser = new MetroFramework.Controls.MetroPanel();
            this.pnlVideoTab = new System.Windows.Forms.TabPage();
            this.btnIndicatorsExplainedPlaylist = new FontAwesome.Sharp.IconButton();
            this.btnPineScriptTutorialPlaylist = new FontAwesome.Sharp.IconButton();
            this.pnlVideoBrowser = new MetroFramework.Controls.MetroPanel();
            this.pnlAlertScanTab = new System.Windows.Forms.TabPage();
            this.btnFocus = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblApplicationNameAndVersion = new MetroFramework.Controls.MetroLabel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.StyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lblUpdate = new MetroFramework.Controls.MetroLabel();
            this.currentLogMessage1 = new TradeAlertResponder.Controls.CurrentLogMessage();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            this.pnlNavigation.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.tabMainView.SuspendLayout();
            this.pnlSettingsTab.SuspendLayout();
            this.pnlSettingsPanel.SuspendLayout();
            this.pnlAboutTab.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.pnlAboutInfoTab.SuspendLayout();
            this.pnlAboutInfo.SuspendLayout();
            this.pnlAboutLogsTab.SuspendLayout();
            this.pnlAboutLogs.SuspendLayout();
            this.pnlAboutDisclaimerTab.SuspendLayout();
            this.pnlAboutDisclaimer.SuspendLayout();
            this.pnlContributeTab.SuspendLayout();
            this.pnlAlertsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlerts)).BeginInit();
            this.pnlShopTab.SuspendLayout();
            this.pnlVideoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // grdOrders
            // 
            this.grdOrders.AllowUserToResizeRows = false;
            this.grdOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOrders.EnableHeadersVisualStyles = false;
            this.grdOrders.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdOrders.Location = new System.Drawing.Point(0, 0);
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOrders.Size = new System.Drawing.Size(1079, 675);
            this.grdOrders.TabIndex = 0;
            // 
            // Notification
            // 
            this.Notification.Text = "Notification";
            this.Notification.Visible = true;
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlNavigation.Controls.Add(this.btnAboutTab);
            this.pnlNavigation.Controls.Add(this.btnShopTab);
            this.pnlNavigation.Controls.Add(this.btnContributeTab);
            this.pnlNavigation.Controls.Add(this.btnVideoTab);
            this.pnlNavigation.Controls.Add(this.btnSettingsTab);
            this.pnlNavigation.Controls.Add(this.btnAlertsTab);
            this.pnlNavigation.Controls.Add(this.btnTradingViewTab);
            this.pnlNavigation.HorizontalScrollbarBarColor = true;
            this.pnlNavigation.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlNavigation.HorizontalScrollbarSize = 10;
            this.pnlNavigation.Location = new System.Drawing.Point(20, 60);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(48, 640);
            this.pnlNavigation.TabIndex = 0;
            this.pnlNavigation.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlNavigation.VerticalScrollbarBarColor = true;
            this.pnlNavigation.VerticalScrollbarHighlightOnWheel = false;
            this.pnlNavigation.VerticalScrollbarSize = 10;
            this.pnlNavigation.DoubleClick += new System.EventHandler(this.pnlNavigation_DoubleClick);
            // 
            // btnAboutTab
            // 
            this.btnAboutTab.BackColor = System.Drawing.Color.Transparent;
            this.btnAboutTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAboutTab.FlatAppearance.BorderSize = 0;
            this.btnAboutTab.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAboutTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAboutTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAboutTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutTab.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAboutTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutTab.ForeColor = System.Drawing.Color.White;
            this.btnAboutTab.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btnAboutTab.IconColor = System.Drawing.Color.White;
            this.btnAboutTab.IconSize = 35;
            this.btnAboutTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutTab.Location = new System.Drawing.Point(-4, 585);
            this.btnAboutTab.Name = "btnAboutTab";
            this.btnAboutTab.Padding = new System.Windows.Forms.Padding(10);
            this.btnAboutTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAboutTab.Rotation = 0D;
            this.btnAboutTab.Size = new System.Drawing.Size(61, 55);
            this.btnAboutTab.TabIndex = 23;
            this.btnAboutTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAboutTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAboutTab.UseVisualStyleBackColor = false;
            this.btnAboutTab.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnShopTab
            // 
            this.btnShopTab.BackColor = System.Drawing.Color.Transparent;
            this.btnShopTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShopTab.FlatAppearance.BorderSize = 0;
            this.btnShopTab.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnShopTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShopTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnShopTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShopTab.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnShopTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShopTab.ForeColor = System.Drawing.Color.White;
            this.btnShopTab.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnShopTab.IconColor = System.Drawing.Color.White;
            this.btnShopTab.IconSize = 35;
            this.btnShopTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShopTab.Location = new System.Drawing.Point(-4, 495);
            this.btnShopTab.Name = "btnShopTab";
            this.btnShopTab.Padding = new System.Windows.Forms.Padding(10);
            this.btnShopTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnShopTab.Rotation = 0D;
            this.btnShopTab.Size = new System.Drawing.Size(61, 55);
            this.btnShopTab.TabIndex = 22;
            this.btnShopTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShopTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShopTab.UseVisualStyleBackColor = false;
            this.btnShopTab.Click += new System.EventHandler(this.btnShopTab_Click);
            // 
            // btnContributeTab
            // 
            this.btnContributeTab.BackColor = System.Drawing.Color.Transparent;
            this.btnContributeTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContributeTab.FlatAppearance.BorderSize = 0;
            this.btnContributeTab.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnContributeTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnContributeTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnContributeTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContributeTab.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnContributeTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContributeTab.ForeColor = System.Drawing.Color.White;
            this.btnContributeTab.IconChar = FontAwesome.Sharp.IconChar.Bitcoin;
            this.btnContributeTab.IconColor = System.Drawing.Color.White;
            this.btnContributeTab.IconSize = 35;
            this.btnContributeTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContributeTab.Location = new System.Drawing.Point(-4, 540);
            this.btnContributeTab.Name = "btnContributeTab";
            this.btnContributeTab.Padding = new System.Windows.Forms.Padding(10);
            this.btnContributeTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnContributeTab.Rotation = 0D;
            this.btnContributeTab.Size = new System.Drawing.Size(61, 55);
            this.btnContributeTab.TabIndex = 21;
            this.btnContributeTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContributeTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContributeTab.UseVisualStyleBackColor = false;
            this.btnContributeTab.Click += new System.EventHandler(this.btnContributeTab_Click);
            // 
            // btnVideoTab
            // 
            this.btnVideoTab.BackColor = System.Drawing.Color.Transparent;
            this.btnVideoTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVideoTab.FlatAppearance.BorderSize = 0;
            this.btnVideoTab.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnVideoTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVideoTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVideoTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideoTab.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVideoTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoTab.ForeColor = System.Drawing.Color.White;
            this.btnVideoTab.IconChar = FontAwesome.Sharp.IconChar.Youtube;
            this.btnVideoTab.IconColor = System.Drawing.Color.White;
            this.btnVideoTab.IconSize = 35;
            this.btnVideoTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVideoTab.Location = new System.Drawing.Point(-4, 168);
            this.btnVideoTab.Name = "btnVideoTab";
            this.btnVideoTab.Padding = new System.Windows.Forms.Padding(10);
            this.btnVideoTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnVideoTab.Rotation = 0D;
            this.btnVideoTab.Size = new System.Drawing.Size(61, 55);
            this.btnVideoTab.TabIndex = 20;
            this.btnVideoTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVideoTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVideoTab.UseVisualStyleBackColor = false;
            this.btnVideoTab.Click += new System.EventHandler(this.btnVideoTab_Click);
            // 
            // btnSettingsTab
            // 
            this.btnSettingsTab.BackColor = System.Drawing.Color.Transparent;
            this.btnSettingsTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettingsTab.FlatAppearance.BorderSize = 0;
            this.btnSettingsTab.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSettingsTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSettingsTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSettingsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsTab.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSettingsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingsTab.ForeColor = System.Drawing.Color.White;
            this.btnSettingsTab.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnSettingsTab.IconColor = System.Drawing.Color.White;
            this.btnSettingsTab.IconSize = 35;
            this.btnSettingsTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettingsTab.Location = new System.Drawing.Point(-4, 113);
            this.btnSettingsTab.Name = "btnSettingsTab";
            this.btnSettingsTab.Padding = new System.Windows.Forms.Padding(10);
            this.btnSettingsTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSettingsTab.Rotation = 0D;
            this.btnSettingsTab.Size = new System.Drawing.Size(61, 55);
            this.btnSettingsTab.TabIndex = 19;
            this.btnSettingsTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettingsTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettingsTab.UseVisualStyleBackColor = false;
            this.btnSettingsTab.Click += new System.EventHandler(this.btnSettingsTab_Click);
            // 
            // btnAlertsTab
            // 
            this.btnAlertsTab.BackColor = System.Drawing.Color.Transparent;
            this.btnAlertsTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlertsTab.FlatAppearance.BorderSize = 0;
            this.btnAlertsTab.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAlertsTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAlertsTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAlertsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlertsTab.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAlertsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlertsTab.ForeColor = System.Drawing.Color.White;
            this.btnAlertsTab.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.btnAlertsTab.IconColor = System.Drawing.Color.White;
            this.btnAlertsTab.IconSize = 35;
            this.btnAlertsTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlertsTab.Location = new System.Drawing.Point(-4, 58);
            this.btnAlertsTab.Name = "btnAlertsTab";
            this.btnAlertsTab.Padding = new System.Windows.Forms.Padding(10);
            this.btnAlertsTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAlertsTab.Rotation = 0D;
            this.btnAlertsTab.Size = new System.Drawing.Size(61, 55);
            this.btnAlertsTab.TabIndex = 18;
            this.btnAlertsTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlertsTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlertsTab.UseVisualStyleBackColor = false;
            this.btnAlertsTab.Click += new System.EventHandler(this.btnAlertsTab_Click);
            // 
            // btnTradingViewTab
            // 
            this.btnTradingViewTab.BackColor = System.Drawing.Color.Transparent;
            this.btnTradingViewTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTradingViewTab.FlatAppearance.BorderSize = 0;
            this.btnTradingViewTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTradingViewTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTradingViewTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTradingViewTab.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTradingViewTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTradingViewTab.ForeColor = System.Drawing.Color.White;
            this.btnTradingViewTab.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnTradingViewTab.IconColor = System.Drawing.Color.White;
            this.btnTradingViewTab.IconSize = 35;
            this.btnTradingViewTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTradingViewTab.Location = new System.Drawing.Point(-4, 3);
            this.btnTradingViewTab.Name = "btnTradingViewTab";
            this.btnTradingViewTab.Padding = new System.Windows.Forms.Padding(10);
            this.btnTradingViewTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnTradingViewTab.Rotation = 0D;
            this.btnTradingViewTab.Size = new System.Drawing.Size(61, 55);
            this.btnTradingViewTab.TabIndex = 17;
            this.btnTradingViewTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTradingViewTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTradingViewTab.UseVisualStyleBackColor = false;
            this.btnTradingViewTab.Click += new System.EventHandler(this.btnTradingViewTab_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.Controls.Add(this.tabMainView);
            this.pnlContent.HorizontalScrollbarBarColor = true;
            this.pnlContent.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlContent.HorizontalScrollbarSize = 10;
            this.pnlContent.Location = new System.Drawing.Point(74, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1186, 640);
            this.pnlContent.TabIndex = 1;
            this.pnlContent.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlContent.VerticalScrollbarBarColor = true;
            this.pnlContent.VerticalScrollbarHighlightOnWheel = false;
            this.pnlContent.VerticalScrollbarSize = 10;
            // 
            // tabMainView
            // 
            this.tabMainView.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabMainView.Controls.Add(this.pnlSettingsTab);
            this.tabMainView.Controls.Add(this.pnlAboutTab);
            this.tabMainView.Controls.Add(this.pnlContributeTab);
            this.tabMainView.Controls.Add(this.pnlAlertsTab);
            this.tabMainView.Controls.Add(this.pnlShopTab);
            this.tabMainView.Controls.Add(this.pnlVideoTab);
            this.tabMainView.Controls.Add(this.pnlAlertScanTab);
            this.tabMainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMainView.ItemSize = new System.Drawing.Size(0, 1);
            this.tabMainView.Location = new System.Drawing.Point(0, 0);
            this.tabMainView.Margin = new System.Windows.Forms.Padding(0);
            this.tabMainView.Name = "tabMainView";
            this.tabMainView.Padding = new System.Drawing.Point(0, 0);
            this.tabMainView.SelectedIndex = 0;
            this.tabMainView.Size = new System.Drawing.Size(1186, 640);
            this.tabMainView.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMainView.TabIndex = 2;
            // 
            // pnlSettingsTab
            // 
            this.pnlSettingsTab.Controls.Add(this.pnlSettingsPanel);
            this.pnlSettingsTab.Location = new System.Drawing.Point(4, 5);
            this.pnlSettingsTab.Name = "pnlSettingsTab";
            this.pnlSettingsTab.Size = new System.Drawing.Size(1178, 631);
            this.pnlSettingsTab.TabIndex = 5;
            this.pnlSettingsTab.Text = "tabPage1";
            // 
            // pnlSettingsPanel
            // 
            this.pnlSettingsPanel.Controls.Add(this.btnScreenshotSettings);
            this.pnlSettingsPanel.Controls.Add(this.btnAlertSettings);
            this.pnlSettingsPanel.Controls.Add(this.btnTwitterTest);
            this.pnlSettingsPanel.Controls.Add(this.btnDiscordTest);
            this.pnlSettingsPanel.Controls.Add(this.btnDiscordSettings);
            this.pnlSettingsPanel.Controls.Add(this.btnTwitterSettings);
            this.pnlSettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettingsPanel.HorizontalScrollbarBarColor = true;
            this.pnlSettingsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlSettingsPanel.HorizontalScrollbarSize = 10;
            this.pnlSettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlSettingsPanel.Name = "pnlSettingsPanel";
            this.pnlSettingsPanel.Size = new System.Drawing.Size(1178, 631);
            this.pnlSettingsPanel.TabIndex = 0;
            this.pnlSettingsPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlSettingsPanel.VerticalScrollbarBarColor = true;
            this.pnlSettingsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.pnlSettingsPanel.VerticalScrollbarSize = 10;
            // 
            // btnScreenshotSettings
            // 
            this.btnScreenshotSettings.FlatAppearance.BorderSize = 0;
            this.btnScreenshotSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScreenshotSettings.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnScreenshotSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreenshotSettings.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.btnScreenshotSettings.IconColor = System.Drawing.Color.Black;
            this.btnScreenshotSettings.IconSize = 32;
            this.btnScreenshotSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScreenshotSettings.Location = new System.Drawing.Point(20, 63);
            this.btnScreenshotSettings.Name = "btnScreenshotSettings";
            this.btnScreenshotSettings.Rotation = 0D;
            this.btnScreenshotSettings.Size = new System.Drawing.Size(216, 37);
            this.btnScreenshotSettings.TabIndex = 8;
            this.btnScreenshotSettings.Text = "Screenshot Settings";
            this.btnScreenshotSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScreenshotSettings.Click += new System.EventHandler(this.btnScreenshotSettings_Click);
            // 
            // btnAlertSettings
            // 
            this.btnAlertSettings.FlatAppearance.BorderSize = 0;
            this.btnAlertSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlertSettings.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAlertSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlertSettings.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.btnAlertSettings.IconColor = System.Drawing.Color.Black;
            this.btnAlertSettings.IconSize = 32;
            this.btnAlertSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlertSettings.Location = new System.Drawing.Point(20, 20);
            this.btnAlertSettings.Name = "btnAlertSettings";
            this.btnAlertSettings.Rotation = 0D;
            this.btnAlertSettings.Size = new System.Drawing.Size(216, 37);
            this.btnAlertSettings.TabIndex = 7;
            this.btnAlertSettings.Text = "Alert Settings";
            this.btnAlertSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlertSettings.Click += new System.EventHandler(this.btnAlertSettings_Click);
            // 
            // btnTwitterTest
            // 
            this.btnTwitterTest.FlatAppearance.BorderSize = 0;
            this.btnTwitterTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwitterTest.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTwitterTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwitterTest.IconChar = FontAwesome.Sharp.IconChar.Vial;
            this.btnTwitterTest.IconColor = System.Drawing.Color.Black;
            this.btnTwitterTest.IconSize = 32;
            this.btnTwitterTest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTwitterTest.Location = new System.Drawing.Point(241, 150);
            this.btnTwitterTest.Name = "btnTwitterTest";
            this.btnTwitterTest.Rotation = 0D;
            this.btnTwitterTest.Size = new System.Drawing.Size(152, 37);
            this.btnTwitterTest.TabIndex = 4;
            this.btnTwitterTest.Text = "Twitter Test";
            this.btnTwitterTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTwitterTest.Click += new System.EventHandler(this.btnTwitterTest_Click);
            // 
            // btnDiscordTest
            // 
            this.btnDiscordTest.FlatAppearance.BorderSize = 0;
            this.btnDiscordTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscordTest.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDiscordTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscordTest.IconChar = FontAwesome.Sharp.IconChar.Vial;
            this.btnDiscordTest.IconColor = System.Drawing.Color.Black;
            this.btnDiscordTest.IconSize = 32;
            this.btnDiscordTest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiscordTest.Location = new System.Drawing.Point(241, 107);
            this.btnDiscordTest.Name = "btnDiscordTest";
            this.btnDiscordTest.Rotation = 0D;
            this.btnDiscordTest.Size = new System.Drawing.Size(152, 37);
            this.btnDiscordTest.TabIndex = 3;
            this.btnDiscordTest.Text = "Discord Test";
            this.btnDiscordTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscordTest.Click += new System.EventHandler(this.btnDiscordTest_Click);
            // 
            // btnDiscordSettings
            // 
            this.btnDiscordSettings.FlatAppearance.BorderSize = 0;
            this.btnDiscordSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscordSettings.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDiscordSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscordSettings.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.btnDiscordSettings.IconColor = System.Drawing.Color.Black;
            this.btnDiscordSettings.IconSize = 32;
            this.btnDiscordSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiscordSettings.Location = new System.Drawing.Point(19, 107);
            this.btnDiscordSettings.Name = "btnDiscordSettings";
            this.btnDiscordSettings.Rotation = 0D;
            this.btnDiscordSettings.Size = new System.Drawing.Size(216, 37);
            this.btnDiscordSettings.TabIndex = 5;
            this.btnDiscordSettings.Text = "Discord Settings";
            this.btnDiscordSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscordSettings.Click += new System.EventHandler(this.btnDiscordSettings_Click);
            // 
            // btnTwitterSettings
            // 
            this.btnTwitterSettings.FlatAppearance.BorderSize = 0;
            this.btnTwitterSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwitterSettings.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTwitterSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwitterSettings.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.btnTwitterSettings.IconColor = System.Drawing.Color.Black;
            this.btnTwitterSettings.IconSize = 32;
            this.btnTwitterSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTwitterSettings.Location = new System.Drawing.Point(19, 150);
            this.btnTwitterSettings.Name = "btnTwitterSettings";
            this.btnTwitterSettings.Rotation = 0D;
            this.btnTwitterSettings.Size = new System.Drawing.Size(216, 37);
            this.btnTwitterSettings.TabIndex = 6;
            this.btnTwitterSettings.Text = "Twitter Settings";
            this.btnTwitterSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTwitterSettings.Click += new System.EventHandler(this.btnTwitterSettings_Click);
            // 
            // pnlAboutTab
            // 
            this.pnlAboutTab.Controls.Add(this.metroPanel3);
            this.pnlAboutTab.Location = new System.Drawing.Point(4, 5);
            this.pnlAboutTab.Name = "pnlAboutTab";
            this.pnlAboutTab.Size = new System.Drawing.Size(1178, 631);
            this.pnlAboutTab.TabIndex = 9;
            this.pnlAboutTab.Text = "tabPage3";
            this.pnlAboutTab.UseVisualStyleBackColor = true;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.tabAbout);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(1178, 631);
            this.metroPanel3.TabIndex = 0;
            this.metroPanel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // tabAbout
            // 
            this.tabAbout.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabAbout.Controls.Add(this.pnlAboutInfoTab);
            this.tabAbout.Controls.Add(this.pnlAboutLogsTab);
            this.tabAbout.Controls.Add(this.pnlAboutDisclaimerTab);
            this.tabAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAbout.Location = new System.Drawing.Point(0, 0);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.SelectedIndex = 2;
            this.tabAbout.Size = new System.Drawing.Size(1178, 631);
            this.tabAbout.TabIndex = 2;
            this.tabAbout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabAbout.UseSelectable = true;
            // 
            // pnlAboutInfoTab
            // 
            this.pnlAboutInfoTab.Controls.Add(this.pnlAboutInfo);
            this.pnlAboutInfoTab.Location = new System.Drawing.Point(4, 41);
            this.pnlAboutInfoTab.Name = "pnlAboutInfoTab";
            this.pnlAboutInfoTab.Size = new System.Drawing.Size(1170, 586);
            this.pnlAboutInfoTab.TabIndex = 0;
            this.pnlAboutInfoTab.Text = "Info";
            // 
            // pnlAboutInfo
            // 
            this.pnlAboutInfo.Controls.Add(this.appInfo);
            this.pnlAboutInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAboutInfo.HorizontalScrollbarBarColor = true;
            this.pnlAboutInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAboutInfo.HorizontalScrollbarSize = 10;
            this.pnlAboutInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlAboutInfo.Name = "pnlAboutInfo";
            this.pnlAboutInfo.Size = new System.Drawing.Size(1170, 586);
            this.pnlAboutInfo.TabIndex = 0;
            this.pnlAboutInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlAboutInfo.VerticalScrollbarBarColor = true;
            this.pnlAboutInfo.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAboutInfo.VerticalScrollbarSize = 10;
            // 
            // appInfo
            // 
            this.appInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appInfo.Location = new System.Drawing.Point(0, 0);
            this.appInfo.Name = "appInfo";
            this.appInfo.Size = new System.Drawing.Size(1170, 586);
            this.appInfo.TabIndex = 2;
            // 
            // pnlAboutLogsTab
            // 
            this.pnlAboutLogsTab.Controls.Add(this.pnlAboutLogs);
            this.pnlAboutLogsTab.Location = new System.Drawing.Point(4, 41);
            this.pnlAboutLogsTab.Name = "pnlAboutLogsTab";
            this.pnlAboutLogsTab.Size = new System.Drawing.Size(1170, 586);
            this.pnlAboutLogsTab.TabIndex = 2;
            this.pnlAboutLogsTab.Text = "Logs";
            // 
            // pnlAboutLogs
            // 
            this.pnlAboutLogs.Controls.Add(this.logs);
            this.pnlAboutLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAboutLogs.HorizontalScrollbarBarColor = true;
            this.pnlAboutLogs.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAboutLogs.HorizontalScrollbarSize = 10;
            this.pnlAboutLogs.Location = new System.Drawing.Point(0, 0);
            this.pnlAboutLogs.Name = "pnlAboutLogs";
            this.pnlAboutLogs.Size = new System.Drawing.Size(1170, 586);
            this.pnlAboutLogs.TabIndex = 0;
            this.pnlAboutLogs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlAboutLogs.VerticalScrollbarBarColor = true;
            this.pnlAboutLogs.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAboutLogs.VerticalScrollbarSize = 10;
            // 
            // logs
            // 
            this.logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logs.Location = new System.Drawing.Point(0, 0);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(1170, 586);
            this.logs.TabIndex = 2;
            // 
            // pnlAboutDisclaimerTab
            // 
            this.pnlAboutDisclaimerTab.Controls.Add(this.pnlAboutDisclaimer);
            this.pnlAboutDisclaimerTab.Location = new System.Drawing.Point(4, 41);
            this.pnlAboutDisclaimerTab.Name = "pnlAboutDisclaimerTab";
            this.pnlAboutDisclaimerTab.Size = new System.Drawing.Size(1170, 586);
            this.pnlAboutDisclaimerTab.TabIndex = 1;
            this.pnlAboutDisclaimerTab.Text = "Disclaimer";
            // 
            // pnlAboutDisclaimer
            // 
            this.pnlAboutDisclaimer.Controls.Add(this.disclaimer1);
            this.pnlAboutDisclaimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAboutDisclaimer.HorizontalScrollbarBarColor = true;
            this.pnlAboutDisclaimer.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAboutDisclaimer.HorizontalScrollbarSize = 10;
            this.pnlAboutDisclaimer.Location = new System.Drawing.Point(0, 0);
            this.pnlAboutDisclaimer.Name = "pnlAboutDisclaimer";
            this.pnlAboutDisclaimer.Size = new System.Drawing.Size(1170, 586);
            this.pnlAboutDisclaimer.TabIndex = 0;
            this.pnlAboutDisclaimer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlAboutDisclaimer.VerticalScrollbarBarColor = true;
            this.pnlAboutDisclaimer.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAboutDisclaimer.VerticalScrollbarSize = 10;
            // 
            // disclaimer1
            // 
            this.disclaimer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disclaimer1.Location = new System.Drawing.Point(0, 0);
            this.disclaimer1.Name = "disclaimer1";
            this.disclaimer1.Size = new System.Drawing.Size(1170, 586);
            this.disclaimer1.TabIndex = 2;
            // 
            // pnlContributeTab
            // 
            this.pnlContributeTab.Controls.Add(this.pnlContributeBrowser);
            this.pnlContributeTab.Location = new System.Drawing.Point(4, 5);
            this.pnlContributeTab.Name = "pnlContributeTab";
            this.pnlContributeTab.Size = new System.Drawing.Size(1178, 631);
            this.pnlContributeTab.TabIndex = 7;
            this.pnlContributeTab.Text = "tabPage2";
            // 
            // pnlContributeBrowser
            // 
            this.pnlContributeBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContributeBrowser.HorizontalScrollbarBarColor = true;
            this.pnlContributeBrowser.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlContributeBrowser.HorizontalScrollbarSize = 10;
            this.pnlContributeBrowser.Location = new System.Drawing.Point(0, 0);
            this.pnlContributeBrowser.Name = "pnlContributeBrowser";
            this.pnlContributeBrowser.Size = new System.Drawing.Size(1178, 631);
            this.pnlContributeBrowser.TabIndex = 0;
            this.pnlContributeBrowser.VerticalScrollbarBarColor = true;
            this.pnlContributeBrowser.VerticalScrollbarHighlightOnWheel = false;
            this.pnlContributeBrowser.VerticalScrollbarSize = 10;
            // 
            // pnlAlertsTab
            // 
            this.pnlAlertsTab.BackColor = System.Drawing.Color.Transparent;
            this.pnlAlertsTab.Controls.Add(this.btnAlertsReset);
            this.pnlAlertsTab.Controls.Add(this.grdAlerts);
            this.pnlAlertsTab.Location = new System.Drawing.Point(4, 5);
            this.pnlAlertsTab.Name = "pnlAlertsTab";
            this.pnlAlertsTab.Size = new System.Drawing.Size(1178, 631);
            this.pnlAlertsTab.TabIndex = 1;
            this.pnlAlertsTab.Text = "Alerts";
            // 
            // btnAlertsReset
            // 
            this.btnAlertsReset.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAlertsReset.FlatAppearance.BorderSize = 0;
            this.btnAlertsReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlertsReset.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAlertsReset.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnAlertsReset.IconColor = System.Drawing.Color.Black;
            this.btnAlertsReset.IconSize = 32;
            this.btnAlertsReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlertsReset.Location = new System.Drawing.Point(0, 0);
            this.btnAlertsReset.Name = "btnAlertsReset";
            this.btnAlertsReset.Rotation = 0D;
            this.btnAlertsReset.Size = new System.Drawing.Size(84, 53);
            this.btnAlertsReset.TabIndex = 1;
            this.btnAlertsReset.Text = "Clear";
            this.btnAlertsReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlertsReset.UseVisualStyleBackColor = true;
            this.btnAlertsReset.Click += new System.EventHandler(this.btnAlertsReset_Click);
            // 
            // grdAlerts
            // 
            this.grdAlerts.AllowUserToResizeRows = false;
            this.grdAlerts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdAlerts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdAlerts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdAlerts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAlerts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdAlerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAlerts.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdAlerts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdAlerts.EnableHeadersVisualStyles = false;
            this.grdAlerts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdAlerts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdAlerts.Location = new System.Drawing.Point(0, 53);
            this.grdAlerts.Name = "grdAlerts";
            this.grdAlerts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAlerts.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdAlerts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdAlerts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAlerts.Size = new System.Drawing.Size(1178, 578);
            this.grdAlerts.TabIndex = 0;
            // 
            // pnlShopTab
            // 
            this.pnlShopTab.Controls.Add(this.pnlShopBrowser);
            this.pnlShopTab.Location = new System.Drawing.Point(4, 5);
            this.pnlShopTab.Name = "pnlShopTab";
            this.pnlShopTab.Size = new System.Drawing.Size(1178, 631);
            this.pnlShopTab.TabIndex = 6;
            this.pnlShopTab.Text = "tabPage1";
            // 
            // pnlShopBrowser
            // 
            this.pnlShopBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShopBrowser.HorizontalScrollbarBarColor = true;
            this.pnlShopBrowser.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlShopBrowser.HorizontalScrollbarSize = 10;
            this.pnlShopBrowser.Location = new System.Drawing.Point(0, 0);
            this.pnlShopBrowser.Name = "pnlShopBrowser";
            this.pnlShopBrowser.Size = new System.Drawing.Size(1178, 631);
            this.pnlShopBrowser.TabIndex = 0;
            this.pnlShopBrowser.VerticalScrollbarBarColor = true;
            this.pnlShopBrowser.VerticalScrollbarHighlightOnWheel = false;
            this.pnlShopBrowser.VerticalScrollbarSize = 10;
            // 
            // pnlVideoTab
            // 
            this.pnlVideoTab.BackColor = System.Drawing.Color.Transparent;
            this.pnlVideoTab.Controls.Add(this.btnIndicatorsExplainedPlaylist);
            this.pnlVideoTab.Controls.Add(this.btnPineScriptTutorialPlaylist);
            this.pnlVideoTab.Controls.Add(this.pnlVideoBrowser);
            this.pnlVideoTab.Location = new System.Drawing.Point(4, 5);
            this.pnlVideoTab.Name = "pnlVideoTab";
            this.pnlVideoTab.Size = new System.Drawing.Size(1178, 631);
            this.pnlVideoTab.TabIndex = 2;
            this.pnlVideoTab.Text = "Pine Tutorials";
            // 
            // btnIndicatorsExplainedPlaylist
            // 
            this.btnIndicatorsExplainedPlaylist.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIndicatorsExplainedPlaylist.FlatAppearance.BorderSize = 0;
            this.btnIndicatorsExplainedPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndicatorsExplainedPlaylist.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnIndicatorsExplainedPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndicatorsExplainedPlaylist.IconChar = FontAwesome.Sharp.IconChar.Youtube;
            this.btnIndicatorsExplainedPlaylist.IconColor = System.Drawing.Color.Black;
            this.btnIndicatorsExplainedPlaylist.IconSize = 32;
            this.btnIndicatorsExplainedPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIndicatorsExplainedPlaylist.Location = new System.Drawing.Point(202, 0);
            this.btnIndicatorsExplainedPlaylist.Name = "btnIndicatorsExplainedPlaylist";
            this.btnIndicatorsExplainedPlaylist.Rotation = 0D;
            this.btnIndicatorsExplainedPlaylist.Size = new System.Drawing.Size(202, 31);
            this.btnIndicatorsExplainedPlaylist.TabIndex = 2;
            this.btnIndicatorsExplainedPlaylist.Text = "Indicators Explained";
            this.btnIndicatorsExplainedPlaylist.UseVisualStyleBackColor = true;
            // 
            // btnPineScriptTutorialPlaylist
            // 
            this.btnPineScriptTutorialPlaylist.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPineScriptTutorialPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPineScriptTutorialPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPineScriptTutorialPlaylist.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPineScriptTutorialPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPineScriptTutorialPlaylist.IconChar = FontAwesome.Sharp.IconChar.Youtube;
            this.btnPineScriptTutorialPlaylist.IconColor = System.Drawing.Color.Black;
            this.btnPineScriptTutorialPlaylist.IconSize = 32;
            this.btnPineScriptTutorialPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPineScriptTutorialPlaylist.Location = new System.Drawing.Point(0, 0);
            this.btnPineScriptTutorialPlaylist.Name = "btnPineScriptTutorialPlaylist";
            this.btnPineScriptTutorialPlaylist.Rotation = 0D;
            this.btnPineScriptTutorialPlaylist.Size = new System.Drawing.Size(202, 31);
            this.btnPineScriptTutorialPlaylist.TabIndex = 1;
            this.btnPineScriptTutorialPlaylist.Text = "Pine Script Tutorials";
            this.btnPineScriptTutorialPlaylist.UseVisualStyleBackColor = true;
            // 
            // pnlVideoBrowser
            // 
            this.pnlVideoBrowser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlVideoBrowser.HorizontalScrollbarBarColor = true;
            this.pnlVideoBrowser.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlVideoBrowser.HorizontalScrollbarSize = 10;
            this.pnlVideoBrowser.Location = new System.Drawing.Point(0, 31);
            this.pnlVideoBrowser.Name = "pnlVideoBrowser";
            this.pnlVideoBrowser.Size = new System.Drawing.Size(1178, 600);
            this.pnlVideoBrowser.TabIndex = 0;
            this.pnlVideoBrowser.VerticalScrollbarBarColor = true;
            this.pnlVideoBrowser.VerticalScrollbarHighlightOnWheel = false;
            this.pnlVideoBrowser.VerticalScrollbarSize = 10;
            // 
            // pnlAlertScanTab
            // 
            this.pnlAlertScanTab.Location = new System.Drawing.Point(4, 5);
            this.pnlAlertScanTab.Name = "pnlAlertScanTab";
            this.pnlAlertScanTab.Size = new System.Drawing.Size(1178, 631);
            this.pnlAlertScanTab.TabIndex = 8;
            this.pnlAlertScanTab.Text = "tabPage3";
            this.pnlAlertScanTab.UseVisualStyleBackColor = true;
            // 
            // btnFocus
            // 
            this.btnFocus.Location = new System.Drawing.Point(4, 687);
            this.btnFocus.Name = "btnFocus";
            this.btnFocus.Size = new System.Drawing.Size(10, 10);
            this.btnFocus.TabIndex = 9;
            this.btnFocus.UseSelectable = true;
            this.btnFocus.Visible = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1178, 631);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblApplicationNameAndVersion
            // 
            this.lblApplicationNameAndVersion.AutoSize = true;
            this.lblApplicationNameAndVersion.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblApplicationNameAndVersion.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblApplicationNameAndVersion.ForeColor = System.Drawing.Color.White;
            this.lblApplicationNameAndVersion.Location = new System.Drawing.Point(74, 21);
            this.lblApplicationNameAndVersion.Name = "lblApplicationNameAndVersion";
            this.lblApplicationNameAndVersion.Size = new System.Drawing.Size(249, 25);
            this.lblApplicationNameAndVersion.TabIndex = 10;
            this.lblApplicationNameAndVersion.Text = "Trade Alert Responder 1.0.0";
            this.lblApplicationNameAndVersion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblApplicationNameAndVersion.UseCustomForeColor = true;
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(21, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(45, 45);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 8;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // StyleManager
            // 
            this.StyleManager.Owner = null;
            this.StyleManager.Style = MetroFramework.MetroColorStyle.White;
            this.StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblUpdate
            // 
            this.lblUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUpdate.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblUpdate.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUpdate.ForeColor = System.Drawing.Color.Yellow;
            this.lblUpdate.Location = new System.Drawing.Point(1098, 703);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(162, 15);
            this.lblUpdate.TabIndex = 11;
            this.lblUpdate.Text = "New version x.x.x available!";
            this.lblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblUpdate.UseCustomForeColor = true;
            this.lblUpdate.Click += new System.EventHandler(this.lblUpdate_Click);
            this.lblUpdate.MouseEnter += new System.EventHandler(this.lblUpdate_MouseEnter);
            this.lblUpdate.MouseLeave += new System.EventHandler(this.lblUpdate_MouseLeave);
            // 
            // currentLogMessage1
            // 
            this.currentLogMessage1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentLogMessage1.Location = new System.Drawing.Point(69, 701);
            this.currentLogMessage1.Name = "currentLogMessage1";
            this.currentLogMessage1.Size = new System.Drawing.Size(446, 21);
            this.currentLogMessage1.TabIndex = 12;
            // 
            // MainNew
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::TradeAlertResponder.Properties.Resources.BigBits;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.currentLogMessage1);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.lblApplicationNameAndVersion);
            this.Controls.Add(this.btnFocus);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlNavigation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainNew";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.tabMainView.ResumeLayout(false);
            this.pnlSettingsTab.ResumeLayout(false);
            this.pnlSettingsPanel.ResumeLayout(false);
            this.pnlAboutTab.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.tabAbout.ResumeLayout(false);
            this.pnlAboutInfoTab.ResumeLayout(false);
            this.pnlAboutInfo.ResumeLayout(false);
            this.pnlAboutLogsTab.ResumeLayout(false);
            this.pnlAboutLogs.ResumeLayout(false);
            this.pnlAboutDisclaimerTab.ResumeLayout(false);
            this.pnlAboutDisclaimer.ResumeLayout(false);
            this.pnlContributeTab.ResumeLayout(false);
            this.pnlAlertsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAlerts)).EndInit();
            this.pnlShopTab.ResumeLayout(false);
            this.pnlVideoTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid grdOrders;
        private MetroFramework.Controls.MetroPanel pnlNavigation;
        private MetroFramework.Controls.MetroPanel pnlContent;
        private System.Windows.Forms.PictureBox picLogo;
        private FontAwesome.Sharp.IconButton btnShopTab;
        private FontAwesome.Sharp.IconButton btnContributeTab;
        private FontAwesome.Sharp.IconButton btnVideoTab;
        private FontAwesome.Sharp.IconButton btnSettingsTab;
        private FontAwesome.Sharp.IconButton btnAlertsTab;
        private FontAwesome.Sharp.IconButton btnTradingViewTab;
        private MetroFramework.Controls.MetroButton btnFocus;
        private System.Windows.Forms.TabControl tabMainView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.TabPage pnlAlertsTab;
        private FontAwesome.Sharp.IconButton btnAlertsReset;
        private MetroFramework.Controls.MetroGrid grdAlerts;
        private System.Windows.Forms.TabPage pnlSettingsTab;
        private MetroFramework.Controls.MetroPanel pnlSettingsPanel;
        private FontAwesome.Sharp.IconButton btnScreenshotSettings;
        private FontAwesome.Sharp.IconButton btnAlertSettings;
        private FontAwesome.Sharp.IconButton btnTwitterTest;
        private FontAwesome.Sharp.IconButton btnDiscordTest;
        private FontAwesome.Sharp.IconButton btnDiscordSettings;
        private FontAwesome.Sharp.IconButton btnTwitterSettings;
        private System.Windows.Forms.TabPage pnlContributeTab;
        private MetroFramework.Controls.MetroPanel pnlContributeBrowser;
        private System.Windows.Forms.TabPage pnlShopTab;
        private MetroFramework.Controls.MetroPanel pnlShopBrowser;
        private System.Windows.Forms.TabPage pnlVideoTab;
        private FontAwesome.Sharp.IconButton btnIndicatorsExplainedPlaylist;
        private FontAwesome.Sharp.IconButton btnPineScriptTutorialPlaylist;
        private MetroFramework.Controls.MetroPanel pnlVideoBrowser;
        private MetroFramework.Controls.MetroLabel lblApplicationNameAndVersion;
        private System.Windows.Forms.NotifyIcon Notification;
        private System.Windows.Forms.TabPage pnlAlertScanTab;
        private MetroFramework.Components.MetroStyleManager StyleManager;
        private MetroFramework.Controls.MetroLabel lblUpdate;
        private CurrentLogMessage currentLogMessage1;
        private FontAwesome.Sharp.IconButton btnAboutTab;
        private System.Windows.Forms.TabPage pnlAboutTab;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroTabControl tabAbout;
        private System.Windows.Forms.TabPage pnlAboutInfoTab;
        private MetroFramework.Controls.MetroPanel pnlAboutInfo;
        private System.Windows.Forms.TabPage pnlAboutDisclaimerTab;
        private MetroFramework.Controls.MetroPanel pnlAboutDisclaimer;
        private System.Windows.Forms.TabPage pnlAboutLogsTab;
        private MetroFramework.Controls.MetroPanel pnlAboutLogs;
        private Logs logs;
        private AppInfo appInfo;
        private Disclaimer disclaimer1;
    }
}

