namespace TradeAlertResponder.Controls
{
    partial class AlertActionPluginContainer
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
            this.pnlBackground = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pnlTitle = new MetroFramework.Controls.MetroPanel();
            this.pnlControlContainer = new MetroFramework.Controls.MetroPanel();
            this.pnlBackground.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.Controls.Add(this.pnlControlContainer);
            this.pnlBackground.Controls.Add(this.pnlTitle);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.HorizontalScrollbarBarColor = true;
            this.pnlBackground.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlBackground.HorizontalScrollbarSize = 10;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(790, 547);
            this.pnlBackground.TabIndex = 0;
            this.pnlBackground.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlBackground.VerticalScrollbarBarColor = true;
            this.pnlBackground.VerticalScrollbarHighlightOnWheel = false;
            this.pnlBackground.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(4, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(183, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Alert Action Plugins";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.metroLabel1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.HorizontalScrollbarBarColor = true;
            this.pnlTitle.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlTitle.HorizontalScrollbarSize = 10;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(790, 37);
            this.pnlTitle.TabIndex = 3;
            this.pnlTitle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlTitle.VerticalScrollbarBarColor = true;
            this.pnlTitle.VerticalScrollbarHighlightOnWheel = false;
            this.pnlTitle.VerticalScrollbarSize = 10;
            // 
            // pnlControlContainer
            // 
            this.pnlControlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControlContainer.HorizontalScrollbarBarColor = true;
            this.pnlControlContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlControlContainer.HorizontalScrollbarSize = 10;
            this.pnlControlContainer.Location = new System.Drawing.Point(0, 37);
            this.pnlControlContainer.Name = "pnlControlContainer";
            this.pnlControlContainer.Size = new System.Drawing.Size(790, 510);
            this.pnlControlContainer.TabIndex = 4;
            this.pnlControlContainer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlControlContainer.VerticalScrollbarBarColor = true;
            this.pnlControlContainer.VerticalScrollbarHighlightOnWheel = false;
            this.pnlControlContainer.VerticalScrollbarSize = 10;
            // 
            // AlertActionPluginContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBackground);
            this.Name = "AlertActionPluginContainer";
            this.Size = new System.Drawing.Size(790, 547);
            this.pnlBackground.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlBackground;
        private MetroFramework.Controls.MetroPanel pnlTitle;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel pnlControlContainer;
    }
}
