using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ЛицеПравоъгълникВРавнина
{
    class ЛицеПравоъгълникВРавниня
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            double a = Math.Abs(x1 - x2);
            double b = Math.Abs(y1 - y2);

            Console.WriteLine(a*b);
            Console.WriteLine((a+b)*2);

        }
    }
}
