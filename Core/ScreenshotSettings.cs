using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ScreenshotSettings
    {
        public bool IncludeLogoWatermark { get; set; } = false;

        public bool DoCropImage { get; set; } = true;
        public Point CropStartPoint { get; set; } = new Point(57,40);
        public Size CropSize { get; set; } = new Size(1540, 994);
    }
}
