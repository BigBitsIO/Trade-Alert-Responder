namespace Plugin.AlertScanPlugins
{
    partial class DiscordAlertActionSettings
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
            this.txtBotToken = new MetroFramework.Controls.MetroTextBox();
            this.chkBotToken = new MetroFramework.Controls.MetroToggle();
            this.chkGuildServerId = new MetroFramework.Controls.MetroToggle();
            this.txtGuildServerId = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.chkTextChannelId = new MetroFramework.Controls.MetroToggle();
            this.txtTextChannelId = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.chkTagEveryone = new MetroFramework.Controls.MetroToggle();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.chkTagHere = new MetroFramework.Controls.MetroToggle();
            this.label6 = new MetroFramework.Controls.MetroLabel();
            this.chkIncludeScreenshot = new MetroFramework.Controls.MetroToggle();
            this.label7 = new MetroFramework.Controls.MetroLabel();
            this.btnTest = new MetroFramework.Controls.MetroButton();
            this.pnlBackground = new MetroFramework.Controls.MetroPanel();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Plugin Settings";
            this.label2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bot Token:";
            this.label1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBotToken
            // 
            // 
            // 
            // 
            this.txtBotToken.CustomButton.Image = null;
            this.txtBotToken.CustomButton.Location = new System.Drawing.Point(342, 2);
            this.txtBotToken.CustomButton.Name = "";
            this.txtBotToken.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtBotToken.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBotToken.CustomButton.TabIndex = 1;
            this.txtBotToken.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBotToken.CustomButton.UseSelectable = true;
            this.txtBotToken.CustomButton.Visible = false;
            this.txtBotToken.Lines = new string[0];
            this.txtBotToken.Location = new System.Drawing.Point(16, 69);
            this.txtBotToken.MaxLength = 32767;
            this.txtBotToken.Name = "txtBotToken";
            this.txtBotToken.PasswordChar = '*';
            this.txtBotToken.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBotToken.SelectedText = "";
            this.txtBotToken.SelectionLength = 0;
            this.txtBotToken.SelectionStart = 0;
            this.txtBotToken.ShortcutsEnabled = true;
            this.txtBotToken.Size = new System.Drawing.Size(360, 20);
            this.txtBotToken.TabIndex = 5;
            this.txtBotToken.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtBotToken.UseSelectable = true;
            this.txtBotToken.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBotToken.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBotToken.TextChanged += new System.EventHandler(this.txtBotToken_TextChanged);
            // 
            // chkBotToken
            // 
            this.chkBotToken.AutoSize = true;
            this.chkBotToken.Checked = true;
            this.chkBotToken.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBotToken.DisplayStatus = false;
            this.chkBotToken.Location = new System.Drawing.Point(382, 71);
            this.chkBotToken.Name = "chkBotToken";
            this.chkBotToken.Size = new System.Drawing.Size(50, 17);
            this.chkBotToken.TabIndex = 6;
            this.chkBotToken.Text = "On";
            this.chkBotToken.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkBotToken.UseSelectable = true;
            this.chkBotToken.CheckedChanged += new System.EventHandler(this.chkBotToken_CheckedChanged);
            // 
            // chkGuildServerId
            // 
            this.chkGuildServerId.AutoSize = true;
            this.chkGuildServerId.Checked = true;
            this.chkGuildServerId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGuildServerId.DisplayStatus = false;
            this.chkGuildServerId.Location = new System.Drawing.Point(382, 118);
            this.chkGuildServerId.Name = "chkGuildServerId";
            this.chkGuildServerId.Size = new System.Drawing.Size(50, 17);
            this.chkGuildServerId.TabIndex = 9;
            this.chkGuildServerId.Text = "On";
            this.chkGuildServerId.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkGuildServerId.UseSelectable = true;
            this.chkGuildServerId.CheckedChanged += new System.EventHandler(this.chkGuildServerId_CheckedChanged);
            // 
            // txtGuildServerId
            // 
            // 
            // 
            // 
            this.txtGuildServerId.CustomButton.Image = null;
            this.txtGuildServerId.CustomButton.Location = new System.Drawing.Point(342, 2);
            this.txtGuildServerId.CustomButton.Name = "";
            this.txtGuildServerId.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtGuildServerId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGuildServerId.CustomButton.TabIndex = 1;
            this.txtGuildServerId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGuildServerId.CustomButton.UseSelectable = true;
            this.txtGuildServerId.CustomButton.Visible = false;
            this.txtGuildServerId.Lines = new string[0];
            this.txtGuildServerId.Location = new System.Drawing.Point(16, 116);
            this.txtGuildServerId.MaxLength = 32767;
            this.txtGuildServerId.Name = "txtGuildServerId";
            this.txtGuildServerId.PasswordChar = '*';
            this.txtGuildServerId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGuildServerId.SelectedText = "";
            this.txtGuildServerId.SelectionLength = 0;
            this.txtGuildServerId.SelectionStart = 0;
            this.txtGuildServerId.ShortcutsEnabled = true;
            this.txtGuildServerId.Size = new System.Drawing.Size(360, 20);
            this.txtGuildServerId.TabIndex = 8;
            this.txtGuildServerId.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtGuildServerId.UseSelectable = true;
            this.txtGuildServerId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGuildServerId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtGuildServerId.TextChanged += new System.EventHandler(this.txtGuildServerId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Guild Server Id:";
            this.label3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // chkTextChannelId
            // 
            this.chkTextChannelId.AutoSize = true;
            this.chkTextChannelId.Checked = true;
            this.chkTextChannelId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTextChannelId.DisplayStatus = false;
            this.chkTextChannelId.Location = new System.Drawing.Point(382, 165);
            this.chkTextChannelId.Name = "chkTextChannelId";
            this.chkTextChannelId.Size = new System.Drawing.Size(50, 17);
            this.chkTextChannelId.TabIndex = 12;
            this.chkTextChannelId.Text = "On";
            this.chkTextChannelId.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkTextChannelId.UseSelectable = true;
            this.chkTextChannelId.CheckedChanged += new System.EventHandler(this.chkTextChannelId_CheckedChanged);
            // 
            // txtTextChannelId
            // 
            // 
            // 
            // 
            this.txtTextChannelId.CustomButton.Image = null;
            this.txtTextChannelId.CustomButton.Location = new System.Drawing.Point(342, 2);
            this.txtTextChannelId.CustomButton.Name = "";
            this.txtTextChannelId.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtTextChannelId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTextChannelId.CustomButton.TabIndex = 1;
            this.txtTextChannelId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTextChannelId.CustomButton.UseSelectable = true;
            this.txtTextChannelId.CustomButton.Visible = false;
            this.txtTextChannelId.Lines = new string[0];
            this.txtTextChannelId.Location = new System.Drawing.Point(16, 163);
            this.txtTextChannelId.MaxLength = 32767;
            this.txtTextChannelId.Name = "txtTextChannelId";
            this.txtTextChannelId.PasswordChar = '*';
            this.txtTextChannelId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTextChannelId.SelectedText = "";
            this.txtTextChannelId.SelectionLength = 0;
            this.txtTextChannelId.SelectionStart = 0;
            this.txtTextChannelId.ShortcutsEnabled = true;
            this.txtTextChannelId.Size = new System.Drawing.Size(360, 20);
            this.txtTextChannelId.TabIndex = 11;
            this.txtTextChannelId.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtTextChannelId.UseSelectable = true;
            this.txtTextChannelId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTextChannelId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTextChannelId.TextChanged += new System.EventHandler(this.txtTextChannelId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Text Channel Id:";
            this.label4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // chkTagEveryone
            // 
            this.chkTagEveryone.AutoSize = true;
            this.chkTagEveryone.DisplayStatus = false;
            this.chkTagEveryone.Location = new System.Drawing.Point(146, 209);
            this.chkTagEveryone.Name = "chkTagEveryone";
            this.chkTagEveryone.Size = new System.Drawing.Size(50, 17);
            this.chkTagEveryone.TabIndex = 15;
            this.chkTagEveryone.Text = "Off";
            this.chkTagEveryone.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkTagEveryone.UseSelectable = true;
            this.chkTagEveryone.CheckedChanged += new System.EventHandler(this.chkTagEveryone_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tag @everyone";
            this.label5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // chkTagHere
            // 
            this.chkTagHere.AutoSize = true;
            this.chkTagHere.DisplayStatus = false;
            this.chkTagHere.Location = new System.Drawing.Point(146, 252);
            this.chkTagHere.Name = "chkTagHere";
            this.chkTagHere.Size = new System.Drawing.Size(50, 17);
            this.chkTagHere.TabIndex = 17;
            this.chkTagHere.Text = "Off";
            this.chkTagHere.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkTagHere.UseSelectable = true;
            this.chkTagHere.CheckedChanged += new System.EventHandler(this.chkTagHere_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tag @here";
            this.label6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // chkIncludeScreenshot
            // 
            this.chkIncludeScreenshot.AutoSize = true;
            this.chkIncludeScreenshot.DisplayStatus = false;
            this.chkIncludeScreenshot.Location = new System.Drawing.Point(146, 296);
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
            this.label7.Location = new System.Drawing.Point(12, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Include Screenshot";
            this.label7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(11, 330);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(202, 42);
            this.btnTest.TabIndex = 20;
            this.btnTest.Text = "Test Discord";
            this.btnTest.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTest.UseSelectable = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.Controls.Add(this.chkIncludeScreenshot);
            this.pnlBackground.Controls.Add(this.btnTest);
            this.pnlBackground.Controls.Add(this.label2);
            this.pnlBackground.Controls.Add(this.label7);
            this.pnlBackground.Controls.Add(this.label1);
            this.pnlBackground.Controls.Add(this.chkTagHere);
            this.pnlBackground.Controls.Add(this.txtBotToken);
            this.pnlBackground.Controls.Add(this.label6);
            this.pnlBackground.Controls.Add(this.chkBotToken);
            this.pnlBackground.Controls.Add(this.chkTagEveryone);
            this.pnlBackground.Controls.Add(this.label3);
            this.pnlBackground.Controls.Add(this.label5);
            this.pnlBackground.Controls.Add(this.txtGuildServerId);
            this.pnlBackground.Controls.Add(this.chkTextChannelId);
            this.pnlBackground.Controls.Add(this.chkGuildServerId);
            this.pnlBackground.Controls.Add(this.txtTextChannelId);
            this.pnlBackground.Controls.Add(this.label4);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.HorizontalScrollbarBarColor = true;
            this.pnlBackground.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlBackground.HorizontalScrollbarSize = 10;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(449, 386);
            this.pnlBackground.TabIndex = 21;
            this.pnlBackground.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlBackground.VerticalScrollbarBarColor = true;
            this.pnlBackground.VerticalScrollbarHighlightOnWheel = false;
            this.pnlBackground.VerticalScrollbarSize = 10;
            // 
            // DiscordAlertActionSettings
            // 
            this.Controls.Add(this.pnlBackground);
            this.Name = "DiscordAlertActionSettings";
            this.Size = new System.Drawing.Size(449, 386);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroTextBox txtBotToken;
        private MetroFramework.Controls.MetroToggle chkBotToken;
        private MetroFramework.Controls.MetroToggle chkGuildServerId;
        private MetroFramework.Controls.MetroTextBox txtGuildServerId;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroToggle chkTextChannelId;
        private MetroFramework.Controls.MetroTextBox txtTextChannelId;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroToggle chkTagEveryone;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Controls.MetroToggle chkTagHere;
        private MetroFramework.Controls.MetroLabel label6;
        private MetroFramework.Controls.MetroToggle chkIncludeScreenshot;
        private MetroFramework.Controls.MetroLabel label7;
        private MetroFramework.Controls.MetroButton btnTest;
        private MetroFramework.Controls.MetroPanel pnlBackground;
    }
}
