namespace TradeAlertResponder.Controls
{
    partial class AlertActionPlugin
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
            this.pnlBackground = new MetroFramework.Controls.MetroPanel();
            this.tglEnabled = new MetroFramework.Controls.MetroToggle();
            this.btnPluginSettings = new MetroFramework.Controls.MetroButton();
            this.lblPluginTextFriendlyName = new MetroFramework.Controls.MetroLabel();
            this.lblAuthor = new MetroFramework.Controls.MetroLabel();
            this.btnAbout = new FontAwesome.Sharp.IconButton();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.Controls.Add(this.btnAbout);
            this.pnlBackground.Controls.Add(this.lblAuthor);
            this.pnlBackground.Controls.Add(this.lblPluginTextFriendlyName);
            this.pnlBackground.Controls.Add(this.btnPluginSettings);
            this.pnlBackground.Controls.Add(this.tglEnabled);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.HorizontalScrollbarBarColor = true;
            this.pnlBackground.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlBackground.HorizontalScrollbarSize = 10;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(697, 62);
            this.pnlBackground.TabIndex = 0;
            this.pnlBackground.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlBackground.VerticalScrollbarBarColor = true;
            this.pnlBackground.VerticalScrollbarHighlightOnWheel = false;
            this.pnlBackground.VerticalScrollbarSize = 10;
            // 
            // tglEnabled
            // 
            this.tglEnabled.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglEnabled.AutoSize = true;
            this.tglEnabled.DisplayStatus = false;
            this.tglEnabled.Location = new System.Drawing.Point(259, 17);
            this.tglEnabled.Name = "tglEnabled";
            this.tglEnabled.Size = new System.Drawing.Size(50, 23);
            this.tglEnabled.TabIndex = 2;
            this.tglEnabled.Text = "Off";
            this.tglEnabled.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tglEnabled.UseSelectable = true;
            this.tglEnabled.CheckedChanged += new System.EventHandler(this.tglEnabled_CheckedChanged);
            // 
            // btnPluginSettings
            // 
            this.btnPluginSettings.Location = new System.Drawing.Point(13, 10);
            this.btnPluginSettings.Name = "btnPluginSettings";
            this.btnPluginSettings.Size = new System.Drawing.Size(231, 40);
            this.btnPluginSettings.TabIndex = 4;
            this.btnPluginSettings.Text = "Settings";
            this.btnPluginSettings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPluginSettings.UseSelectable = true;
            this.btnPluginSettings.Click += new System.EventHandler(this.btnPluginSettings_Click);
            // 
            // lblPluginTextFriendlyName
            // 
            this.lblPluginTextFriendlyName.AutoSize = true;
            this.lblPluginTextFriendlyName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPluginTextFriendlyName.Location = new System.Drawing.Point(323, 10);
            this.lblPluginTextFriendlyName.Name = "lblPluginTextFriendlyName";
            this.lblPluginTextFriendlyName.Size = new System.Drawing.Size(91, 19);
            this.lblPluginTextFriendlyName.TabIndex = 21;
            this.lblPluginTextFriendlyName.Text = "PluginName";
            this.lblPluginTextFriendlyName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAuthor.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblAuthor.Location = new System.Drawing.Point(323, 29);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(49, 19);
            this.lblAuthor.TabIndex = 22;
            this.lblAuthor.Text = "Author";
            this.lblAuthor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAuthor.UseCustomForeColor = true;
            this.lblAuthor.Click += new System.EventHandler(this.lblAuthor_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btnAbout.IconColor = System.Drawing.Color.White;
            this.btnAbout.IconSize = 35;
            this.btnAbout.Location = new System.Drawing.Point(633, 0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.btnAbout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAbout.Rotation = 0D;
            this.btnAbout.Size = new System.Drawing.Size(64, 62);
            this.btnAbout.TabIndex = 25;
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // AlertActionPlugin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBackground);
            this.Name = "AlertActionPlugin";
            this.Size = new System.Drawing.Size(697, 62);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlBackground;
        private MetroFramework.Controls.MetroButton btnPluginSettings;
        private MetroFramework.Controls.MetroToggle tglEnabled;
        private MetroFramework.Controls.MetroLabel lblPluginTextFriendlyName;
        private MetroFramework.Controls.MetroLabel lblAuthor;
        private FontAwesome.Sharp.IconButton btnAbout;
    }
}
