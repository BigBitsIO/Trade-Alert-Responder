namespace TradeAlertResponder
{
    partial class DiscordSettingsForm
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
            this.lblBotToken = new MetroFramework.Controls.MetroLabel();
            this.txtBotToken = new MetroFramework.Controls.MetroTextBox();
            this.txtGuildServerId = new MetroFramework.Controls.MetroTextBox();
            this.lblGuildServerId = new MetroFramework.Controls.MetroLabel();
            this.btnValidateAndSave = new MetroFramework.Controls.MetroButton();
            this.lblResult = new MetroFramework.Controls.MetroLabel();
            this.tglBotToken = new MetroFramework.Controls.MetroToggle();
            this.tglGuildServerId = new MetroFramework.Controls.MetroToggle();
            this.tglTextChannelId = new MetroFramework.Controls.MetroToggle();
            this.txtTextChannelId = new MetroFramework.Controls.MetroTextBox();
            this.lblTextChannelId = new MetroFramework.Controls.MetroLabel();
            this.lblValuesVerified = new MetroFramework.Controls.MetroLabel();
            this.tglValuesVerified = new MetroFramework.Controls.MetroToggle();
            this.tglEnabled = new MetroFramework.Controls.MetroToggle();
            this.lblEnabled = new MetroFramework.Controls.MetroLabel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tglScreenshotsInAlerts = new MetroFramework.Controls.MetroToggle();
            this.tglTagHere = new MetroFramework.Controls.MetroToggle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tglTagEveryone = new MetroFramework.Controls.MetroToggle();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBotToken
            // 
            this.lblBotToken.AutoSize = true;
            this.lblBotToken.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblBotToken.Location = new System.Drawing.Point(23, 60);
            this.lblBotToken.Name = "lblBotToken";
            this.lblBotToken.Size = new System.Drawing.Size(80, 19);
            this.lblBotToken.TabIndex = 2;
            this.lblBotToken.Text = "Bot Token:";
            // 
            // txtBotToken
            // 
            // 
            // 
            // 
            this.txtBotToken.CustomButton.Image = null;
            this.txtBotToken.CustomButton.Location = new System.Drawing.Point(530, 1);
            this.txtBotToken.CustomButton.Name = "";
            this.txtBotToken.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBotToken.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBotToken.CustomButton.TabIndex = 1;
            this.txtBotToken.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBotToken.CustomButton.UseSelectable = true;
            this.txtBotToken.CustomButton.Visible = false;
            this.txtBotToken.Lines = new string[0];
            this.txtBotToken.Location = new System.Drawing.Point(28, 83);
            this.txtBotToken.MaxLength = 32767;
            this.txtBotToken.Name = "txtBotToken";
            this.txtBotToken.PasswordChar = '*';
            this.txtBotToken.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBotToken.SelectedText = "";
            this.txtBotToken.SelectionLength = 0;
            this.txtBotToken.SelectionStart = 0;
            this.txtBotToken.ShortcutsEnabled = true;
            this.txtBotToken.Size = new System.Drawing.Size(552, 23);
            this.txtBotToken.TabIndex = 3;
            this.txtBotToken.UseSelectable = true;
            this.txtBotToken.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBotToken.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtGuildServerId
            // 
            // 
            // 
            // 
            this.txtGuildServerId.CustomButton.Image = null;
            this.txtGuildServerId.CustomButton.Location = new System.Drawing.Point(530, 1);
            this.txtGuildServerId.CustomButton.Name = "";
            this.txtGuildServerId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGuildServerId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGuildServerId.CustomButton.TabIndex = 1;
            this.txtGuildServerId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGuildServerId.CustomButton.UseSelectable = true;
            this.txtGuildServerId.CustomButton.Visible = false;
            this.txtGuildServerId.Lines = new string[0];
            this.txtGuildServerId.Location = new System.Drawing.Point(28, 132);
            this.txtGuildServerId.MaxLength = 32767;
            this.txtGuildServerId.Name = "txtGuildServerId";
            this.txtGuildServerId.PasswordChar = '*';
            this.txtGuildServerId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGuildServerId.SelectedText = "";
            this.txtGuildServerId.SelectionLength = 0;
            this.txtGuildServerId.SelectionStart = 0;
            this.txtGuildServerId.ShortcutsEnabled = true;
            this.txtGuildServerId.Size = new System.Drawing.Size(552, 23);
            this.txtGuildServerId.TabIndex = 5;
            this.txtGuildServerId.UseSelectable = true;
            this.txtGuildServerId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGuildServerId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblGuildServerId
            // 
            this.lblGuildServerId.AutoSize = true;
            this.lblGuildServerId.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblGuildServerId.Location = new System.Drawing.Point(23, 109);
            this.lblGuildServerId.Name = "lblGuildServerId";
            this.lblGuildServerId.Size = new System.Drawing.Size(114, 19);
            this.lblGuildServerId.TabIndex = 4;
            this.lblGuildServerId.Text = "Guild Server Id:";
            // 
            // btnValidateAndSave
            // 
            this.btnValidateAndSave.Location = new System.Drawing.Point(28, 294);
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
            this.lblResult.Location = new System.Drawing.Point(108, 295);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 0);
            this.lblResult.TabIndex = 7;
            // 
            // tglBotToken
            // 
            this.tglBotToken.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglBotToken.AutoSize = true;
            this.tglBotToken.Checked = true;
            this.tglBotToken.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tglBotToken.DisplayStatus = false;
            this.tglBotToken.Location = new System.Drawing.Point(586, 83);
            this.tglBotToken.Name = "tglBotToken";
            this.tglBotToken.Size = new System.Drawing.Size(50, 23);
            this.tglBotToken.TabIndex = 8;
            this.tglBotToken.Text = "On";
            this.tglBotToken.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglBotToken.UseSelectable = true;
            this.tglBotToken.CheckedChanged += new System.EventHandler(this.tglBotToken_CheckedChanged);
            // 
            // tglGuildServerId
            // 
            this.tglGuildServerId.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglGuildServerId.AutoSize = true;
            this.tglGuildServerId.Checked = true;
            this.tglGuildServerId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tglGuildServerId.DisplayStatus = false;
            this.tglGuildServerId.Location = new System.Drawing.Point(586, 132);
            this.tglGuildServerId.Name = "tglGuildServerId";
            this.tglGuildServerId.Size = new System.Drawing.Size(50, 23);
            this.tglGuildServerId.TabIndex = 9;
            this.tglGuildServerId.Text = "On";
            this.tglGuildServerId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglGuildServerId.UseSelectable = true;
            this.tglGuildServerId.CheckedChanged += new System.EventHandler(this.tglGuildServerId_CheckedChanged);
            // 
            // tglTextChannelId
            // 
            this.tglTextChannelId.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglTextChannelId.AutoSize = true;
            this.tglTextChannelId.Checked = true;
            this.tglTextChannelId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tglTextChannelId.DisplayStatus = false;
            this.tglTextChannelId.Location = new System.Drawing.Point(586, 181);
            this.tglTextChannelId.Name = "tglTextChannelId";
            this.tglTextChannelId.Size = new System.Drawing.Size(50, 23);
            this.tglTextChannelId.TabIndex = 12;
            this.tglTextChannelId.Text = "On";
            this.tglTextChannelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglTextChannelId.UseSelectable = true;
            this.tglTextChannelId.CheckedChanged += new System.EventHandler(this.tglTextChannelId_CheckedChanged);
            // 
            // txtTextChannelId
            // 
            // 
            // 
            // 
            this.txtTextChannelId.CustomButton.Image = null;
            this.txtTextChannelId.CustomButton.Location = new System.Drawing.Point(530, 1);
            this.txtTextChannelId.CustomButton.Name = "";
            this.txtTextChannelId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTextChannelId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTextChannelId.CustomButton.TabIndex = 1;
            this.txtTextChannelId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTextChannelId.CustomButton.UseSelectable = true;
            this.txtTextChannelId.CustomButton.Visible = false;
            this.txtTextChannelId.Lines = new string[0];
            this.txtTextChannelId.Location = new System.Drawing.Point(28, 181);
            this.txtTextChannelId.MaxLength = 32767;
            this.txtTextChannelId.Name = "txtTextChannelId";
            this.txtTextChannelId.PasswordChar = '*';
            this.txtTextChannelId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTextChannelId.SelectedText = "";
            this.txtTextChannelId.SelectionLength = 0;
            this.txtTextChannelId.SelectionStart = 0;
            this.txtTextChannelId.ShortcutsEnabled = true;
            this.txtTextChannelId.Size = new System.Drawing.Size(552, 23);
            this.txtTextChannelId.TabIndex = 11;
            this.txtTextChannelId.UseSelectable = true;
            this.txtTextChannelId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTextChannelId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTextChannelId
            // 
            this.lblTextChannelId.AutoSize = true;
            this.lblTextChannelId.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTextChannelId.Location = new System.Drawing.Point(23, 158);
            this.lblTextChannelId.Name = "lblTextChannelId";
            this.lblTextChannelId.Size = new System.Drawing.Size(115, 19);
            this.lblTextChannelId.TabIndex = 10;
            this.lblTextChannelId.Text = "Text Channel Id:";
            // 
            // lblValuesVerified
            // 
            this.lblValuesVerified.AutoSize = true;
            this.lblValuesVerified.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblValuesVerified.Location = new System.Drawing.Point(23, 218);
            this.lblValuesVerified.Name = "lblValuesVerified";
            this.lblValuesVerified.Size = new System.Drawing.Size(167, 19);
            this.lblValuesVerified.TabIndex = 13;
            this.lblValuesVerified.Text = "Values Verified By User:";
            // 
            // tglValuesVerified
            // 
            this.tglValuesVerified.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglValuesVerified.AutoSize = true;
            this.tglValuesVerified.DisplayStatus = false;
            this.tglValuesVerified.Location = new System.Drawing.Point(196, 218);
            this.tglValuesVerified.Name = "tglValuesVerified";
            this.tglValuesVerified.Size = new System.Drawing.Size(50, 23);
            this.tglValuesVerified.TabIndex = 14;
            this.tglValuesVerified.Text = "Off";
            this.tglValuesVerified.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglValuesVerified.UseSelectable = true;
            // 
            // tglEnabled
            // 
            this.tglEnabled.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglEnabled.AutoSize = true;
            this.tglEnabled.DisplayStatus = false;
            this.tglEnabled.Location = new System.Drawing.Point(95, 251);
            this.tglEnabled.Name = "tglEnabled";
            this.tglEnabled.Size = new System.Drawing.Size(50, 23);
            this.tglEnabled.TabIndex = 16;
            this.tglEnabled.Text = "Off";
            this.tglEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglEnabled.UseSelectable = true;
            // 
            // lblEnabled
            // 
            this.lblEnabled.AutoSize = true;
            this.lblEnabled.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblEnabled.Location = new System.Drawing.Point(23, 253);
            this.lblEnabled.Name = "lblEnabled";
            this.lblEnabled.Size = new System.Drawing.Size(66, 19);
            this.lblEnabled.TabIndex = 15;
            this.lblEnabled.Text = "Enabled:";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.LaptopCode;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.Location = new System.Drawing.Point(399, 215);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 17;
            this.iconPictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(429, 218);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(151, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Screenshots In Alerts:";
            // 
            // tglScreenshotsInAlerts
            // 
            this.tglScreenshotsInAlerts.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglScreenshotsInAlerts.AutoSize = true;
            this.tglScreenshotsInAlerts.DisplayStatus = false;
            this.tglScreenshotsInAlerts.Enabled = false;
            this.tglScreenshotsInAlerts.Location = new System.Drawing.Point(586, 218);
            this.tglScreenshotsInAlerts.Name = "tglScreenshotsInAlerts";
            this.tglScreenshotsInAlerts.Size = new System.Drawing.Size(50, 23);
            this.tglScreenshotsInAlerts.TabIndex = 19;
            this.tglScreenshotsInAlerts.Text = "Off";
            this.tglScreenshotsInAlerts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglScreenshotsInAlerts.UseSelectable = true;
            // 
            // tglTagHere
            // 
            this.tglTagHere.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglTagHere.AutoSize = true;
            this.tglTagHere.DisplayStatus = false;
            this.tglTagHere.Location = new System.Drawing.Point(586, 251);
            this.tglTagHere.Name = "tglTagHere";
            this.tglTagHere.Size = new System.Drawing.Size(50, 23);
            this.tglTagHere.TabIndex = 21;
            this.tglTagHere.Text = "Off";
            this.tglTagHere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglTagHere.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(496, 253);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Tag @here:";
            // 
            // tglTagEveryone
            // 
            this.tglTagEveryone.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglTagEveryone.AutoSize = true;
            this.tglTagEveryone.DisplayStatus = false;
            this.tglTagEveryone.Location = new System.Drawing.Point(440, 251);
            this.tglTagEveryone.Name = "tglTagEveryone";
            this.tglTagEveryone.Size = new System.Drawing.Size(50, 23);
            this.tglTagEveryone.TabIndex = 23;
            this.tglTagEveryone.Text = "Off";
            this.tglTagEveryone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglTagEveryone.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(316, 253);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(118, 19);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "Tag @everyone:";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Discord;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconSize = 60;
            this.iconPictureBox2.Location = new System.Drawing.Point(196, 15);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(69, 60);
            this.iconPictureBox2.TabIndex = 24;
            this.iconPictureBox2.TabStop = false;
            // 
            // DiscordSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 340);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.tglTagEveryone);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tglTagHere);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tglScreenshotsInAlerts);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.tglEnabled);
            this.Controls.Add(this.lblEnabled);
            this.Controls.Add(this.tglValuesVerified);
            this.Controls.Add(this.lblValuesVerified);
            this.Controls.Add(this.tglTextChannelId);
            this.Controls.Add(this.txtTextChannelId);
            this.Controls.Add(this.lblTextChannelId);
            this.Controls.Add(this.tglGuildServerId);
            this.Controls.Add(this.tglBotToken);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnValidateAndSave);
            this.Controls.Add(this.txtGuildServerId);
            this.Controls.Add(this.lblGuildServerId);
            this.Controls.Add(this.txtBotToken);
            this.Controls.Add(this.lblBotToken);
            this.Name = "DiscordSettingsForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Discord Settings";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblBotToken;
        private MetroFramework.Controls.MetroTextBox txtBotToken;
        private MetroFramework.Controls.MetroTextBox txtGuildServerId;
        private MetroFramework.Controls.MetroLabel lblGuildServerId;
        private MetroFramework.Controls.MetroButton btnValidateAndSave;
        private MetroFramework.Controls.MetroLabel lblResult;
        private MetroFramework.Controls.MetroToggle tglBotToken;
        private MetroFramework.Controls.MetroToggle tglGuildServerId;
        private MetroFramework.Controls.MetroToggle tglTextChannelId;
        private MetroFramework.Controls.MetroTextBox txtTextChannelId;
        private MetroFramework.Controls.MetroLabel lblTextChannelId;
        private MetroFramework.Controls.MetroLabel lblValuesVerified;
        private MetroFramework.Controls.MetroToggle tglValuesVerified;
        private MetroFramework.Controls.MetroToggle tglEnabled;
        private MetroFramework.Controls.MetroLabel lblEnabled;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroToggle tglScreenshotsInAlerts;
        private MetroFramework.Controls.MetroToggle tglTagHere;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle tglTagEveryone;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}