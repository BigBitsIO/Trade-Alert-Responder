namespace TradeAlertResponder.Controls
{
    partial class AlertScannerContainer
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
            this.pnlTopControls = new MetroFramework.Controls.MetroPanel();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnRemoveSelectedTab = new FontAwesome.Sharp.IconButton();
            this.btnAddNew = new FontAwesome.Sharp.IconButton();
            this.ddlPlugin = new MetroFramework.Controls.MetroComboBox();
            this.pnlTabControls = new MetroFramework.Controls.MetroPanel();
            this.tabControlAlertScanners = new MetroFramework.Controls.MetroTabControl();
            this.pnlTopControls.SuspendLayout();
            this.pnlTabControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopControls
            // 
            this.pnlTopControls.Controls.Add(this.btnSettings);
            this.pnlTopControls.Controls.Add(this.btnRemoveSelectedTab);
            this.pnlTopControls.Controls.Add(this.btnAddNew);
            this.pnlTopControls.Controls.Add(this.ddlPlugin);
            this.pnlTopControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopControls.HorizontalScrollbarBarColor = true;
            this.pnlTopControls.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlTopControls.HorizontalScrollbarSize = 10;
            this.pnlTopControls.Location = new System.Drawing.Point(0, 0);
            this.pnlTopControls.Name = "pnlTopControls";
            this.pnlTopControls.Size = new System.Drawing.Size(1063, 58);
            this.pnlTopControls.TabIndex = 0;
            this.pnlTopControls.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlTopControls.VerticalScrollbarBarColor = true;
            this.pnlTopControls.VerticalScrollbarHighlightOnWheel = false;
            this.pnlTopControls.VerticalScrollbarSize = 10;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnSettings.IconColor = System.Drawing.Color.White;
            this.btnSettings.IconSize = 35;
            this.btnSettings.Location = new System.Drawing.Point(360, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.btnSettings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSettings.Rotation = 0D;
            this.btnSettings.Size = new System.Drawing.Size(64, 53);
            this.btnSettings.TabIndex = 22;
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnRemoveSelectedTab
            // 
            this.btnRemoveSelectedTab.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveSelectedTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveSelectedTab.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemoveSelectedTab.FlatAppearance.BorderSize = 0;
            this.btnRemoveSelectedTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRemoveSelectedTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRemoveSelectedTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelectedTab.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRemoveSelectedTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSelectedTab.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSelectedTab.IconChar = FontAwesome.Sharp.IconChar.MinusSquare;
            this.btnRemoveSelectedTab.IconColor = System.Drawing.Color.White;
            this.btnRemoveSelectedTab.IconSize = 35;
            this.btnRemoveSelectedTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveSelectedTab.Location = new System.Drawing.Point(999, 0);
            this.btnRemoveSelectedTab.Name = "btnRemoveSelectedTab";
            this.btnRemoveSelectedTab.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.btnRemoveSelectedTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRemoveSelectedTab.Rotation = 0D;
            this.btnRemoveSelectedTab.Size = new System.Drawing.Size(64, 58);
            this.btnRemoveSelectedTab.TabIndex = 21;
            this.btnRemoveSelectedTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveSelectedTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveSelectedTab.UseVisualStyleBackColor = false;
            this.btnRemoveSelectedTab.Click += new System.EventHandler(this.btnRemoveSelectedTab_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAddNew.IconColor = System.Drawing.Color.White;
            this.btnAddNew.IconSize = 35;
            this.btnAddNew.Location = new System.Drawing.Point(290, 3);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.btnAddNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddNew.Rotation = 0D;
            this.btnAddNew.Size = new System.Drawing.Size(64, 53);
            this.btnAddNew.TabIndex = 20;
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // ddlPlugin
            // 
            this.ddlPlugin.FormattingEnabled = true;
            this.ddlPlugin.ItemHeight = 23;
            this.ddlPlugin.Location = new System.Drawing.Point(17, 14);
            this.ddlPlugin.Name = "ddlPlugin";
            this.ddlPlugin.Size = new System.Drawing.Size(257, 29);
            this.ddlPlugin.TabIndex = 2;
            this.ddlPlugin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ddlPlugin.UseSelectable = true;
            // 
            // pnlTabControls
            // 
            this.pnlTabControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTabControls.Controls.Add(this.tabControlAlertScanners);
            this.pnlTabControls.HorizontalScrollbarBarColor = true;
            this.pnlTabControls.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlTabControls.HorizontalScrollbarSize = 10;
            this.pnlTabControls.Location = new System.Drawing.Point(0, 58);
            this.pnlTabControls.Name = "pnlTabControls";
            this.pnlTabControls.Size = new System.Drawing.Size(1063, 561);
            this.pnlTabControls.TabIndex = 1;
            this.pnlTabControls.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlTabControls.VerticalScrollbarBarColor = true;
            this.pnlTabControls.VerticalScrollbarHighlightOnWheel = false;
            this.pnlTabControls.VerticalScrollbarSize = 10;
            // 
            // tabControlAlertScanners
            // 
            this.tabControlAlertScanners.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlAlertScanners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAlertScanners.Location = new System.Drawing.Point(0, 0);
            this.tabControlAlertScanners.Name = "tabControlAlertScanners";
            this.tabControlAlertScanners.Size = new System.Drawing.Size(1063, 561);
            this.tabControlAlertScanners.TabIndex = 2;
            this.tabControlAlertScanners.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabControlAlertScanners.UseSelectable = true;
            // 
            // AlertScannerContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTabControls);
            this.Controls.Add(this.pnlTopControls);
            this.Name = "AlertScannerContainer";
            this.Size = new System.Drawing.Size(1063, 619);
            this.pnlTopControls.ResumeLayout(false);
            this.pnlTabControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlTopControls;
        private MetroFramework.Controls.MetroPanel pnlTabControls;
        private MetroFramework.Controls.MetroComboBox ddlPlugin;
        private FontAwesome.Sharp.IconButton btnAddNew;
        private MetroFramework.Controls.MetroTabControl tabControlAlertScanners;
        private FontAwesome.Sharp.IconButton btnRemoveSelectedTab;
        private FontAwesome.Sharp.IconButton btnSettings;
    }
}
