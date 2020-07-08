namespace Plugin.AlertScanPlugins
{
    partial class WebhookAlertActionSettings
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
            this.txtTestMessage = new MetroFramework.Controls.MetroTextBox();
            this.chkUseJSON = new MetroFramework.Controls.MetroToggle();
            this.btnTest = new MetroFramework.Controls.MetroButton();
            this.pnlBackground = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtTestURL = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
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
            this.label1.Location = new System.Drawing.Point(12, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Test Parameters/Message:";
            this.label1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtTestMessage
            // 
            // 
            // 
            // 
            this.txtTestMessage.CustomButton.Image = null;
            this.txtTestMessage.CustomButton.Location = new System.Drawing.Point(342, 2);
            this.txtTestMessage.CustomButton.Name = "";
            this.txtTestMessage.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtTestMessage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTestMessage.CustomButton.TabIndex = 1;
            this.txtTestMessage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTestMessage.CustomButton.UseSelectable = true;
            this.txtTestMessage.CustomButton.Visible = false;
            this.txtTestMessage.Lines = new string[0];
            this.txtTestMessage.Location = new System.Drawing.Point(16, 325);
            this.txtTestMessage.MaxLength = 32767;
            this.txtTestMessage.Name = "txtTestMessage";
            this.txtTestMessage.PasswordChar = '\0';
            this.txtTestMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTestMessage.SelectedText = "";
            this.txtTestMessage.SelectionLength = 0;
            this.txtTestMessage.SelectionStart = 0;
            this.txtTestMessage.ShortcutsEnabled = true;
            this.txtTestMessage.Size = new System.Drawing.Size(360, 20);
            this.txtTestMessage.TabIndex = 5;
            this.txtTestMessage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtTestMessage.UseSelectable = true;
            this.txtTestMessage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTestMessage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkUseJSON
            // 
            this.chkUseJSON.AutoSize = true;
            this.chkUseJSON.DisplayStatus = false;
            this.chkUseJSON.Location = new System.Drawing.Point(382, 327);
            this.chkUseJSON.Name = "chkUseJSON";
            this.chkUseJSON.Size = new System.Drawing.Size(50, 17);
            this.chkUseJSON.TabIndex = 6;
            this.chkUseJSON.Text = "Off";
            this.chkUseJSON.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkUseJSON.UseSelectable = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(16, 351);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(202, 42);
            this.btnTest.TabIndex = 20;
            this.btnTest.Text = "Test Webhook";
            this.btnTest.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTest.UseSelectable = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.Controls.Add(this.metroLabel2);
            this.pnlBackground.Controls.Add(this.txtTestURL);
            this.pnlBackground.Controls.Add(this.metroLabel1);
            this.pnlBackground.Controls.Add(this.btnTest);
            this.pnlBackground.Controls.Add(this.label2);
            this.pnlBackground.Controls.Add(this.label1);
            this.pnlBackground.Controls.Add(this.txtTestMessage);
            this.pnlBackground.Controls.Add(this.chkUseJSON);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.HorizontalScrollbarBarColor = true;
            this.pnlBackground.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlBackground.HorizontalScrollbarSize = 10;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(449, 408);
            this.pnlBackground.TabIndex = 21;
            this.pnlBackground.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlBackground.VerticalScrollbarBarColor = true;
            this.pnlBackground.VerticalScrollbarHighlightOnWheel = false;
            this.pnlBackground.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(384, 305);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "JSON?";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtTestURL
            // 
            // 
            // 
            // 
            this.txtTestURL.CustomButton.Image = null;
            this.txtTestURL.CustomButton.Location = new System.Drawing.Point(342, 2);
            this.txtTestURL.CustomButton.Name = "";
            this.txtTestURL.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtTestURL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTestURL.CustomButton.TabIndex = 1;
            this.txtTestURL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTestURL.CustomButton.UseSelectable = true;
            this.txtTestURL.CustomButton.Visible = false;
            this.txtTestURL.Lines = new string[] {
        "https://webhook.site/0e97a4f9-6e2d-4da2-95f8-dc6179f8af99"};
            this.txtTestURL.Location = new System.Drawing.Point(16, 278);
            this.txtTestURL.MaxLength = 32767;
            this.txtTestURL.Name = "txtTestURL";
            this.txtTestURL.PasswordChar = '\0';
            this.txtTestURL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTestURL.SelectedText = "";
            this.txtTestURL.SelectionLength = 0;
            this.txtTestURL.SelectionStart = 0;
            this.txtTestURL.ShortcutsEnabled = true;
            this.txtTestURL.Size = new System.Drawing.Size(360, 20);
            this.txtTestURL.TabIndex = 22;
            this.txtTestURL.Text = "https://webhook.site/0e97a4f9-6e2d-4da2-95f8-dc6179f8af99";
            this.txtTestURL.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtTestURL.UseSelectable = true;
            this.txtTestURL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTestURL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 254);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "Test URL:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // WebhookAlertActionSettings
            // 
            this.Controls.Add(this.pnlBackground);
            this.Name = "WebhookAlertActionSettings";
            this.Size = new System.Drawing.Size(449, 408);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroTextBox txtTestMessage;
        private MetroFramework.Controls.MetroToggle chkUseJSON;
        private MetroFramework.Controls.MetroButton btnTest;
        private MetroFramework.Controls.MetroPanel pnlBackground;
        private MetroFramework.Controls.MetroTextBox txtTestURL;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}
