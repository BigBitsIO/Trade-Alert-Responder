namespace TradeAlertResponder
{
    partial class AlertSettingsForm
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
            this.btnValidateAndSave = new MetroFramework.Controls.MetroButton();
            this.lblResult = new MetroFramework.Controls.MetroLabel();
            this.tglNotificationOnAlert = new MetroFramework.Controls.MetroToggle();
            this.lblNotificationOnAlert = new MetroFramework.Controls.MetroLabel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.tglTweetOnAlert = new MetroFramework.Controls.MetroToggle();
            this.lblTweetOnAlert = new MetroFramework.Controls.MetroLabel();
            this.tglDiscordOnAlert = new MetroFramework.Controls.MetroToggle();
            this.lblDiscordOnAlert = new MetroFramework.Controls.MetroLabel();
            this.lblMyBotName = new MetroFramework.Controls.MetroLabel();
            this.lblMyBotStatus = new MetroFramework.Controls.MetroLabel();
            this.lblReferralsURL = new MetroFramework.Controls.MetroLabel();
            this.lblDisclaimerText = new MetroFramework.Controls.MetroLabel();
            this.txtMyBotName = new MetroFramework.Controls.MetroTextBox();
            this.txtMyBotStatus = new MetroFramework.Controls.MetroTextBox();
            this.txtReferralsURL = new MetroFramework.Controls.MetroTextBox();
            this.txtDisclaimerText = new MetroFramework.Controls.MetroTextBox();
            this.tglMemMapFile = new MetroFramework.Controls.MetroToggle();
            this.lblMemMapFile = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValidateAndSave
            // 
            this.btnValidateAndSave.Location = new System.Drawing.Point(98, 307);
            this.btnValidateAndSave.Name = "btnValidateAndSave";
            this.btnValidateAndSave.Size = new System.Drawing.Size(75, 23);
            this.btnValidateAndSave.TabIndex = 6;
            this.btnValidateAndSave.Text = "Save";
            this.btnValidateAndSave.UseSelectable = true;
            this.btnValidateAndSave.Click += new System.EventHandler(this.btnValidateAndSave_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(183, 311);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 0);
            this.lblResult.TabIndex = 7;
            // 
            // tglNotificationOnAlert
            // 
            this.tglNotificationOnAlert.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglNotificationOnAlert.AutoSize = true;
            this.tglNotificationOnAlert.DisplayStatus = false;
            this.tglNotificationOnAlert.Location = new System.Drawing.Point(179, 228);
            this.tglNotificationOnAlert.Name = "tglNotificationOnAlert";
            this.tglNotificationOnAlert.Size = new System.Drawing.Size(50, 23);
            this.tglNotificationOnAlert.TabIndex = 16;
            this.tglNotificationOnAlert.Text = "Off";
            this.tglNotificationOnAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglNotificationOnAlert.UseSelectable = true;
            // 
            // lblNotificationOnAlert
            // 
            this.lblNotificationOnAlert.AutoSize = true;
            this.lblNotificationOnAlert.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblNotificationOnAlert.Location = new System.Drawing.Point(23, 229);
            this.lblNotificationOnAlert.Name = "lblNotificationOnAlert";
            this.lblNotificationOnAlert.Size = new System.Drawing.Size(150, 19);
            this.lblNotificationOnAlert.TabIndex = 15;
            this.lblNotificationOnAlert.Text = "Notification on Alert:";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconSize = 60;
            this.iconPictureBox2.Location = new System.Drawing.Point(196, 15);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(69, 60);
            this.iconPictureBox2.TabIndex = 24;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // tglTweetOnAlert
            // 
            this.tglTweetOnAlert.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglTweetOnAlert.AutoSize = true;
            this.tglTweetOnAlert.DisplayStatus = false;
            this.tglTweetOnAlert.Location = new System.Drawing.Point(485, 228);
            this.tglTweetOnAlert.Name = "tglTweetOnAlert";
            this.tglTweetOnAlert.Size = new System.Drawing.Size(50, 23);
            this.tglTweetOnAlert.TabIndex = 26;
            this.tglTweetOnAlert.Text = "Off";
            this.tglTweetOnAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglTweetOnAlert.UseSelectable = true;
            // 
            // lblTweetOnAlert
            // 
            this.lblTweetOnAlert.AutoSize = true;
            this.lblTweetOnAlert.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTweetOnAlert.Location = new System.Drawing.Point(369, 229);
            this.lblTweetOnAlert.Name = "lblTweetOnAlert";
            this.lblTweetOnAlert.Size = new System.Drawing.Size(110, 19);
            this.lblTweetOnAlert.TabIndex = 25;
            this.lblTweetOnAlert.Text = "Tweet on Alert:";
            // 
            // tglDiscordOnAlert
            // 
            this.tglDiscordOnAlert.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglDiscordOnAlert.AutoSize = true;
            this.tglDiscordOnAlert.DisplayStatus = false;
            this.tglDiscordOnAlert.Location = new System.Drawing.Point(179, 264);
            this.tglDiscordOnAlert.Name = "tglDiscordOnAlert";
            this.tglDiscordOnAlert.Size = new System.Drawing.Size(50, 23);
            this.tglDiscordOnAlert.TabIndex = 28;
            this.tglDiscordOnAlert.Text = "Off";
            this.tglDiscordOnAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglDiscordOnAlert.UseSelectable = true;
            // 
            // lblDiscordOnAlert
            // 
            this.lblDiscordOnAlert.AutoSize = true;
            this.lblDiscordOnAlert.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDiscordOnAlert.Location = new System.Drawing.Point(51, 264);
            this.lblDiscordOnAlert.Name = "lblDiscordOnAlert";
            this.lblDiscordOnAlert.Size = new System.Drawing.Size(122, 19);
            this.lblDiscordOnAlert.TabIndex = 27;
            this.lblDiscordOnAlert.Text = "Discord on Alert:";
            // 
            // lblMyBotName
            // 
            this.lblMyBotName.AutoSize = true;
            this.lblMyBotName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblMyBotName.Location = new System.Drawing.Point(68, 87);
            this.lblMyBotName.Name = "lblMyBotName";
            this.lblMyBotName.Size = new System.Drawing.Size(105, 19);
            this.lblMyBotName.TabIndex = 29;
            this.lblMyBotName.Text = "My Bot Name:";
            // 
            // lblMyBotStatus
            // 
            this.lblMyBotStatus.AutoSize = true;
            this.lblMyBotStatus.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblMyBotStatus.Location = new System.Drawing.Point(68, 122);
            this.lblMyBotStatus.Name = "lblMyBotStatus";
            this.lblMyBotStatus.Size = new System.Drawing.Size(105, 19);
            this.lblMyBotStatus.TabIndex = 30;
            this.lblMyBotStatus.Text = "My Bot Status:";
            // 
            // lblReferralsURL
            // 
            this.lblReferralsURL.AutoSize = true;
            this.lblReferralsURL.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblReferralsURL.Location = new System.Drawing.Point(70, 156);
            this.lblReferralsURL.Name = "lblReferralsURL";
            this.lblReferralsURL.Size = new System.Drawing.Size(103, 19);
            this.lblReferralsURL.TabIndex = 31;
            this.lblReferralsURL.Text = "Referrals URL:";
            // 
            // lblDisclaimerText
            // 
            this.lblDisclaimerText.AutoSize = true;
            this.lblDisclaimerText.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDisclaimerText.Location = new System.Drawing.Point(58, 191);
            this.lblDisclaimerText.Name = "lblDisclaimerText";
            this.lblDisclaimerText.Size = new System.Drawing.Size(115, 19);
            this.lblDisclaimerText.TabIndex = 32;
            this.lblDisclaimerText.Text = "Disclaimer Text:";
            // 
            // txtMyBotName
            // 
            // 
            // 
            // 
            this.txtMyBotName.CustomButton.Image = null;
            this.txtMyBotName.CustomButton.Location = new System.Drawing.Point(336, 1);
            this.txtMyBotName.CustomButton.Name = "";
            this.txtMyBotName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMyBotName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMyBotName.CustomButton.TabIndex = 1;
            this.txtMyBotName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMyBotName.CustomButton.UseSelectable = true;
            this.txtMyBotName.CustomButton.Visible = false;
            this.txtMyBotName.Lines = new string[0];
            this.txtMyBotName.Location = new System.Drawing.Point(179, 87);
            this.txtMyBotName.MaxLength = 32767;
            this.txtMyBotName.Name = "txtMyBotName";
            this.txtMyBotName.PasswordChar = '\0';
            this.txtMyBotName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMyBotName.SelectedText = "";
            this.txtMyBotName.SelectionLength = 0;
            this.txtMyBotName.SelectionStart = 0;
            this.txtMyBotName.ShortcutsEnabled = true;
            this.txtMyBotName.Size = new System.Drawing.Size(358, 23);
            this.txtMyBotName.TabIndex = 33;
            this.txtMyBotName.UseSelectable = true;
            this.txtMyBotName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMyBotName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMyBotStatus
            // 
            // 
            // 
            // 
            this.txtMyBotStatus.CustomButton.Image = null;
            this.txtMyBotStatus.CustomButton.Location = new System.Drawing.Point(336, 1);
            this.txtMyBotStatus.CustomButton.Name = "";
            this.txtMyBotStatus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMyBotStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMyBotStatus.CustomButton.TabIndex = 1;
            this.txtMyBotStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMyBotStatus.CustomButton.UseSelectable = true;
            this.txtMyBotStatus.CustomButton.Visible = false;
            this.txtMyBotStatus.Lines = new string[0];
            this.txtMyBotStatus.Location = new System.Drawing.Point(179, 122);
            this.txtMyBotStatus.MaxLength = 32767;
            this.txtMyBotStatus.Name = "txtMyBotStatus";
            this.txtMyBotStatus.PasswordChar = '\0';
            this.txtMyBotStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMyBotStatus.SelectedText = "";
            this.txtMyBotStatus.SelectionLength = 0;
            this.txtMyBotStatus.SelectionStart = 0;
            this.txtMyBotStatus.ShortcutsEnabled = true;
            this.txtMyBotStatus.Size = new System.Drawing.Size(358, 23);
            this.txtMyBotStatus.TabIndex = 34;
            this.txtMyBotStatus.UseSelectable = true;
            this.txtMyBotStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMyBotStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtReferralsURL
            // 
            // 
            // 
            // 
            this.txtReferralsURL.CustomButton.Image = null;
            this.txtReferralsURL.CustomButton.Location = new System.Drawing.Point(336, 1);
            this.txtReferralsURL.CustomButton.Name = "";
            this.txtReferralsURL.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtReferralsURL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReferralsURL.CustomButton.TabIndex = 1;
            this.txtReferralsURL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReferralsURL.CustomButton.UseSelectable = true;
            this.txtReferralsURL.CustomButton.Visible = false;
            this.txtReferralsURL.Lines = new string[0];
            this.txtReferralsURL.Location = new System.Drawing.Point(179, 156);
            this.txtReferralsURL.MaxLength = 32767;
            this.txtReferralsURL.Name = "txtReferralsURL";
            this.txtReferralsURL.PasswordChar = '\0';
            this.txtReferralsURL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReferralsURL.SelectedText = "";
            this.txtReferralsURL.SelectionLength = 0;
            this.txtReferralsURL.SelectionStart = 0;
            this.txtReferralsURL.ShortcutsEnabled = true;
            this.txtReferralsURL.Size = new System.Drawing.Size(358, 23);
            this.txtReferralsURL.TabIndex = 35;
            this.txtReferralsURL.UseSelectable = true;
            this.txtReferralsURL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReferralsURL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDisclaimerText
            // 
            // 
            // 
            // 
            this.txtDisclaimerText.CustomButton.Image = null;
            this.txtDisclaimerText.CustomButton.Location = new System.Drawing.Point(336, 1);
            this.txtDisclaimerText.CustomButton.Name = "";
            this.txtDisclaimerText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDisclaimerText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDisclaimerText.CustomButton.TabIndex = 1;
            this.txtDisclaimerText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDisclaimerText.CustomButton.UseSelectable = true;
            this.txtDisclaimerText.CustomButton.Visible = false;
            this.txtDisclaimerText.Lines = new string[0];
            this.txtDisclaimerText.Location = new System.Drawing.Point(179, 191);
            this.txtDisclaimerText.MaxLength = 32767;
            this.txtDisclaimerText.Name = "txtDisclaimerText";
            this.txtDisclaimerText.PasswordChar = '\0';
            this.txtDisclaimerText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDisclaimerText.SelectedText = "";
            this.txtDisclaimerText.SelectionLength = 0;
            this.txtDisclaimerText.SelectionStart = 0;
            this.txtDisclaimerText.ShortcutsEnabled = true;
            this.txtDisclaimerText.Size = new System.Drawing.Size(358, 23);
            this.txtDisclaimerText.TabIndex = 36;
            this.txtDisclaimerText.UseSelectable = true;
            this.txtDisclaimerText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDisclaimerText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tglMemMapFile
            // 
            this.tglMemMapFile.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglMemMapFile.AutoSize = true;
            this.tglMemMapFile.DisplayStatus = false;
            this.tglMemMapFile.Location = new System.Drawing.Point(485, 260);
            this.tglMemMapFile.Name = "tglMemMapFile";
            this.tglMemMapFile.Size = new System.Drawing.Size(50, 23);
            this.tglMemMapFile.TabIndex = 38;
            this.tglMemMapFile.Text = "Off";
            this.tglMemMapFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglMemMapFile.UseSelectable = true;
            // 
            // lblMemMapFile
            // 
            this.lblMemMapFile.AutoSize = true;
            this.lblMemMapFile.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblMemMapFile.Location = new System.Drawing.Point(369, 261);
            this.lblMemMapFile.Name = "lblMemMapFile";
            this.lblMemMapFile.Size = new System.Drawing.Size(108, 19);
            this.lblMemMapFile.TabIndex = 37;
            this.lblMemMapFile.Text = "Mem Map File:";
            // 
            // AlertSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 347);
            this.Controls.Add(this.tglMemMapFile);
            this.Controls.Add(this.lblMemMapFile);
            this.Controls.Add(this.txtDisclaimerText);
            this.Controls.Add(this.txtReferralsURL);
            this.Controls.Add(this.txtMyBotStatus);
            this.Controls.Add(this.txtMyBotName);
            this.Controls.Add(this.lblDisclaimerText);
            this.Controls.Add(this.lblReferralsURL);
            this.Controls.Add(this.lblMyBotStatus);
            this.Controls.Add(this.lblMyBotName);
            this.Controls.Add(this.tglDiscordOnAlert);
            this.Controls.Add(this.lblDiscordOnAlert);
            this.Controls.Add(this.tglTweetOnAlert);
            this.Controls.Add(this.lblTweetOnAlert);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.tglNotificationOnAlert);
            this.Controls.Add(this.lblNotificationOnAlert);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnValidateAndSave);
            this.Name = "AlertSettingsForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Alert Settings";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnValidateAndSave;
        private MetroFramework.Controls.MetroLabel lblResult;
        private MetroFramework.Controls.MetroToggle tglNotificationOnAlert;
        private MetroFramework.Controls.MetroLabel lblNotificationOnAlert;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private MetroFramework.Controls.MetroToggle tglTweetOnAlert;
        private MetroFramework.Controls.MetroLabel lblTweetOnAlert;
        private MetroFramework.Controls.MetroToggle tglDiscordOnAlert;
        private MetroFramework.Controls.MetroLabel lblDiscordOnAlert;
        private MetroFramework.Controls.MetroLabel lblMyBotName;
        private MetroFramework.Controls.MetroLabel lblMyBotStatus;
        private MetroFramework.Controls.MetroLabel lblReferralsURL;
        private MetroFramework.Controls.MetroLabel lblDisclaimerText;
        private MetroFramework.Controls.MetroTextBox txtMyBotName;
        private MetroFramework.Controls.MetroTextBox txtMyBotStatus;
        private MetroFramework.Controls.MetroTextBox txtReferralsURL;
        private MetroFramework.Controls.MetroTextBox txtDisclaimerText;
        private MetroFramework.Controls.MetroToggle tglMemMapFile;
        private MetroFramework.Controls.MetroLabel lblMemMapFile;
    }
}