using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubisoft
{
    class Program
    {
        static void Main(string[] args) {

            string path = AppDomain.CurrentDomain.BaseDirectory;

            int val = 60 * 30 * 1000, tick = 0;
            int tmrscrc = 0;
            val += Environment.TickCount;
            var sc = new ScreenCapture();

            while (true) {

                tick = Environment.TickCount;

                if (tmrscrc < tick) {

                    
                    var img = sc.CaptureScreen();
                    img.Save(path + (val - tick) + ".png");


                    tmrscrc = 7000 + tick;
                }
            }
        }
    }
}
