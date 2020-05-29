namespace TradeAlertResponder.Controls
{
    partial class Disclaimer
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
            this.pnlDisclaimer = new MetroFramework.Controls.MetroPanel();
            this.txtDisclaimer = new MetroFramework.Controls.MetroTextBox();
            this.pnlDisclaimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDisclaimer
            // 
            this.pnlDisclaimer.Controls.Add(this.txtDisclaimer);
            this.pnlDisclaimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisclaimer.HorizontalScrollbarBarColor = true;
            this.pnlDisclaimer.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDisclaimer.HorizontalScrollbarSize = 10;
            this.pnlDisclaimer.Location = new System.Drawing.Point(0, 0);
            this.pnlDisclaimer.Name = "pnlDisclaimer";
            this.pnlDisclaimer.Size = new System.Drawing.Size(833, 526);
            this.pnlDisclaimer.TabIndex = 0;
            this.pnlDisclaimer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlDisclaimer.VerticalScrollbarBarColor = true;
            this.pnlDisclaimer.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDisclaimer.VerticalScrollbarSize = 10;
            // 
            // txtDisclaimer
            // 
            // 
            // 
            // 
            this.txtDisclaimer.CustomButton.Image = null;
            this.txtDisclaimer.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtDisclaimer.CustomButton.Name = "";
            this.txtDisclaimer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDisclaimer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDisclaimer.CustomButton.TabIndex = 1;
            this.txtDisclaimer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDisclaimer.CustomButton.UseSelectable = true;
            this.txtDisclaimer.CustomButton.Visible = false;
            this.txtDisclaimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDisclaimer.Lines = new string[] {
        "metroTextBox1"};
            this.txtDisclaimer.Location = new System.Drawing.Point(0, 0);
            this.txtDisclaimer.MaxLength = 32767;
            this.txtDisclaimer.Multiline = true;
            this.txtDisclaimer.Name = "txtDisclaimer";
            this.txtDisclaimer.PasswordChar = '\0';
            this.txtDisclaimer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDisclaimer.SelectedText = "";
            this.txtDisclaimer.SelectionLength = 0;
            this.txtDisclaimer.SelectionStart = 0;
            this.txtDisclaimer.ShortcutsEnabled = true;
            this.txtDisclaimer.Size = new System.Drawing.Size(833, 526);
            this.txtDisclaimer.TabIndex = 2;
            this.txtDisclaimer.Text = "metroTextBox1";
            this.txtDisclaimer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtDisclaimer.UseSelectable = true;
            this.txtDisclaimer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDisclaimer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Disclaimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDisclaimer);
            this.Name = "Disclaimer";
            this.Size = new System.Drawing.Size(833, 526);
            this.pnlDisclaimer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlDisclaimer;
        private MetroFramework.Controls.MetroTextBox txtDisclaimer;
    }
}
