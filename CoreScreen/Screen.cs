﻿using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoreScreen
{
    public class Screen
    {
        ChromeDriverService service = ChromeDriverService.CreateDefaultService();

        ChromeOptions MyChromeOptions = new ChromeOptions();

        ChromeDriver driver;

        bool LoadedFine = true;

        public Screen()
        {

            service.HideCommandPromptWindow = true;

            MyChromeOptions.AddArgument("--window-size=1920,1080");
            MyChromeOptions.AddArgument("headless");

            try
            {
                driver = new ChromeDriver(service, MyChromeOptions);
            }
            catch (Exception ex)
            {
                LoadedFine = false;
            }

        }

        public async Task QuitChrome()
        {
            driver.Quit();
        }

        public async Task<ScreenshotResult> Screenshot(string URL, string DirectoryPath, bool IncludeLogoWatermark, string WatermarkFilePath, Point CropStartPoint, Size CropSize, bool DoCropImage)
        {
            if (LoadedFine)
            {
                try
                {

                    string ImagePath = DirectoryPath + "Screenshot-" + DateTime.UtcNow.Month.ToString() + "-" + DateTime.UtcNow.Day.ToString() + "-" + DateTime.UtcNow.Year.ToString() + "-" + DateTime.UtcNow.Hour.ToString() + "h" + DateTime.UtcNow.Minute.ToString() + "m" + DateTime.UtcNow.Second.ToString() + "s.png";

                    driver.Navigate()
                        .GoToUrl(URL);

                    Thread.Sleep(3000);

                    var bytearray = driver.GetScreenshot().AsByteArray;

                    //driver.Quit();

                    Bitmap bmp;
                    using (var ms = new MemoryStream(bytearray))
                    {
                        bmp = new Bitmap(ms);
                    }

                    Bitmap CroppedImage;
                    if(DoCropImage)
                    {
                        Rectangle section = new Rectangle(CropStartPoint, CropSize);
                        CroppedImage = CropImage(bmp, section);
                    }
                    else
                    {
                        CroppedImage = bmp;
                    }

                    if(IncludeLogoWatermark)
                    {
                        Bitmap Logo;

                        if(WatermarkFilePath != "")
                        {
                            if (File.Exists(WatermarkFilePath))
                            {
                                Logo = new Bitmap(WatermarkFilePath);
                            }
                            else
                            {
                                Logo = Properties.Resources.Watermark;
                            }
                        }
                        else
                        {
                            Logo = Properties.Resources.Watermark;
                        }
                        

                        Bitmap FinalLogo = ResizeBitmap(Logo, Logo.Width / 3, Logo.Height / 3);


                        Graphics gCroppedImage = Graphics.FromImage(CroppedImage);
                        gCroppedImage.DrawImage(FinalLogo, CroppedImage.Width / 2 - FinalLogo.Width / 2, 70, new Rectangle(0, 0, FinalLogo.Width, FinalLogo.Height), GraphicsUnit.Pixel);

                        CroppedImage.Save(ImagePath, ImageFormat.Png);

                        gCroppedImage.Dispose();
                        FinalLogo.Dispose();
                        Logo.Dispose();
                    }
                    else
                    {

                        CroppedImage.Save(ImagePath, ImageFormat.Png);
                    }

                    CroppedImage.Dispose();
                    bmp.Dispose();

                    return new ScreenshotResult(true, ImagePath);
                }
                catch (Exception ex)
                {
                    return new ScreenshotResult(false, "");
                }
            }
            else
            {
                return new ScreenshotResult(false, "");
            }


        }

        public Bitmap CropImage(Bitmap source, Rectangle section)
        {
            var bitmap = new Bitmap(section.Width, section.Height);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);
                return bitmap;
            }
        }

        public Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }

            return result;
        }

        public class ScreenshotResult
        {
            public bool Succeeded = false;
            public string ImageFilePath = "";

            public ScreenshotResult(bool _Succeed, string _ImageFilePath)
            {
                Succeeded = _Succeed;
                ImageFilePath = _ImageFilePath;
            }
        }


    }
}