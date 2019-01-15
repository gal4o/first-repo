using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.ШивашкиЦех
{
    class ШивашкиЦех
    {
        static void Main(string[] args)
        {
            var table = int.Parse(Console.ReadLine());
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            var pokr = (a + 2 * 0.30) * (b + 2 * 0.30) * table;
            var kare = (a / 2.00) * (a / 2.00)*table;
            var result1 = pokr * 7 + kare * 9;
            
            Console.WriteLine("{0:f2}{1}", result1, " USD");
            Console.WriteLine("{0:f2}{1}", result1*1.85,  " BGN" );
        }
    }
}
