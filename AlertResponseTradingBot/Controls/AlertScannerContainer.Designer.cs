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
            this.btnAddNew = new FontAwesome.Sharp.IconButton();
            this.ddlPlugin = new MetroFramework.Controls.MetroComboBox();
            this.pnlTabControls = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRemoveSelectedTab = new FontAwesome.Sharp.IconButton();
            this.pnlTopControls.SuspendLayout();
            this.pnlTabControls.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopControls
            // 
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
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(151, 3);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Padding = new System.Windows.Forms.Padding(10);
            this.btnAddNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddNew.Rotation = 0D;
            this.btnAddNew.Size = new System.Drawing.Size(64, 53);
            this.btnAddNew.TabIndex = 20;
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNew.UseVisualStyleBackColor = false;
            // 
            // ddlPlugin
            // 
            this.ddlPlugin.FormattingEnabled = true;
            this.ddlPlugin.ItemHeight = 23;
            this.ddlPlugin.Location = new System.Drawing.Point(14, 14);
            this.ddlPlugin.Name = "ddlPlugin";
            this.ddlPlugin.Size = new System.Drawing.Size(121, 29);
            this.ddlPlugin.TabIndex = 2;
            this.ddlPlugin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ddlPlugin.UseSelectable = true;
            // 
            // pnlTabControls
            // 
            this.pnlTabControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTabControls.Controls.Add(this.metroTabControl1);
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
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1063, 561);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 41);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1055, 516);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
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
            this.btnRemoveSelectedTab.Padding = new System.Windows.Forms.Padding(10);
            this.btnRemoveSelectedTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRemoveSelectedTab.Rotation = 0D;
            this.btnRemoveSelectedTab.Size = new System.Drawing.Size(64, 58);
            this.btnRemoveSelectedTab.TabIndex = 21;
            this.btnRemoveSelectedTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveSelectedTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveSelectedTab.UseVisualStyleBackColor = false;
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
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlTopControls;
        private MetroFramework.Controls.MetroPanel pnlTabControls;
        private MetroFramework.Controls.MetroComboBox ddlPlugin;
        private FontAwesome.Sharp.IconButton btnAddNew;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private FontAwesome.Sharp.IconButton btnRemoveSelectedTab;
    }
}
