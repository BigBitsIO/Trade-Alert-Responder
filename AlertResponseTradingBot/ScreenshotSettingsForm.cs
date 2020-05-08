using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace TradeAlertResponder
{
    public partial class ScreenshotSettingsForm : MetroForm
    {

        private ScreenshotSettings ScreenshotSettings = new ScreenshotSettings();

        public ScreenshotSettingsForm(ref ScreenshotSettings _ScreenshotSettings)
        {
            InitializeComponent();

            if (_ScreenshotSettings != null)
            {
                ScreenshotSettings = _ScreenshotSettings;

                tglCropImage.Checked = ScreenshotSettings.DoCropImage;
                tglWatermarkImage.Checked = ScreenshotSettings.IncludeLogoWatermark;
                txtCropStartPointX.Text = ScreenshotSettings.CropStartPoint.X.ToString();
                txtCropStartPointY.Text = ScreenshotSettings.CropStartPoint.Y.ToString();
                txtCropSizeWidth.Text = ScreenshotSettings.CropSize.Width.ToString();
                txtCropSizeHeight.Text = ScreenshotSettings.CropSize.Height.ToString();
            }
        }

        private void btnValidateAndSave_Click(object sender, EventArgs e)
        {
            try
            {
                ScreenshotSettings.DoCropImage = tglCropImage.Checked;
                ScreenshotSettings.IncludeLogoWatermark = tglWatermarkImage.Checked;
                ScreenshotSettings.CropStartPoint = new Point(Convert.ToInt32(txtCropStartPointX.Text), Convert.ToInt32(txtCropStartPointY.Text));
                ScreenshotSettings.CropSize = new Size(Convert.ToInt32(txtCropSizeWidth.Text), Convert.ToInt32(txtCropSizeHeight.Text));

                FileHelper.ExportScreenshotSettings(ScreenshotSettings).GetAwaiter().GetResult();

                lblResult.Text = "Saved.";
            }
            catch(Exception ex)
            {
                lblResult.Text = "Failed to save.";
            }
            
        }

    }
}
