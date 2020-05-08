namespace TradeAlertResponder
{
    partial class ScreenshotSettingsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnValidateAndSave = new MetroFramework.Controls.MetroButton();
            this.lblResult = new MetroFramework.Controls.MetroLabel();
            this.tglWatermarkImage = new MetroFramework.Controls.MetroToggle();
            this.lblWatermarkImage = new MetroFramework.Controls.MetroLabel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.tglCropImage = new MetroFramework.Controls.MetroToggle();
            this.lblDiscordOnScreenshot = new MetroFramework.Controls.MetroLabel();
            this.lblCropStartPoint = new MetroFramework.Controls.MetroLabel();
            this.lblCropSize = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtCropStartPointX = new MetroFramework.Controls.MetroTextBox();
            this.txtCropStartPointY = new MetroFramework.Controls.MetroTextBox();
            this.txtCropSizeHeight = new MetroFramework.Controls.MetroTextBox();
            this.txtCropSizeWidth = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValidateAndSave
            // 
            this.btnValidateAndSave.Location = new System.Drawing.Point(82, 293);
            this.btnValidateAndSave.Name = "btnValidateAndSave";
            this.btnValidateAndSave.Size = new System.Drawing.Size(75, 23);
            this.btnValidateAndSave.TabIndex = 6;
            this.btnValidateAndSave.Text = "Save";
            this.btnValidateAndSave.UseSelectable = true;
            this.btnValidateAndSave.Click += new System.EventHandler(this.btnValidateAndSave_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(167, 297);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 0);
            this.lblResult.TabIndex = 7;
            // 
            // tglWatermarkImage
            // 
            this.tglWatermarkImage.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglWatermarkImage.AutoSize = true;
            this.tglWatermarkImage.DisplayStatus = false;
            this.tglWatermarkImage.Enabled = false;
            this.tglWatermarkImage.Location = new System.Drawing.Point(163, 255);
            this.tglWatermarkImage.Name = "tglWatermarkImage";
            this.tglWatermarkImage.Size = new System.Drawing.Size(50, 23);
            this.tglWatermarkImage.TabIndex = 16;
            this.tglWatermarkImage.Text = "Off";
            this.tglWatermarkImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglWatermarkImage.UseSelectable = true;
            // 
            // lblWatermarkImage
            // 
            this.lblWatermarkImage.AutoSize = true;
            this.lblWatermarkImage.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblWatermarkImage.Location = new System.Drawing.Point(23, 256);
            this.lblWatermarkImage.Name = "lblWatermarkImage";
            this.lblWatermarkImage.Size = new System.Drawing.Size(134, 19);
            this.lblWatermarkImage.TabIndex = 15;
            this.lblWatermarkImage.Text = "Watermark Image:";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconSize = 60;
            this.iconPictureBox2.Location = new System.Drawing.Point(241, 11);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(69, 60);
            this.iconPictureBox2.TabIndex = 24;
            this.iconPictureBox2.TabStop = false;
            // 
            // tglCropImage
            // 
            this.tglCropImage.Appearance = System.Windows.Forms.Appearance.Button;
            this.tglCropImage.AutoSize = true;
            this.tglCropImage.DisplayStatus = false;
            this.tglCropImage.Location = new System.Drawing.Point(163, 86);
            this.tglCropImage.Name = "tglCropImage";
            this.tglCropImage.Size = new System.Drawing.Size(50, 23);
            this.tglCropImage.TabIndex = 28;
            this.tglCropImage.Text = "Off";
            this.tglCropImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglCropImage.UseSelectable = true;
            // 
            // lblDiscordOnScreenshot
            // 
            this.lblDiscordOnScreenshot.AutoSize = true;
            this.lblDiscordOnScreenshot.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDiscordOnScreenshot.Location = new System.Drawing.Point(65, 86);
            this.lblDiscordOnScreenshot.Name = "lblDiscordOnScreenshot";
            this.lblDiscordOnScreenshot.Size = new System.Drawing.Size(92, 19);
            this.lblDiscordOnScreenshot.TabIndex = 27;
            this.lblDiscordOnScreenshot.Text = "Crop Image:";
            // 
            // lblCropStartPoint
            // 
            this.lblCropStartPoint.AutoSize = true;
            this.lblCropStartPoint.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCropStartPoint.Location = new System.Drawing.Point(77, 122);
            this.lblCropStartPoint.Name = "lblCropStartPoint";
            this.lblCropStartPoint.Size = new System.Drawing.Size(80, 19);
            this.lblCropStartPoint.TabIndex = 29;
            this.lblCropStartPoint.Text = "Start Point";
            // 
            // lblCropSize
            // 
            this.lblCropSize.AutoSize = true;
            this.lblCropSize.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCropSize.Location = new System.Drawing.Point(84, 183);
            this.lblCropSize.Name = "lblCropSize";
            this.lblCropSize.Size = new System.Drawing.Size(73, 19);
            this.lblCropSize.TabIndex = 30;
            this.lblCropSize.Text = "Crop Size";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(158, 151);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(22, 19);
            this.metroLabel1.TabIndex = 31;
            this.metroLabel1.Text = "X:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(306, 151);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(22, 19);
            this.metroLabel2.TabIndex = 32;
            this.metroLabel2.Text = "Y:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(127, 213);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 33;
            this.metroLabel3.Text = "Width:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(270, 213);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 19);
            this.metroLabel4.TabIndex = 34;
            this.metroLabel4.Text = "Height:";
            // 
            // txtCropStartPointX
            // 
            // 
            // 
            // 
            this.txtCropStartPointX.CustomButton.Image = null;
            this.txtCropStartPointX.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtCropStartPointX.CustomButton.Name = "";
            this.txtCropStartPointX.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCropStartPointX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCropStartPointX.CustomButton.TabIndex = 1;
            this.txtCropStartPointX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCropStartPointX.CustomButton.UseSelectable = true;
            this.txtCropStartPointX.CustomButton.Visible = false;
            this.txtCropStartPointX.Lines = new string[0];
            this.txtCropStartPointX.Location = new System.Drawing.Point(186, 151);
            this.txtCropStartPointX.MaxLength = 32767;
            this.txtCropStartPointX.Name = "txtCropStartPointX";
            this.txtCropStartPointX.PasswordChar = '\0';
            this.txtCropStartPointX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCropStartPointX.SelectedText = "";
            this.txtCropStartPointX.SelectionLength = 0;
            this.txtCropStartPointX.SelectionStart = 0;
            this.txtCropStartPointX.ShortcutsEnabled = true;
            this.txtCropStartPointX.Size = new System.Drawing.Size(75, 23);
            this.txtCropStartPointX.TabIndex = 35;
            this.txtCropStartPointX.UseSelectable = true;
            this.txtCropStartPointX.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCropStartPointX.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCropStartPointY
            // 
            // 
            // 
            // 
            this.txtCropStartPointY.CustomButton.Image = null;
            this.txtCropStartPointY.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtCropStartPointY.CustomButton.Name = "";
            this.txtCropStartPointY.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCropStartPointY.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCropStartPointY.CustomButton.TabIndex = 1;
            this.txtCropStartPointY.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCropStartPointY.CustomButton.UseSelectable = true;
            this.txtCropStartPointY.CustomButton.Visible = false;
            this.txtCropStartPointY.Lines = new string[0];
            this.txtCropStartPointY.Location = new System.Drawing.Point(334, 151);
            this.txtCropStartPointY.MaxLength = 32767;
            this.txtCropStartPointY.Name = "txtCropStartPointY";
            this.txtCropStartPointY.PasswordChar = '\0';
            this.txtCropStartPointY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCropStartPointY.SelectedText = "";
            this.txtCropStartPointY.SelectionLength = 0;
            this.txtCropStartPointY.SelectionStart = 0;
            this.txtCropStartPointY.ShortcutsEnabled = true;
            this.txtCropStartPointY.Size = new System.Drawing.Size(75, 23);
            this.txtCropStartPointY.TabIndex = 36;
            this.txtCropStartPointY.UseSelectable = true;
            this.txtCropStartPointY.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCropStartPointY.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCropSizeHeight
            // 
            // 
            // 
            // 
            this.txtCropSizeHeight.CustomButton.Image = null;
            this.txtCropSizeHeight.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtCropSizeHeight.CustomButton.Name = "";
            this.txtCropSizeHeight.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCropSizeHeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCropSizeHeight.CustomButton.TabIndex = 1;
            this.txtCropSizeHeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCropSizeHeight.CustomButton.UseSelectable = true;
            this.txtCropSizeHeight.CustomButton.Visible = false;
            this.txtCropSizeHeight.Lines = new string[0];
            this.txtCropSizeHeight.Location = new System.Drawing.Point(334, 213);
            this.txtCropSizeHeight.MaxLength = 32767;
            this.txtCropSizeHeight.Name = "txtCropSizeHeight";
            this.txtCropSizeHeight.PasswordChar = '\0';
            this.txtCropSizeHeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCropSizeHeight.SelectedText = "";
            this.txtCropSizeHeight.SelectionLength = 0;
            this.txtCropSizeHeight.SelectionStart = 0;
            this.txtCropSizeHeight.ShortcutsEnabled = true;
            this.txtCropSizeHeight.Size = new System.Drawing.Size(75, 23);
            this.txtCropSizeHeight.TabIndex = 38;
            this.txtCropSizeHeight.UseSelectable = true;
            this.txtCropSizeHeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCropSizeHeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCropSizeWidth
            // 
            // 
            // 
            // 
            this.txtCropSizeWidth.CustomButton.Image = null;
            this.txtCropSizeWidth.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtCropSizeWidth.CustomButton.Name = "";
            this.txtCropSizeWidth.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCropSizeWidth.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCropSizeWidth.CustomButton.TabIndex = 1;
            this.txtCropSizeWidth.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCropSizeWidth.CustomButton.UseSelectable = true;
            this.txtCropSizeWidth.CustomButton.Visible = false;
            this.txtCropSizeWidth.Lines = new string[0];
            this.txtCropSizeWidth.Location = new System.Drawing.Point(186, 213);
            this.txtCropSizeWidth.MaxLength = 32767;
            this.txtCropSizeWidth.Name = "txtCropSizeWidth";
            this.txtCropSizeWidth.PasswordChar = '\0';
            this.txtCropSizeWidth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCropSizeWidth.SelectedText = "";
            this.txtCropSizeWidth.SelectionLength = 0;
            this.txtCropSizeWidth.SelectionStart = 0;
            this.txtCropSizeWidth.ShortcutsEnabled = true;
            this.txtCropSizeWidth.Size = new System.Drawing.Size(75, 23);
            this.txtCropSizeWidth.TabIndex = 37;
            this.txtCropSizeWidth.UseSelectable = true;
            this.txtCropSizeWidth.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCropSizeWidth.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ScreenshotSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 339);
            this.Controls.Add(this.txtCropSizeHeight);
            this.Controls.Add(this.txtCropSizeWidth);
            this.Controls.Add(this.txtCropStartPointY);
            this.Controls.Add(this.txtCropStartPointX);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblCropSize);
            this.Controls.Add(this.lblCropStartPoint);
            this.Controls.Add(this.tglCropImage);
            this.Controls.Add(this.lblDiscordOnScreenshot);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.tglWatermarkImage);
            this.Controls.Add(this.lblWatermarkImage);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnValidateAndSave);
            this.Name = "ScreenshotSettingsForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Screenshot Settings";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnValidateAndSave;
        private MetroFramework.Controls.MetroLabel lblResult;
        private MetroFramework.Controls.MetroToggle tglWatermarkImage;
        private MetroFramework.Controls.MetroLabel lblWatermarkImage;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private MetroFramework.Controls.MetroToggle tglCropImage;
        private MetroFramework.Controls.MetroLabel lblDiscordOnScreenshot;
        private MetroFramework.Controls.MetroLabel lblCropStartPoint;
        private MetroFramework.Controls.MetroLabel lblCropSize;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtCropStartPointX;
        private MetroFramework.Controls.MetroTextBox txtCropStartPointY;
        private MetroFramework.Controls.MetroTextBox txtCropSizeHeight;
        private MetroFramework.Controls.MetroTextBox txtCropSizeWidth;
    }
}