namespace Plugin.AlertScanPlugins
{
    partial class WordPressAlertActionSettings
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
            this.txtURL = new MetroFramework.Controls.MetroTextBox();
            this.chkURL = new MetroFramework.Controls.MetroToggle();
            this.chkUser = new MetroFramework.Controls.MetroToggle();
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.chkPassword = new MetroFramework.Controls.MetroToggle();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new MetroFramework.Controls.MetroLabel();
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
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "WordPress API URL:";
            this.label1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtURL
            // 
            // 
            // 
            // 
            this.txtURL.CustomButton.Image = null;
            this.txtURL.CustomButton.Location = new System.Drawing.Point(342, 2);
            this.txtURL.CustomButton.Name = "";
            this.txtURL.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtURL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtURL.CustomButton.TabIndex = 1;
            this.txtURL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtURL.CustomButton.UseSelectable = true;
            this.txtURL.CustomButton.Visible = false;
            this.txtURL.Lines = new string[0];
            this.txtURL.Location = new System.Drawing.Point(16, 69);
            this.txtURL.MaxLength = 32767;
            this.txtURL.Name = "txtURL";
            this.txtURL.PasswordChar = '*';
            this.txtURL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtURL.SelectedText = "";
            this.txtURL.SelectionLength = 0;
            this.txtURL.SelectionStart = 0;
            this.txtURL.ShortcutsEnabled = true;
            this.txtURL.Size = new System.Drawing.Size(360, 20);
            this.txtURL.TabIndex = 5;
            this.txtURL.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtURL.UseSelectable = true;
            this.txtURL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtURL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // chkURL
            // 
            this.chkURL.AutoSize = true;
            this.chkURL.Checked = true;
            this.chkURL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkURL.DisplayStatus = false;
            this.chkURL.Location = new System.Drawing.Point(382, 71);
            this.chkURL.Name = "chkURL";
            this.chkURL.Size = new System.Drawing.Size(50, 17);
            this.chkURL.TabIndex = 6;
            this.chkURL.Text = "On";
            this.chkURL.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkURL.UseSelectable = true;
            this.chkURL.CheckedChanged += new System.EventHandler(this.chkURL_CheckedChanged);
            // 
            // chkUser
            // 
            this.chkUser.AutoSize = true;
            this.chkUser.Checked = true;
            this.chkUser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUser.DisplayStatus = false;
            this.chkUser.Location = new System.Drawing.Point(382, 118);
            this.chkUser.Name = "chkUser";
            this.chkUser.Size = new System.Drawing.Size(50, 17);
            this.chkUser.TabIndex = 9;
            this.chkUser.Text = "On";
            this.chkUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkUser.UseSelectable = true;
            this.chkUser.CheckedChanged += new System.EventHandler(this.chkUser_CheckedChanged);
            // 
            // txtUser
            // 
            // 
            // 
            // 
            this.txtUser.CustomButton.Image = null;
            this.txtUser.CustomButton.Location = new System.Drawing.Point(342, 2);
            this.txtUser.CustomButton.Name = "";
            this.txtUser.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUser.CustomButton.TabIndex = 1;
            this.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUser.CustomButton.UseSelectable = true;
            this.txtUser.CustomButton.Visible = false;
            this.txtUser.Lines = new string[0];
            this.txtUser.Location = new System.Drawing.Point(16, 116);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '*';
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(360, 20);
            this.txtUser.TabIndex = 8;
            this.txtUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtUser.UseSelectable = true;
            this.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "WordPress API User:";
            this.label3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // chkPassword
            // 
            this.chkPassword.AutoSize = true;
            this.chkPassword.Checked = true;
            this.chkPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPassword.DisplayStatus = false;
            this.chkPassword.Location = new System.Drawing.Point(382, 165);
            this.chkPassword.Name = "chkPassword";
            this.chkPassword.Size = new System.Drawing.Size(50, 17);
            this.chkPassword.TabIndex = 12;
            this.chkPassword.Text = "On";
            this.chkPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkPassword.UseSelectable = true;
            this.chkPassword.CheckedChanged += new System.EventHandler(this.chkPassword_CheckedChanged);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(342, 2);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(16, 163);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(360, 20);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "WordPress API User Password:";
            this.label4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // chkIncludeScreenshot
            // 
            this.chkIncludeScreenshot.AutoSize = true;
            this.chkIncludeScreenshot.DisplayStatus = false;
            this.chkIncludeScreenshot.Location = new System.Drawing.Point(147, 206);
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
            this.label7.Location = new System.Drawing.Point(13, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Include Screenshot";
            this.label7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(16, 240);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(202, 42);
            this.btnTest.TabIndex = 20;
            this.btnTest.Text = "Test WordPress";
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
            this.pnlBackground.Controls.Add(this.txtURL);
            this.pnlBackground.Controls.Add(this.chkURL);
            this.pnlBackground.Controls.Add(this.label3);
            this.pnlBackground.Controls.Add(this.txtUser);
            this.pnlBackground.Controls.Add(this.chkPassword);
            this.pnlBackground.Controls.Add(this.chkUser);
            this.pnlBackground.Controls.Add(this.txtPassword);
            this.pnlBackground.Controls.Add(this.label4);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.HorizontalScrollbarBarColor = true;
            this.pnlBackground.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlBackground.HorizontalScrollbarSize = 10;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(449, 296);
            this.pnlBackground.TabIndex = 21;
            this.pnlBackground.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlBackground.VerticalScrollbarBarColor = true;
            this.pnlBackground.VerticalScrollbarHighlightOnWheel = false;
            this.pnlBackground.VerticalScrollbarSize = 10;
            // 
            // WordPressAlertActionSettings
            // 
            this.Controls.Add(this.pnlBackground);
            this.Name = "WordPressAlertActionSettings";
            this.Size = new System.Drawing.Size(449, 296);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroTextBox txtURL;
        private MetroFramework.Controls.MetroToggle chkURL;
        private MetroFramework.Controls.MetroToggle chkUser;
        private MetroFramework.Controls.MetroTextBox txtUser;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroToggle chkPassword;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroToggle chkIncludeScreenshot;
        private MetroFramework.Controls.MetroLabel label7;
        private MetroFramework.Controls.MetroButton btnTest;
        private MetroFramework.Controls.MetroPanel pnlBackground;
    }
}
