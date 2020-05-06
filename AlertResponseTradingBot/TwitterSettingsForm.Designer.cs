namespace TradeAlertResponder
{
    partial class TwitterSettingsForm
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
            this.tglValuesVerified = new MetroFramework.Controls.MetroToggle();
            this.lblValuesVerified = new MetroFramework.Controls.MetroLabel();
            this.tglAccessToken = new MetroFramework.Controls.MetroToggle();
            this.txtAccessToken = new MetroFramework.Controls.MetroTextBox();
            this.lblAccessToken = new MetroFramework.Controls.MetroLabel();
            this.tglConsumerSecret = new MetroFramework.Controls.MetroToggle();
            this.tglConsumerKey = new MetroFramework.Controls.MetroToggle();
            this.lblResult = new MetroFramework.Controls.MetroLabel();
            this.btnValidateAndSave = new MetroFramework.Controls.MetroButton();
            this.txtConsumerSecret = new MetroFramework.Controls.MetroTextBox();
            this.lblConsumerSecret = new MetroFramework.Controls.MetroLabel();
            this.txtConsumerKey = new MetroFramework.Controls.MetroTextBox();
            this.lblConsumerKey = new MetroFramework.Controls.MetroLabel();
            this.txtAccessTokenSecret = new MetroFramework.Controls.MetroTextBox();
            this.lblAccessTokenSecret = new MetroFramework.Controls.MetroLabel();
            this.tglAccessTokenSecret = new MetroFramework.Controls.MetroToggle();
            this.tglEnabled = new MetroFramework.Controls.MetroToggle();
            this.lblEnabled = new MetroFramework.Controls.MetroLabel();
            this.tglScreenshotsInAlerts = new MetroFramework.Controls.MetroToggle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tglValuesVerified
            // 
            this.tglValuesVerified.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglValuesVerified.AutoSize = true;
            this.tglValuesVerified.DisplayStatus = false;
            this.tglValuesVerified.Location = new System.Drawing.Point(196, 267);
            this.tglValuesVerified.Name = "tglValuesVerified";
            this.tglValuesVerified.Size = new System.Drawing.Size(50, 23);
            this.tglValuesVerified.TabIndex = 27;
            this.tglValuesVerified.Text = "Off";
            this.tglValuesVerified.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglValuesVerified.UseSelectable = true;
            // 
            // lblValuesVerified
            // 
            this.lblValuesVerified.AutoSize = true;
            this.lblValuesVerified.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblValuesVerified.Location = new System.Drawing.Point(23, 267);
            this.lblValuesVerified.Name = "lblValuesVerified";
            this.lblValuesVerified.Size = new System.Drawing.Size(167, 19);
            this.lblValuesVerified.TabIndex = 26;
            this.lblValuesVerified.Text = "Values Verified By User:";
            // 
            // tglAccessToken
            // 
            this.tglAccessToken.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglAccessToken.AutoSize = true;
            this.tglAccessToken.Checked = true;
            this.tglAccessToken.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tglAccessToken.DisplayStatus = false;
            this.tglAccessToken.Location = new System.Drawing.Point(586, 182);
            this.tglAccessToken.Name = "tglAccessToken";
            this.tglAccessToken.Size = new System.Drawing.Size(50, 23);
            this.tglAccessToken.TabIndex = 25;
            this.tglAccessToken.Text = "On";
            this.tglAccessToken.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglAccessToken.UseSelectable = true;
            this.tglAccessToken.CheckedChanged += new System.EventHandler(this.tglAccessToken_CheckedChanged);
            // 
            // txtAccessToken
            // 
            // 
            // 
            // 
            this.txtAccessToken.CustomButton.Image = null;
            this.txtAccessToken.CustomButton.Location = new System.Drawing.Point(530, 1);
            this.txtAccessToken.CustomButton.Name = "";
            this.txtAccessToken.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAccessToken.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccessToken.CustomButton.TabIndex = 1;
            this.txtAccessToken.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccessToken.CustomButton.UseSelectable = true;
            this.txtAccessToken.CustomButton.Visible = false;
            this.txtAccessToken.Lines = new string[0];
            this.txtAccessToken.Location = new System.Drawing.Point(28, 182);
            this.txtAccessToken.MaxLength = 32767;
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.PasswordChar = '*';
            this.txtAccessToken.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccessToken.SelectedText = "";
            this.txtAccessToken.SelectionLength = 0;
            this.txtAccessToken.SelectionStart = 0;
            this.txtAccessToken.ShortcutsEnabled = true;
            this.txtAccessToken.Size = new System.Drawing.Size(552, 23);
            this.txtAccessToken.TabIndex = 24;
            this.txtAccessToken.UseSelectable = true;
            this.txtAccessToken.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccessToken.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblAccessToken
            // 
            this.lblAccessToken.AutoSize = true;
            this.lblAccessToken.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAccessToken.Location = new System.Drawing.Point(23, 159);
            this.lblAccessToken.Name = "lblAccessToken";
            this.lblAccessToken.Size = new System.Drawing.Size(101, 19);
            this.lblAccessToken.TabIndex = 23;
            this.lblAccessToken.Text = "Access Token:";
            // 
            // tglConsumerSecret
            // 
            this.tglConsumerSecret.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglConsumerSecret.AutoSize = true;
            this.tglConsumerSecret.Checked = true;
            this.tglConsumerSecret.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tglConsumerSecret.DisplayStatus = false;
            this.tglConsumerSecret.Location = new System.Drawing.Point(586, 133);
            this.tglConsumerSecret.Name = "tglConsumerSecret";
            this.tglConsumerSecret.Size = new System.Drawing.Size(50, 23);
            this.tglConsumerSecret.TabIndex = 22;
            this.tglConsumerSecret.Text = "On";
            this.tglConsumerSecret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglConsumerSecret.UseSelectable = true;
            this.tglConsumerSecret.CheckedChanged += new System.EventHandler(this.tglConsumerSecret_CheckedChanged);
            // 
            // tglConsumerKey
            // 
            this.tglConsumerKey.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglConsumerKey.AutoSize = true;
            this.tglConsumerKey.Checked = true;
            this.tglConsumerKey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tglConsumerKey.DisplayStatus = false;
            this.tglConsumerKey.Location = new System.Drawing.Point(586, 83);
            this.tglConsumerKey.Name = "tglConsumerKey";
            this.tglConsumerKey.Size = new System.Drawing.Size(50, 23);
            this.tglConsumerKey.TabIndex = 21;
            this.tglConsumerKey.Text = "On";
            this.tglConsumerKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglConsumerKey.UseSelectable = true;
            this.tglConsumerKey.CheckedChanged += new System.EventHandler(this.tglConsumerKey_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(109, 350);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 0);
            this.lblResult.TabIndex = 20;
            // 
            // btnValidateAndSave
            // 
            this.btnValidateAndSave.Location = new System.Drawing.Point(28, 345);
            this.btnValidateAndSave.Name = "btnValidateAndSave";
            this.btnValidateAndSave.Size = new System.Drawing.Size(75, 23);
            this.btnValidateAndSave.TabIndex = 19;
            this.btnValidateAndSave.Text = "Save";
            this.btnValidateAndSave.UseSelectable = true;
            this.btnValidateAndSave.Click += new System.EventHandler(this.btnValidateAndSave_Click_1);
            // 
            // txtConsumerSecret
            // 
            // 
            // 
            // 
            this.txtConsumerSecret.CustomButton.Image = null;
            this.txtConsumerSecret.CustomButton.Location = new System.Drawing.Point(530, 1);
            this.txtConsumerSecret.CustomButton.Name = "";
            this.txtConsumerSecret.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConsumerSecret.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsumerSecret.CustomButton.TabIndex = 1;
            this.txtConsumerSecret.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsumerSecret.CustomButton.UseSelectable = true;
            this.txtConsumerSecret.CustomButton.Visible = false;
            this.txtConsumerSecret.Lines = new string[0];
            this.txtConsumerSecret.Location = new System.Drawing.Point(28, 133);
            this.txtConsumerSecret.MaxLength = 32767;
            this.txtConsumerSecret.Name = "txtConsumerSecret";
            this.txtConsumerSecret.PasswordChar = '*';
            this.txtConsumerSecret.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsumerSecret.SelectedText = "";
            this.txtConsumerSecret.SelectionLength = 0;
            this.txtConsumerSecret.SelectionStart = 0;
            this.txtConsumerSecret.ShortcutsEnabled = true;
            this.txtConsumerSecret.Size = new System.Drawing.Size(552, 23);
            this.txtConsumerSecret.TabIndex = 18;
            this.txtConsumerSecret.UseSelectable = true;
            this.txtConsumerSecret.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsumerSecret.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblConsumerSecret
            // 
            this.lblConsumerSecret.AutoSize = true;
            this.lblConsumerSecret.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblConsumerSecret.Location = new System.Drawing.Point(23, 110);
            this.lblConsumerSecret.Name = "lblConsumerSecret";
            this.lblConsumerSecret.Size = new System.Drawing.Size(126, 19);
            this.lblConsumerSecret.TabIndex = 17;
            this.lblConsumerSecret.Text = "Consumer Secret:";
            // 
            // txtConsumerKey
            // 
            // 
            // 
            // 
            this.txtConsumerKey.CustomButton.Image = null;
            this.txtConsumerKey.CustomButton.Location = new System.Drawing.Point(530, 1);
            this.txtConsumerKey.CustomButton.Name = "";
            this.txtConsumerKey.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConsumerKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsumerKey.CustomButton.TabIndex = 1;
            this.txtConsumerKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsumerKey.CustomButton.UseSelectable = true;
            this.txtConsumerKey.CustomButton.Visible = false;
            this.txtConsumerKey.Lines = new string[0];
            this.txtConsumerKey.Location = new System.Drawing.Point(28, 83);
            this.txtConsumerKey.MaxLength = 32767;
            this.txtConsumerKey.Name = "txtConsumerKey";
            this.txtConsumerKey.PasswordChar = '*';
            this.txtConsumerKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsumerKey.SelectedText = "";
            this.txtConsumerKey.SelectionLength = 0;
            this.txtConsumerKey.SelectionStart = 0;
            this.txtConsumerKey.ShortcutsEnabled = true;
            this.txtConsumerKey.Size = new System.Drawing.Size(552, 23);
            this.txtConsumerKey.TabIndex = 16;
            this.txtConsumerKey.UseSelectable = true;
            this.txtConsumerKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsumerKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblConsumerKey
            // 
            this.lblConsumerKey.AutoSize = true;
            this.lblConsumerKey.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblConsumerKey.Location = new System.Drawing.Point(23, 60);
            this.lblConsumerKey.Name = "lblConsumerKey";
            this.lblConsumerKey.Size = new System.Drawing.Size(109, 19);
            this.lblConsumerKey.TabIndex = 15;
            this.lblConsumerKey.Text = "Consumer Key:";
            // 
            // txtAccessTokenSecret
            // 
            // 
            // 
            // 
            this.txtAccessTokenSecret.CustomButton.Image = null;
            this.txtAccessTokenSecret.CustomButton.Location = new System.Drawing.Point(530, 1);
            this.txtAccessTokenSecret.CustomButton.Name = "";
            this.txtAccessTokenSecret.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAccessTokenSecret.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccessTokenSecret.CustomButton.TabIndex = 1;
            this.txtAccessTokenSecret.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccessTokenSecret.CustomButton.UseSelectable = true;
            this.txtAccessTokenSecret.CustomButton.Visible = false;
            this.txtAccessTokenSecret.Lines = new string[0];
            this.txtAccessTokenSecret.Location = new System.Drawing.Point(28, 232);
            this.txtAccessTokenSecret.MaxLength = 32767;
            this.txtAccessTokenSecret.Name = "txtAccessTokenSecret";
            this.txtAccessTokenSecret.PasswordChar = '*';
            this.txtAccessTokenSecret.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccessTokenSecret.SelectedText = "";
            this.txtAccessTokenSecret.SelectionLength = 0;
            this.txtAccessTokenSecret.SelectionStart = 0;
            this.txtAccessTokenSecret.ShortcutsEnabled = true;
            this.txtAccessTokenSecret.Size = new System.Drawing.Size(552, 23);
            this.txtAccessTokenSecret.TabIndex = 29;
            this.txtAccessTokenSecret.UseSelectable = true;
            this.txtAccessTokenSecret.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccessTokenSecret.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblAccessTokenSecret
            // 
            this.lblAccessTokenSecret.AutoSize = true;
            this.lblAccessTokenSecret.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAccessTokenSecret.Location = new System.Drawing.Point(23, 209);
            this.lblAccessTokenSecret.Name = "lblAccessTokenSecret";
            this.lblAccessTokenSecret.Size = new System.Drawing.Size(147, 19);
            this.lblAccessTokenSecret.TabIndex = 28;
            this.lblAccessTokenSecret.Text = "Access Token Secret:";
            // 
            // tglAccessTokenSecret
            // 
            this.tglAccessTokenSecret.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglAccessTokenSecret.AutoSize = true;
            this.tglAccessTokenSecret.Checked = true;
            this.tglAccessTokenSecret.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tglAccessTokenSecret.DisplayStatus = false;
            this.tglAccessTokenSecret.Location = new System.Drawing.Point(586, 232);
            this.tglAccessTokenSecret.Name = "tglAccessTokenSecret";
            this.tglAccessTokenSecret.Size = new System.Drawing.Size(50, 23);
            this.tglAccessTokenSecret.TabIndex = 30;
            this.tglAccessTokenSecret.Text = "On";
            this.tglAccessTokenSecret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglAccessTokenSecret.UseSelectable = true;
            this.tglAccessTokenSecret.CheckedChanged += new System.EventHandler(this.tglAccessTokenSecret_CheckedChanged);
            // 
            // tglEnabled
            // 
            this.tglEnabled.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglEnabled.AutoSize = true;
            this.tglEnabled.DisplayStatus = false;
            this.tglEnabled.Location = new System.Drawing.Point(95, 300);
            this.tglEnabled.Name = "tglEnabled";
            this.tglEnabled.Size = new System.Drawing.Size(50, 23);
            this.tglEnabled.TabIndex = 32;
            this.tglEnabled.Text = "Off";
            this.tglEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglEnabled.UseSelectable = true;
            // 
            // lblEnabled
            // 
            this.lblEnabled.AutoSize = true;
            this.lblEnabled.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblEnabled.Location = new System.Drawing.Point(23, 302);
            this.lblEnabled.Name = "lblEnabled";
            this.lblEnabled.Size = new System.Drawing.Size(66, 19);
            this.lblEnabled.TabIndex = 31;
            this.lblEnabled.Text = "Enabled:";
            // 
            // tglScreenshotsInAlerts
            // 
            this.tglScreenshotsInAlerts.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglScreenshotsInAlerts.AutoSize = true;
            this.tglScreenshotsInAlerts.DisplayStatus = false;
            this.tglScreenshotsInAlerts.Enabled = false;
            this.tglScreenshotsInAlerts.Location = new System.Drawing.Point(586, 267);
            this.tglScreenshotsInAlerts.Name = "tglScreenshotsInAlerts";
            this.tglScreenshotsInAlerts.Size = new System.Drawing.Size(50, 23);
            this.tglScreenshotsInAlerts.TabIndex = 35;
            this.tglScreenshotsInAlerts.Text = "Off";
            this.tglScreenshotsInAlerts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglScreenshotsInAlerts.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(429, 267);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(151, 19);
            this.metroLabel1.TabIndex = 34;
            this.metroLabel1.Text = "Screenshots In Alerts:";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.LaptopCode;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.Location = new System.Drawing.Point(399, 264);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 33;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Twitter;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconSize = 60;
            this.iconPictureBox2.Location = new System.Drawing.Point(190, 15);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(69, 60);
            this.iconPictureBox2.TabIndex = 36;
            this.iconPictureBox2.TabStop = false;
            // 
            // TwitterSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 394);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.tglScreenshotsInAlerts);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.tglEnabled);
            this.Controls.Add(this.lblEnabled);
            this.Controls.Add(this.tglAccessTokenSecret);
            this.Controls.Add(this.txtAccessTokenSecret);
            this.Controls.Add(this.lblAccessTokenSecret);
            this.Controls.Add(this.tglValuesVerified);
            this.Controls.Add(this.lblValuesVerified);
            this.Controls.Add(this.tglAccessToken);
            this.Controls.Add(this.txtAccessToken);
            this.Controls.Add(this.lblAccessToken);
            this.Controls.Add(this.tglConsumerSecret);
            this.Controls.Add(this.tglConsumerKey);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnValidateAndSave);
            this.Controls.Add(this.txtConsumerSecret);
            this.Controls.Add(this.lblConsumerSecret);
            this.Controls.Add(this.txtConsumerKey);
            this.Controls.Add(this.lblConsumerKey);
            this.Name = "TwitterSettingsForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Twitter Settings";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroToggle tglValuesVerified;
        private MetroFramework.Controls.MetroLabel lblValuesVerified;
        private MetroFramework.Controls.MetroToggle tglAccessToken;
        private MetroFramework.Controls.MetroTextBox txtAccessToken;
        private MetroFramework.Controls.MetroLabel lblAccessToken;
        private MetroFramework.Controls.MetroToggle tglConsumerSecret;
        private MetroFramework.Controls.MetroToggle tglConsumerKey;
        private MetroFramework.Controls.MetroLabel lblResult;
        private MetroFramework.Controls.MetroButton btnValidateAndSave;
        private MetroFramework.Controls.MetroTextBox txtConsumerSecret;
        private MetroFramework.Controls.MetroLabel lblConsumerSecret;
        private MetroFramework.Controls.MetroTextBox txtConsumerKey;
        private MetroFramework.Controls.MetroLabel lblConsumerKey;
        private MetroFramework.Controls.MetroTextBox txtAccessTokenSecret;
        private MetroFramework.Controls.MetroLabel lblAccessTokenSecret;
        private MetroFramework.Controls.MetroToggle tglAccessTokenSecret;
        private MetroFramework.Controls.MetroToggle tglEnabled;
        private MetroFramework.Controls.MetroLabel lblEnabled;
        private MetroFramework.Controls.MetroToggle tglScreenshotsInAlerts;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}