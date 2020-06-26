namespace Plugin.AlertScanPlugins
{
    partial class TwitterAlertActionSettings
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
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.txtConsumerKey = new MetroFramework.Controls.MetroTextBox();
            this.chkConsumerKey = new MetroFramework.Controls.MetroToggle();
            this.chkConsumerSecret = new MetroFramework.Controls.MetroToggle();
            this.txtConsumerSecret = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.chkAccessToken = new MetroFramework.Controls.MetroToggle();
            this.txtAccessToken = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.chkIncludeScreenshot = new MetroFramework.Controls.MetroToggle();
            this.label7 = new MetroFramework.Controls.MetroLabel();
            this.btnTest = new MetroFramework.Controls.MetroButton();
            this.chkAccessTokenSecret = new MetroFramework.Controls.MetroToggle();
            this.txtAccessTokenSecret = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.pnlBackground = new MetroFramework.Controls.MetroPanel();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Plugin Settings";
            this.label2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consumer Key:";
            this.label1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtConsumerKey
            // 
            // 
            // 
            // 
            this.txtConsumerKey.CustomButton.Image = null;
            this.txtConsumerKey.CustomButton.Location = new System.Drawing.Point(397, 2);
            this.txtConsumerKey.CustomButton.Name = "";
            this.txtConsumerKey.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtConsumerKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsumerKey.CustomButton.TabIndex = 1;
            this.txtConsumerKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsumerKey.CustomButton.UseSelectable = true;
            this.txtConsumerKey.CustomButton.Visible = false;
            this.txtConsumerKey.Lines = new string[0];
            this.txtConsumerKey.Location = new System.Drawing.Point(17, 75);
            this.txtConsumerKey.MaxLength = 32767;
            this.txtConsumerKey.Name = "txtConsumerKey";
            this.txtConsumerKey.PasswordChar = '*';
            this.txtConsumerKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsumerKey.SelectedText = "";
            this.txtConsumerKey.SelectionLength = 0;
            this.txtConsumerKey.SelectionStart = 0;
            this.txtConsumerKey.ShortcutsEnabled = true;
            this.txtConsumerKey.Size = new System.Drawing.Size(415, 20);
            this.txtConsumerKey.TabIndex = 5;
            this.txtConsumerKey.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtConsumerKey.UseSelectable = true;
            this.txtConsumerKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsumerKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtConsumerKey.TextChanged += new System.EventHandler(this.txtConsumerKey_TextChanged);
            // 
            // chkConsumerKey
            // 
            this.chkConsumerKey.AutoSize = true;
            this.chkConsumerKey.Checked = true;
            this.chkConsumerKey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConsumerKey.DisplayStatus = false;
            this.chkConsumerKey.Location = new System.Drawing.Point(438, 76);
            this.chkConsumerKey.Name = "chkConsumerKey";
            this.chkConsumerKey.Size = new System.Drawing.Size(50, 17);
            this.chkConsumerKey.TabIndex = 6;
            this.chkConsumerKey.Text = "On";
            this.chkConsumerKey.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkConsumerKey.UseSelectable = true;
            this.chkConsumerKey.CheckedChanged += new System.EventHandler(this.chkConsumerKey_CheckedChanged);
            // 
            // chkConsumerSecret
            // 
            this.chkConsumerSecret.AutoSize = true;
            this.chkConsumerSecret.Checked = true;
            this.chkConsumerSecret.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConsumerSecret.DisplayStatus = false;
            this.chkConsumerSecret.Location = new System.Drawing.Point(438, 123);
            this.chkConsumerSecret.Name = "chkConsumerSecret";
            this.chkConsumerSecret.Size = new System.Drawing.Size(50, 17);
            this.chkConsumerSecret.TabIndex = 9;
            this.chkConsumerSecret.Text = "On";
            this.chkConsumerSecret.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkConsumerSecret.UseSelectable = true;
            this.chkConsumerSecret.CheckedChanged += new System.EventHandler(this.chkConsumerSecret_CheckedChanged);
            // 
            // txtConsumerSecret
            // 
            // 
            // 
            // 
            this.txtConsumerSecret.CustomButton.Image = null;
            this.txtConsumerSecret.CustomButton.Location = new System.Drawing.Point(397, 2);
            this.txtConsumerSecret.CustomButton.Name = "";
            this.txtConsumerSecret.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtConsumerSecret.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsumerSecret.CustomButton.TabIndex = 1;
            this.txtConsumerSecret.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsumerSecret.CustomButton.UseSelectable = true;
            this.txtConsumerSecret.CustomButton.Visible = false;
            this.txtConsumerSecret.Lines = new string[0];
            this.txtConsumerSecret.Location = new System.Drawing.Point(17, 122);
            this.txtConsumerSecret.MaxLength = 32767;
            this.txtConsumerSecret.Name = "txtConsumerSecret";
            this.txtConsumerSecret.PasswordChar = '*';
            this.txtConsumerSecret.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsumerSecret.SelectedText = "";
            this.txtConsumerSecret.SelectionLength = 0;
            this.txtConsumerSecret.SelectionStart = 0;
            this.txtConsumerSecret.ShortcutsEnabled = true;
            this.txtConsumerSecret.Size = new System.Drawing.Size(415, 20);
            this.txtConsumerSecret.TabIndex = 8;
            this.txtConsumerSecret.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtConsumerSecret.UseSelectable = true;
            this.txtConsumerSecret.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsumerSecret.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtConsumerSecret.TextChanged += new System.EventHandler(this.txtConsumerSecret_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Consumer Secret:";
            this.label3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // chkAccessToken
            // 
            this.chkAccessToken.AutoSize = true;
            this.chkAccessToken.Checked = true;
            this.chkAccessToken.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAccessToken.DisplayStatus = false;
            this.chkAccessToken.Location = new System.Drawing.Point(438, 170);
            this.chkAccessToken.Name = "chkAccessToken";
            this.chkAccessToken.Size = new System.Drawing.Size(50, 17);
            this.chkAccessToken.TabIndex = 12;
            this.chkAccessToken.Text = "On";
            this.chkAccessToken.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkAccessToken.UseSelectable = true;
            this.chkAccessToken.CheckedChanged += new System.EventHandler(this.chkAccessToken_CheckedChanged);
            // 
            // txtAccessToken
            // 
            // 
            // 
            // 
            this.txtAccessToken.CustomButton.Image = null;
            this.txtAccessToken.CustomButton.Location = new System.Drawing.Point(397, 2);
            this.txtAccessToken.CustomButton.Name = "";
            this.txtAccessToken.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtAccessToken.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccessToken.CustomButton.TabIndex = 1;
            this.txtAccessToken.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccessToken.CustomButton.UseSelectable = true;
            this.txtAccessToken.CustomButton.Visible = false;
            this.txtAccessToken.Lines = new string[0];
            this.txtAccessToken.Location = new System.Drawing.Point(17, 169);
            this.txtAccessToken.MaxLength = 32767;
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.PasswordChar = '*';
            this.txtAccessToken.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccessToken.SelectedText = "";
            this.txtAccessToken.SelectionLength = 0;
            this.txtAccessToken.SelectionStart = 0;
            this.txtAccessToken.ShortcutsEnabled = true;
            this.txtAccessToken.Size = new System.Drawing.Size(415, 20);
            this.txtAccessToken.TabIndex = 11;
            this.txtAccessToken.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtAccessToken.UseSelectable = true;
            this.txtAccessToken.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccessToken.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAccessToken.TextChanged += new System.EventHandler(this.txtAccessToken_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Access Token:";
            this.label4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // chkIncludeScreenshot
            // 
            this.chkIncludeScreenshot.AutoSize = true;
            this.chkIncludeScreenshot.DisplayStatus = false;
            this.chkIncludeScreenshot.Location = new System.Drawing.Point(136, 258);
            this.chkIncludeScreenshot.Name = "chkIncludeScreenshot";
            this.chkIncludeScreenshot.Size = new System.Drawing.Size(50, 17);
            this.chkIncludeScreenshot.TabIndex = 19;
            this.chkIncludeScreenshot.Text = "Off";
            this.chkIncludeScreenshot.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkIncludeScreenshot.UseSelectable = true;
            this.chkIncludeScreenshot.CheckedChanged += new System.EventHandler(this.chkIncludeScreenshot_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Include Screenshot";
            this.label7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(17, 291);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(202, 35);
            this.btnTest.TabIndex = 20;
            this.btnTest.Text = "Test Twitter";
            this.btnTest.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTest.UseSelectable = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // chkAccessTokenSecret
            // 
            this.chkAccessTokenSecret.AutoSize = true;
            this.chkAccessTokenSecret.Checked = true;
            this.chkAccessTokenSecret.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAccessTokenSecret.DisplayStatus = false;
            this.chkAccessTokenSecret.Location = new System.Drawing.Point(438, 217);
            this.chkAccessTokenSecret.Name = "chkAccessTokenSecret";
            this.chkAccessTokenSecret.Size = new System.Drawing.Size(50, 17);
            this.chkAccessTokenSecret.TabIndex = 23;
            this.chkAccessTokenSecret.Text = "On";
            this.chkAccessTokenSecret.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkAccessTokenSecret.UseSelectable = true;
            this.chkAccessTokenSecret.CheckedChanged += new System.EventHandler(this.chkAccessTokenSecret_CheckedChanged);
            // 
            // txtAccessTokenSecret
            // 
            // 
            // 
            // 
            this.txtAccessTokenSecret.CustomButton.Image = null;
            this.txtAccessTokenSecret.CustomButton.Location = new System.Drawing.Point(397, 2);
            this.txtAccessTokenSecret.CustomButton.Name = "";
            this.txtAccessTokenSecret.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtAccessTokenSecret.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccessTokenSecret.CustomButton.TabIndex = 1;
            this.txtAccessTokenSecret.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccessTokenSecret.CustomButton.UseSelectable = true;
            this.txtAccessTokenSecret.CustomButton.Visible = false;
            this.txtAccessTokenSecret.Lines = new string[0];
            this.txtAccessTokenSecret.Location = new System.Drawing.Point(17, 216);
            this.txtAccessTokenSecret.MaxLength = 32767;
            this.txtAccessTokenSecret.Name = "txtAccessTokenSecret";
            this.txtAccessTokenSecret.PasswordChar = '*';
            this.txtAccessTokenSecret.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccessTokenSecret.SelectedText = "";
            this.txtAccessTokenSecret.SelectionLength = 0;
            this.txtAccessTokenSecret.SelectionStart = 0;
            this.txtAccessTokenSecret.ShortcutsEnabled = true;
            this.txtAccessTokenSecret.Size = new System.Drawing.Size(415, 20);
            this.txtAccessTokenSecret.TabIndex = 22;
            this.txtAccessTokenSecret.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtAccessTokenSecret.UseSelectable = true;
            this.txtAccessTokenSecret.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccessTokenSecret.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAccessTokenSecret.TextChanged += new System.EventHandler(this.txtAccessTokenSecret_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Access Token Secret:";
            this.label5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pnlBackground
            // 
            this.pnlBackground.Controls.Add(this.txtAccessTokenSecret);
            this.pnlBackground.Controls.Add(this.chkAccessTokenSecret);
            this.pnlBackground.Controls.Add(this.label2);
            this.pnlBackground.Controls.Add(this.label5);
            this.pnlBackground.Controls.Add(this.label1);
            this.pnlBackground.Controls.Add(this.btnTest);
            this.pnlBackground.Controls.Add(this.txtConsumerKey);
            this.pnlBackground.Controls.Add(this.chkIncludeScreenshot);
            this.pnlBackground.Controls.Add(this.chkConsumerKey);
            this.pnlBackground.Controls.Add(this.label7);
            this.pnlBackground.Controls.Add(this.label3);
            this.pnlBackground.Controls.Add(this.chkAccessToken);
            this.pnlBackground.Controls.Add(this.txtConsumerSecret);
            this.pnlBackground.Controls.Add(this.txtAccessToken);
            this.pnlBackground.Controls.Add(this.chkConsumerSecret);
            this.pnlBackground.Controls.Add(this.label4);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.HorizontalScrollbarBarColor = true;
            this.pnlBackground.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlBackground.HorizontalScrollbarSize = 10;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(503, 344);
            this.pnlBackground.TabIndex = 24;
            this.pnlBackground.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlBackground.VerticalScrollbarBarColor = true;
            this.pnlBackground.VerticalScrollbarHighlightOnWheel = false;
            this.pnlBackground.VerticalScrollbarSize = 10;
            // 
            // TwitterAlertActionSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBackground);
            this.Name = "TwitterAlertActionSettings";
            this.Size = new System.Drawing.Size(503, 344);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroTextBox txtConsumerKey;
        private MetroFramework.Controls.MetroToggle chkConsumerKey;
        private MetroFramework.Controls.MetroToggle chkConsumerSecret;
        private MetroFramework.Controls.MetroTextBox txtConsumerSecret;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroToggle chkAccessToken;
        private MetroFramework.Controls.MetroTextBox txtAccessToken;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroToggle chkIncludeScreenshot;
        private MetroFramework.Controls.MetroLabel label7;
        private MetroFramework.Controls.MetroButton btnTest;
        private MetroFramework.Controls.MetroToggle chkAccessTokenSecret;
        private MetroFramework.Controls.MetroTextBox txtAccessTokenSecret;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Controls.MetroPanel pnlBackground;
    }
}
