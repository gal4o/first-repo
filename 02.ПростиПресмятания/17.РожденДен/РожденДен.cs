using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.РожденДен
{
    class РожденДен
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var sand = double.Parse(Console.ReadLine());

            var v =(a*b*c*0.001)-(a * b * c * 0.001)*sand/100.000;

            Console.WriteLine($"{v:f3}");
        }
    }
}
