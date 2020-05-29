namespace TradeAlertResponder.Controls
{
    partial class AlertScanner
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBrowser = new MetroFramework.Controls.MetroPanel();
            this.pnlControls = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblPluginTextFriendlyName = new MetroFramework.Controls.MetroLabel();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.btnScanForAlerts = new FontAwesome.Sharp.IconButton();
            this.lblAuthor = new MetroFramework.Controls.MetroLabel();
            this.pnlControls.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBrowser
            // 
            this.pnlBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBrowser.HorizontalScrollbarBarColor = true;
            this.pnlBrowser.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlBrowser.HorizontalScrollbarSize = 10;
            this.pnlBrowser.Location = new System.Drawing.Point(0, 52);
            this.pnlBrowser.Name = "pnlBrowser";
            this.pnlBrowser.Size = new System.Drawing.Size(845, 483);
            this.pnlBrowser.TabIndex = 0;
            this.pnlBrowser.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlBrowser.VerticalScrollbarBarColor = true;
            this.pnlBrowser.VerticalScrollbarHighlightOnWheel = false;
            this.pnlBrowser.VerticalScrollbarSize = 10;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.metroPanel1);
            this.pnlControls.Controls.Add(this.btnHome);
            this.pnlControls.Controls.Add(this.btnScanForAlerts);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.HorizontalScrollbarBarColor = true;
            this.pnlControls.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlControls.HorizontalScrollbarSize = 10;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(845, 53);
            this.pnlControls.TabIndex = 1;
            this.pnlControls.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlControls.VerticalScrollbarBarColor = true;
            this.pnlControls.VerticalScrollbarHighlightOnWheel = false;
            this.pnlControls.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lblAuthor);
            this.metroPanel1.Controls.Add(this.lblPluginTextFriendlyName);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(128, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(717, 53);
            this.metroPanel1.TabIndex = 21;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblPluginTextFriendlyName
            // 
            this.lblPluginTextFriendlyName.AutoSize = true;
            this.lblPluginTextFriendlyName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPluginTextFriendlyName.Location = new System.Drawing.Point(26, 6);
            this.lblPluginTextFriendlyName.Name = "lblPluginTextFriendlyName";
            this.lblPluginTextFriendlyName.Size = new System.Drawing.Size(91, 19);
            this.lblPluginTextFriendlyName.TabIndex = 20;
            this.lblPluginTextFriendlyName.Text = "PluginName";
            this.lblPluginTextFriendlyName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconSize = 35;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(64, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10);
            this.btnHome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnHome.Rotation = 0D;
            this.btnHome.Size = new System.Drawing.Size(64, 53);
            this.btnHome.TabIndex = 19;
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnScanForAlerts
            // 
            this.btnScanForAlerts.BackColor = System.Drawing.Color.Transparent;
            this.btnScanForAlerts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScanForAlerts.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnScanForAlerts.FlatAppearance.BorderSize = 0;
            this.btnScanForAlerts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnScanForAlerts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnScanForAlerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanForAlerts.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnScanForAlerts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanForAlerts.ForeColor = System.Drawing.Color.White;
            this.btnScanForAlerts.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnScanForAlerts.IconColor = System.Drawing.Color.White;
            this.btnScanForAlerts.IconSize = 35;
            this.btnScanForAlerts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScanForAlerts.Location = new System.Drawing.Point(0, 0);
            this.btnScanForAlerts.Name = "btnScanForAlerts";
            this.btnScanForAlerts.Padding = new System.Windows.Forms.Padding(10);
            this.btnScanForAlerts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnScanForAlerts.Rotation = 0D;
            this.btnScanForAlerts.Size = new System.Drawing.Size(64, 53);
            this.btnScanForAlerts.TabIndex = 18;
            this.btnScanForAlerts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScanForAlerts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScanForAlerts.UseVisualStyleBackColor = false;
            this.btnScanForAlerts.Click += new System.EventHandler(this.btnScanForAlerts_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAuthor.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblAuthor.Location = new System.Drawing.Point(26, 25);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(49, 19);
            this.lblAuthor.TabIndex = 21;
            this.lblAuthor.Text = "Author";
            this.lblAuthor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAuthor.UseCustomForeColor = true;
            this.lblAuthor.Click += new System.EventHandler(this.lblAuthor_Click);
            // 
            // AlertScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBrowser);
            this.Controls.Add(this.pnlControls);
            this.Name = "AlertScanner";
            this.Size = new System.Drawing.Size(845, 535);
            this.pnlControls.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlBrowser;
        private MetroFramework.Controls.MetroPanel pnlControls;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnScanForAlerts;
        private MetroFramework.Controls.MetroLabel lblPluginTextFriendlyName;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblAuthor;
    }
}
