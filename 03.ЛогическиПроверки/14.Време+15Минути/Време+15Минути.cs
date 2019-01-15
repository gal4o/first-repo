using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Време_15Минути
{
    class Program
    {
        static void Main(string[] args)
        {
            int inhour = int.Parse(Console.ReadLine());
            int inmin = int.Parse(Console.ReadLine());
            int summin = inhour * 60 + inmin+15;
            int outhour = summin / 60; 
            int outmin = summin % 60;
            if (outhour == 24)
            {
                Console.Write("0" + ":");
            }
            else
            Console.Write(outhour + ":");

            if (outmin < 10)
            {
                Console.WriteLine("0" + outmin);
            }
            else
            {
                Console.WriteLine(outmin);
            }
        }
    }
}
