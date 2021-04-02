using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Laba4_1
{
    class Program
    {
        [DllImport("User32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);

        static void draw(Rectangle r, Brush b, IntPtr hwnd)
        {
            using (Graphics g = Graphics.FromHdc(hwnd))
            {
                g.FillRectangle(b, r);
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Command ~> ");
                string cmd = Console.ReadLine();
                if (cmd.ToLower().Substring(0, 4) == "draw")
                {
                    string[] rec = cmd.Substring(5).Split(':');

                    int x = Convert.ToInt32(rec[0]);
                    int y = Convert.ToInt32(rec[1]);
                    int w = Convert.ToInt32(rec[2]);
                    int h = Convert.ToInt32(rec[3]);

                    draw(new Rectangle(x, y, w, h), Brushes.PaleGoldenrod, GetDC(IntPtr.Zero));
                }
            }
        }
    }
}
