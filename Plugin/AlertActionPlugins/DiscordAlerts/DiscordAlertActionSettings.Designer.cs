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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBotToken = new System.Windows.Forms.TextBox();
            this.chkBotToken = new System.Windows.Forms.CheckBox();
            this.chkGuildServerId = new System.Windows.Forms.CheckBox();
            this.txtGuildServerId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkTextChannelId = new System.Windows.Forms.CheckBox();
            this.txtTextChannelId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkTagEveryone = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkTagHere = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkIncludeScreenshot = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bot Token:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBotToken
            // 
            this.txtBotToken.Location = new System.Drawing.Point(14, 100);
            this.txtBotToken.Name = "txtBotToken";
            this.txtBotToken.PasswordChar = '*';
            this.txtBotToken.Size = new System.Drawing.Size(487, 20);
            this.txtBotToken.TabIndex = 5;
            this.txtBotToken.TextChanged += new System.EventHandler(this.txtBotToken_TextChanged);
            // 
            // chkBotToken
            // 
            this.chkBotToken.AutoSize = true;
            this.chkBotToken.Checked = true;
            this.chkBotToken.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBotToken.Location = new System.Drawing.Point(508, 103);
            this.chkBotToken.Name = "chkBotToken";
            this.chkBotToken.Size = new System.Drawing.Size(15, 14);
            this.chkBotToken.TabIndex = 6;
            this.chkBotToken.UseVisualStyleBackColor = true;
            this.chkBotToken.CheckedChanged += new System.EventHandler(this.chkBotToken_CheckedChanged);
            // 
            // chkGuildServerId
            // 
            this.chkGuildServerId.AutoSize = true;
            this.chkGuildServerId.Checked = true;
            this.chkGuildServerId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGuildServerId.Location = new System.Drawing.Point(508, 150);
            this.chkGuildServerId.Name = "chkGuildServerId";
            this.chkGuildServerId.Size = new System.Drawing.Size(15, 14);
            this.chkGuildServerId.TabIndex = 9;
            this.chkGuildServerId.UseVisualStyleBackColor = true;
            this.chkGuildServerId.CheckedChanged += new System.EventHandler(this.chkGuildServerId_CheckedChanged);
            // 
            // txtGuildServerId
            // 
            this.txtGuildServerId.Location = new System.Drawing.Point(14, 147);
            this.txtGuildServerId.Name = "txtGuildServerId";
            this.txtGuildServerId.PasswordChar = '*';
            this.txtGuildServerId.Size = new System.Drawing.Size(487, 20);
            this.txtGuildServerId.TabIndex = 8;
            this.txtGuildServerId.TextChanged += new System.EventHandler(this.txtGuildServerId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Guild Server Id:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // chkTextChannelId
            // 
            this.chkTextChannelId.AutoSize = true;
            this.chkTextChannelId.Checked = true;
            this.chkTextChannelId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTextChannelId.Location = new System.Drawing.Point(508, 197);
            this.chkTextChannelId.Name = "chkTextChannelId";
            this.chkTextChannelId.Size = new System.Drawing.Size(15, 14);
            this.chkTextChannelId.TabIndex = 12;
            this.chkTextChannelId.UseVisualStyleBackColor = true;
            this.chkTextChannelId.CheckedChanged += new System.EventHandler(this.chkTextChannelId_CheckedChanged);
            // 
            // txtTextChannelId
            // 
            this.txtTextChannelId.Location = new System.Drawing.Point(14, 194);
            this.txtTextChannelId.Name = "txtTextChannelId";
            this.txtTextChannelId.PasswordChar = '*';
            this.txtTextChannelId.Size = new System.Drawing.Size(487, 20);
            this.txtTextChannelId.TabIndex = 11;
            this.txtTextChannelId.TextChanged += new System.EventHandler(this.txtTextChannelId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Text Channel Id:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // chkTagEveryone
            // 
            this.chkTagEveryone.AutoSize = true;
            this.chkTagEveryone.Location = new System.Drawing.Point(180, 242);
            this.chkTagEveryone.Name = "chkTagEveryone";
            this.chkTagEveryone.Size = new System.Drawing.Size(15, 14);
            this.chkTagEveryone.TabIndex = 15;
            this.chkTagEveryone.UseVisualStyleBackColor = true;
            this.chkTagEveryone.CheckedChanged += new System.EventHandler(this.chkTagEveryone_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tag @everyone";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // chkTagHere
            // 
            this.chkTagHere.AutoSize = true;
            this.chkTagHere.Location = new System.Drawing.Point(180, 285);
            this.chkTagHere.Name = "chkTagHere";
            this.chkTagHere.Size = new System.Drawing.Size(15, 14);
            this.chkTagHere.TabIndex = 17;
            this.chkTagHere.UseVisualStyleBackColor = true;
            this.chkTagHere.CheckedChanged += new System.EventHandler(this.chkTagHere_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tag @here";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // chkIncludeScreenshot
            // 
            this.chkIncludeScreenshot.AutoSize = true;
            this.chkIncludeScreenshot.Location = new System.Drawing.Point(180, 329);
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
            this.label7.Location = new System.Drawing.Point(10, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Include Screenshot";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnTest
            // 
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Location = new System.Drawing.Point(299, 234);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(202, 111);
            this.btnTest.TabIndex = 20;
            this.btnTest.Text = "Test Discord";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // DiscordAlertActionSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.chkIncludeScreenshot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkTagHere);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkTagEveryone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkTextChannelId);
            this.Controls.Add(this.txtTextChannelId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkGuildServerId);
            this.Controls.Add(this.txtGuildServerId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkBotToken);
            this.Controls.Add(this.txtBotToken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "DiscordAlertActionSettings";
            this.Size = new System.Drawing.Size(533, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBotToken;
        private System.Windows.Forms.CheckBox chkBotToken;
        private System.Windows.Forms.CheckBox chkGuildServerId;
        private System.Windows.Forms.TextBox txtGuildServerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkTextChannelId;
        private System.Windows.Forms.TextBox txtTextChannelId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkTagEveryone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkTagHere;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkIncludeScreenshot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTest;
    }
}
