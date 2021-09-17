﻿using System;
using System.Drawing;
using System.IO;

class ImageProcessor
{
    public static void Inverse(string[] filenames)
    {
        foreach (string filename in filenames)
        {
            Bitmap bitmap = new Bitmap(filename);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color color = bitmap.GetPixel(x, y);
                    color = Color.FromArgb(255, (255 - color.R), (255 - color.G), (255 - color.B));
                    bitmap.SetPixel(x, y, color);
                }
            }
            string new_filename = Path.GetFileNameWithoutExtension(filename) + "_inverse" + Path.GetExtension(filename);
            bitmap.Save(new_filename);
        }
    }

    public static void Grayscale(string[] filenames)
    {
        foreach (string filename in filenames)
        {
            Bitmap bitmap = new Bitmap(filename);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color color = bitmap.GetPixel(x, y);
                    int grayScale = (int)((color.R * 0.3) + (color.G * 0.59) + (color.B * 0.11));
                    color = Color.FromArgb(255, grayScale, grayScale, grayScale);
                    bitmap.SetPixel(x, y, color);
                }
            }
            string new_filename = Path.GetFileNameWithoutExtension(filename) + "_grayscale" + Path.GetExtension(filename);
            bitmap.Save(new_filename);
        }
    }

}
