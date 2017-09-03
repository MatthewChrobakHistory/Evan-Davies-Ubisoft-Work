using System;
using System.IO;
using System.Drawing;
using System.Linq;

namespace UbisoftSplitter
{
    class Program
    {
        static void Main(string[] args) {

            string path = AppDomain.CurrentDomain.BaseDirectory;
            string folder = path + "\\input\\";
            string output = path + "\\output\\";
            const int startY = 145;
            const int startX = 48;
            const int finishX = 566;
            const int finishY = startY + 360;
            int count = 0;


            foreach (var file in Directory.GetFiles(folder)) {
                var fi = new FileInfo(file);
                var bmp = new Bitmap(Image.FromFile(file));
                var obmp = new Bitmap(finishX - startX, finishY - startY);

                for (int x = startX; x < finishX; x++) {
                    for (int y = startY; y < finishY; y++) {
                        var color = bmp.GetPixel(x, y);
                        obmp.SetPixel(x - startX, y - startY, color);
                    }
                }

                obmp.Save(output + fi.Name + ".png");
            }
        }
    }
}
