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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsumerKey = new System.Windows.Forms.TextBox();
            this.chkConsumerKey = new System.Windows.Forms.CheckBox();
            this.chkConsumerSecret = new System.Windows.Forms.CheckBox();
            this.txtConsumerSecret = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAccessToken = new System.Windows.Forms.CheckBox();
            this.txtAccessToken = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIncludeScreenshot = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.chkAccessTokenSecret = new System.Windows.Forms.CheckBox();
            this.txtAccessTokenSecret = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Plugin Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consumer Key:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtConsumerKey
            // 
            this.txtConsumerKey.Location = new System.Drawing.Point(14, 100);
            this.txtConsumerKey.Name = "txtConsumerKey";
            this.txtConsumerKey.PasswordChar = '*';
            this.txtConsumerKey.Size = new System.Drawing.Size(487, 20);
            this.txtConsumerKey.TabIndex = 5;
            this.txtConsumerKey.TextChanged += new System.EventHandler(this.txtConsumerKey_TextChanged);
            // 
            // chkConsumerKey
            // 
            this.chkConsumerKey.AutoSize = true;
            this.chkConsumerKey.Checked = true;
            this.chkConsumerKey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConsumerKey.Location = new System.Drawing.Point(508, 103);
            this.chkConsumerKey.Name = "chkConsumerKey";
            this.chkConsumerKey.Size = new System.Drawing.Size(15, 14);
            this.chkConsumerKey.TabIndex = 6;
            this.chkConsumerKey.UseVisualStyleBackColor = true;
            this.chkConsumerKey.CheckedChanged += new System.EventHandler(this.chkConsumerKey_CheckedChanged);
            // 
            // chkConsumerSecret
            // 
            this.chkConsumerSecret.AutoSize = true;
            this.chkConsumerSecret.Checked = true;
            this.chkConsumerSecret.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConsumerSecret.Location = new System.Drawing.Point(508, 150);
            this.chkConsumerSecret.Name = "chkConsumerSecret";
            this.chkConsumerSecret.Size = new System.Drawing.Size(15, 14);
            this.chkConsumerSecret.TabIndex = 9;
            this.chkConsumerSecret.UseVisualStyleBackColor = true;
            this.chkConsumerSecret.CheckedChanged += new System.EventHandler(this.chkConsumerSecret_CheckedChanged);
            // 
            // txtConsumerSecret
            // 
            this.txtConsumerSecret.Location = new System.Drawing.Point(14, 147);
            this.txtConsumerSecret.Name = "txtConsumerSecret";
            this.txtConsumerSecret.PasswordChar = '*';
            this.txtConsumerSecret.Size = new System.Drawing.Size(487, 20);
            this.txtConsumerSecret.TabIndex = 8;
            this.txtConsumerSecret.TextChanged += new System.EventHandler(this.txtConsumerSecret_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Consumer Secret:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // chkAccessToken
            // 
            this.chkAccessToken.AutoSize = true;
            this.chkAccessToken.Checked = true;
            this.chkAccessToken.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAccessToken.Location = new System.Drawing.Point(508, 197);
            this.chkAccessToken.Name = "chkAccessToken";
            this.chkAccessToken.Size = new System.Drawing.Size(15, 14);
            this.chkAccessToken.TabIndex = 12;
            this.chkAccessToken.UseVisualStyleBackColor = true;
            this.chkAccessToken.CheckedChanged += new System.EventHandler(this.chkAccessToken_CheckedChanged);
            // 
            // txtAccessToken
            // 
            this.txtAccessToken.Location = new System.Drawing.Point(14, 194);
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.PasswordChar = '*';
            this.txtAccessToken.Size = new System.Drawing.Size(487, 20);
            this.txtAccessToken.TabIndex = 11;
            this.txtAccessToken.TextChanged += new System.EventHandler(this.txtAccessToken_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Access Token:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // chkIncludeScreenshot
            // 
            this.chkIncludeScreenshot.AutoSize = true;
            this.chkIncludeScreenshot.Location = new System.Drawing.Point(180, 293);
            this.chkIncludeScreenshot.Name = "chkIncludeScreenshot";
            this.chkIncludeScreenshot.Size = new System.Drawing.Size(15, 14);
            this.chkIncludeScreenshot.TabIndex = 19;
            this.chkIncludeScreenshot.UseVisualStyleBackColor = true;
            this.chkIncludeScreenshot.CheckedChanged += new System.EventHandler(this.chkIncludeScreenshot_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Include Screenshot";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnTest
            // 
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Location = new System.Drawing.Point(299, 274);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(202, 35);
            this.btnTest.TabIndex = 20;
            this.btnTest.Text = "Test Twitter";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // chkAccessTokenSecret
            // 
            this.chkAccessTokenSecret.AutoSize = true;
            this.chkAccessTokenSecret.Checked = true;
            this.chkAccessTokenSecret.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAccessTokenSecret.Location = new System.Drawing.Point(508, 244);
            this.chkAccessTokenSecret.Name = "chkAccessTokenSecret";
            this.chkAccessTokenSecret.Size = new System.Drawing.Size(15, 14);
            this.chkAccessTokenSecret.TabIndex = 23;
            this.chkAccessTokenSecret.UseVisualStyleBackColor = true;
            this.chkAccessTokenSecret.CheckedChanged += new System.EventHandler(this.chkAccessTokenSecret_CheckedChanged);
            // 
            // txtAccessTokenSecret
            // 
            this.txtAccessTokenSecret.Location = new System.Drawing.Point(14, 241);
            this.txtAccessTokenSecret.Name = "txtAccessTokenSecret";
            this.txtAccessTokenSecret.PasswordChar = '*';
            this.txtAccessTokenSecret.Size = new System.Drawing.Size(487, 20);
            this.txtAccessTokenSecret.TabIndex = 22;
            this.txtAccessTokenSecret.TextChanged += new System.EventHandler(this.txtAccessTokenSecret_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Access Token Secret:";
            // 
            // TwitterAlertActionSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkAccessTokenSecret);
            this.Controls.Add(this.txtAccessTokenSecret);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.chkIncludeScreenshot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkAccessToken);
            this.Controls.Add(this.txtAccessToken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkConsumerSecret);
            this.Controls.Add(this.txtConsumerSecret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkConsumerKey);
            this.Controls.Add(this.txtConsumerKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "TwitterAlertActionSettings";
            this.Size = new System.Drawing.Size(533, 324);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsumerKey;
        private System.Windows.Forms.CheckBox chkConsumerKey;
        private System.Windows.Forms.CheckBox chkConsumerSecret;
        private System.Windows.Forms.TextBox txtConsumerSecret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAccessToken;
        private System.Windows.Forms.TextBox txtAccessToken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkIncludeScreenshot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.CheckBox chkAccessTokenSecret;
        private System.Windows.Forms.TextBox txtAccessTokenSecret;
        private System.Windows.Forms.Label label5;
    }
}
