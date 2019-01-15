using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.ЗалаЗаТанци
{
    class ЗалаЗаТанци
    {
        static void Main(string[] args)
        {
            var l = decimal.Parse(Console.ReadLine());
            var w = decimal.Parse(Console.ReadLine());
            var a = decimal.Parse(Console.ReadLine());

            var placeZ = (l*100)*(w*100);
            // double cl = 4.00 * a;
            var sitPl = placeZ*10/100;
            var free = placeZ - (a*100)*(a*100) - sitPl;
            decimal dance = 7040;

            Console.WriteLine(Math.Floor(free / dance));
        }
    }
}
