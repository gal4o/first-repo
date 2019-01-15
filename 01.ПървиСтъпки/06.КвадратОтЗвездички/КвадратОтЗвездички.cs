using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.КвадратОтЗвездички
{
    class КвадратОтЗвездички
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine(new string ('*',num));
            for (int i = 1; i <=num-2; i++)
            {
                Console.Write("*" + new string(' ',num-2));
                Console.WriteLine("*");
            }
            Console.WriteLine(new string('*',num));
        }
    }
}
