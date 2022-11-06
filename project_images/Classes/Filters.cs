using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_images.Classes
{
    internal class Filters
    {
      public Filters() { 

        }

        public Bitmap GrayScales(Bitmap original) {

            Bitmap newBitmap = original;
            for (int i = 0; i < newBitmap.Width; i++) {
                for (int y = 0; y < newBitmap.Height; y++) { 
                    Color color = newBitmap.GetPixel(i, y);
                    int red1 = color.R;
                    int green1 = color.G;
                    int blue1 = color.B;
                    int gray = (byte)(.299 * red1 + .587 * green1 + .114 * blue1);
                    red1 = gray;
                    green1 = gray;
                    blue1 = gray;
                    newBitmap.SetPixel(i, y, Color.FromArgb(gray, gray, gray));
                }
            }
            return newBitmap;
        }

        public Bitmap Invert(Image img) {
            Bitmap invertedImg = new Bitmap(img.Width, img.Height);
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMatrix colorMatrix = new ColorMatrix(
                    new float[][]
                {
                new float[]{-1, 0, 0, 0, 0},
                new float[]{0, -1, 0, 0, 0},
                new float[]{0, 0, -1, 0, 0},
                new float[]{0, 0, 0, 1, 0},
                new float[]{1, 1, 1, 0, 1}
                });
            imageAttributes.SetColorMatrix(colorMatrix);
            Graphics graphics=Graphics.FromImage(invertedImg);
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

        public Bitmap ColorRed(Image img) {
            Bitmap invertedImg = new Bitmap(img.Width, img.Height);
            ImageAttributes imageAttributes= new ImageAttributes(); 
            ColorMatrix colorMatrix= new ColorMatrix(new float[][]
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

        public Bitmap Brightness(Image img) { 
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

        public Bitmap Binary(Bitmap original) {
            Bitmap newBitmap = original;
            for (int i = 0; i < newBitmap.Width; i++) {
                for (int y = 0; y < newBitmap.Height; y++) { 
                    Color color=original.GetPixel(i, y);
                    int red = color.R;
                    int green = color.G;
                    int blue = color.B;
                    int gray=(byte)(.299 * red + .587 * green + .114 * blue);
                    if (gray <= 125) gray = 0;
                    else gray = 255;
                    newBitmap.SetPixel(i, y, Color.FromArgb(gray, gray, gray));
                }
            }
            return newBitmap;
        }

    }
}
