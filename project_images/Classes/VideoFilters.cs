using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_images.Classes
{
    internal class VideoFilters
    {
        public Bitmap GrayScales(Bitmap img) { 
            Bitmap bitmap = new Bitmap(img);
            unsafe 
            { 
                Rectangle rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
                BitmapData bitmapData = bitmap.LockBits(rectangle,
                                                      ImageLockMode.ReadWrite,
                                                      bitmap.PixelFormat);
                int bytesPerPixel = Image.GetPixelFormatSize(bitmap.PixelFormat) / 8;
                int heightInPixels = bitmap.Height;
                int widthInPixels = bitmap.Width;
                byte* firstPixel = (byte*)bitmapData.Scan0;
                Parallel.For(0, heightInPixels, y =>
                {
                    byte* currentLine = firstPixel + (y * bitmapData.Stride);
                    for (int x = 0; x < widthInPixels; x = x + bytesPerPixel) {
                        int oldBlue = currentLine[x];
                        int oldGreen = currentLine[x + 1];
                        int oldRed= currentLine[x + 2];
                        int gray=(byte)(.299 * oldRed + .587 * oldGreen + .114 * oldBlue);
                        currentLine[x] = (byte)gray;
                        currentLine[x + 1] = (byte)gray;
                        currentLine[x + 2] = (byte)gray;
                    }
                });
                bitmap.UnlockBits(bitmapData);
            }

            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawImage(bitmap,
                               new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                               0,
                               0,
                               bitmap.Width,
                               bitmap.Height,
                               GraphicsUnit.Pixel);
            return bitmap;
        }

        public Bitmap Invert(Image img) {
            Bitmap bitmap = new Bitmap(img.Width, img.Height);
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMatrix colorMatrix = new ColorMatrix(new float[][] {
                new float[]{-1, 0, 0, 0, 0},
                new float[]{0, -1, 0, 0, 0},
                new float[]{0, 0, -1, 0, 0},
                new float[]{0, 0, 0, 1, 0},
                new float[]{1, 1, 1, 0, 1}
            });
            imageAttributes.SetColorMatrix(colorMatrix);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawImage(img,
                               new Rectangle(0, 0, img.Width, img.Height),
                               0, 0,
                               img.Width,
                               img.Height,
                               GraphicsUnit.Pixel,
                               imageAttributes);
            graphics.Dispose();
            return bitmap;
        }

        public Bitmap ColorRed(Image img) {
            Bitmap invertedImg = new Bitmap(img.Width, img.Height);
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMatrix colorMatrix = new ColorMatrix(new float[][]
            {
                new float[]{1, 0, 0, 0, 0},
                new float[]{0, 0, 0, 0, 0},
                new float[]{0, 0, 0, 0, 0},
                new float[]{0, 0, 0, 1, 0},
                new float[]{0, 0, 0, 0, 1}
            });
            imageAttributes.SetColorMatrix(colorMatrix);
            Graphics graphics = Graphics.FromImage(invertedImg);
            graphics.DrawImage(img,
                               new Rectangle(0, 0, img.Width, img.Height),
                               0,
                               0,
                               img.Width,
                               img.Height,
                               GraphicsUnit.Pixel,
                               imageAttributes);
            graphics.Dispose();
            return invertedImg;
        }

        public Bitmap Brightness(Image img)
        {
            Bitmap bitmap = new Bitmap(img.Width, img.Height);
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMatrix colorMatrix = new ColorMatrix(new float[][]
            {
                new float[]{1, 0, 0, 0, 0},
                new float[]{0, 1, 0, 0, 0},
                new float[]{0, 0, 1, 0, 0},
                new float[]{0, 0, 0, 1, 0},
                new float[]{.5f, .5f, .5f, 0, 1}
            });
            imageAttributes.SetColorMatrix(colorMatrix);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawImage(img,
                               new Rectangle(0, 0, img.Width, img.Height),
                               0,
                               0,
                               img.Width,
                               img.Height,
                               GraphicsUnit.Pixel,
                               imageAttributes);
            graphics.Dispose();
            return bitmap;
        }

        public Bitmap Binary(Image img) {
            Bitmap bitmap = new Bitmap(img);
            unsafe {
                Rectangle rectangle= new Rectangle(0, 0, img.Width, img.Height);
                BitmapData bitmapData = bitmap.LockBits(rectangle, ImageLockMode.ReadWrite, bitmap.PixelFormat);
                int bytesPerPixel = Image.GetPixelFormatSize(bitmap.PixelFormat) / 8;
                int heightInPixels = bitmap.Height;
                int widthInPixels = bitmap.Width*bytesPerPixel;
                byte* firstPixel = (byte*)bitmapData.Scan0;
                Parallel.For(0, heightInPixels, y =>
                {
                    byte* currentLine = firstPixel + (y * bitmapData.Stride);
                    for (int x = 0; x < widthInPixels; x = x + bytesPerPixel)
                    {
                        int oldBlue = currentLine[x];
                        int oldGreen = currentLine[x+1];
                        int oldRed= currentLine[x+2];
                        int gray = (byte)(.299 * oldRed + .587 * oldGreen + .114 * oldBlue);
                        if (gray <= 125) gray = 0;
                        else gray = 255;
                        currentLine[x] = (byte)gray;
                        currentLine[x + 1] = (byte)gray;
                        currentLine[x + 2] = (byte)gray;
                    }
                });
                bitmap.UnlockBits(bitmapData);
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.DrawImage(bitmap,
                                   new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                                   0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel);
                return bitmap;
            }
        } 

    }
}
