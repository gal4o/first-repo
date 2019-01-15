using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.КонверторНаМерниЕдиници
{
    class КонверторНаМерниЕдиници
    {
        static void Main(string[] args)
        {
            var inlen = double.Parse(Console.ReadLine());
            string inunit = Console.ReadLine();
            string outunit = Console.ReadLine();

            double lenm = 0;

            if (inunit == "m" )
            {
                lenm = inlen;
            }
            else if (inunit == "mm")
            {
                lenm = inlen / 1000;
            }
            else if (inunit == "cm")
            {
                lenm = inlen /100;
            }
            else if (inunit == "mi")
            {
                lenm = inlen / 0.000621371192;
            }
            else if (inunit == "in")
            {
                lenm = inlen / 39.3700787;
            }
            else if (inunit == "km")
            {
                lenm = inlen / 0.001;
            }
            else if (inunit == "ft")
            {
                lenm = inlen / 3.2808399;
            }
            else if (inunit == "yd")
            {
                lenm = inlen / 1.0936133;
            }

            var outlen = lenm;

            if (outunit == "m")
            {
                outlen = lenm;
            }
            else if (outunit == "mm")
            {
                outlen = lenm * 1000;
            }
            else if (outunit == "cm")
            {
                outlen = lenm * 100;
            }
            else if (outunit == "mi")
            {
                outlen = lenm * 0.000621371192;
            }
            else if (outunit == "in")
            {
                outlen = lenm * 39.3700787;
            }
            else if (outunit == "km")
            {
                outlen = lenm *  0.001;
            }
            else if (outunit == "ft")
            {
                outlen = lenm * 3.2808399;
            }
            else if (outunit == "yd")
            {
                outlen = lenm * 1.0936133;
            }

            Console.WriteLine(Math.Round(outlen,8));
        }
    }
}
