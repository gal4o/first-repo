using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.КонверторЦелзийФаренхайт
{
    class КонверторЦелзийФаренхайт
    {
        static void Main(string[] args)
        {
            var cel = double.Parse(Console.ReadLine());
            double far = cel * 1.8 + 32;
            Console.WriteLine(Math.Round(far,2));
        }
    }
}
