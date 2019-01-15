using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ЛицеНаТриъгълник
{
    class ЛицеНаТриъгълник
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            Console.WriteLine("Triangle area = " + Math.Round(a*h/2,2));
        }
    }
}
