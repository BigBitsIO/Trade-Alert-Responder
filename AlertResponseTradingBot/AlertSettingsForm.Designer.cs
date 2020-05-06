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
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValidateAndSave
            // 
            this.btnValidateAndSave.Location = new System.Drawing.Point(23, 195);
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
            this.lblResult.Location = new System.Drawing.Point(108, 207);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 0);
            this.lblResult.TabIndex = 7;
            // 
            // tglNotificationOnAlert
            // 
            this.tglNotificationOnAlert.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglNotificationOnAlert.AutoSize = true;
            this.tglNotificationOnAlert.DisplayStatus = false;
            this.tglNotificationOnAlert.Location = new System.Drawing.Point(179, 80);
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
            this.lblNotificationOnAlert.Location = new System.Drawing.Point(23, 81);
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
            // 
            // tglTweetOnAlert
            // 
            this.tglTweetOnAlert.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglTweetOnAlert.AutoSize = true;
            this.tglTweetOnAlert.DisplayStatus = false;
            this.tglTweetOnAlert.Location = new System.Drawing.Point(179, 112);
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
            this.lblTweetOnAlert.Location = new System.Drawing.Point(23, 113);
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
            this.tglDiscordOnAlert.Location = new System.Drawing.Point(179, 143);
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
            this.lblDiscordOnAlert.Location = new System.Drawing.Point(23, 144);
            this.lblDiscordOnAlert.Name = "lblDiscordOnAlert";
            this.lblDiscordOnAlert.Size = new System.Drawing.Size(122, 19);
            this.lblDiscordOnAlert.TabIndex = 27;
            this.lblDiscordOnAlert.Text = "Discord on Alert:";
            // 
            // AlertSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 240);
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
    }
}