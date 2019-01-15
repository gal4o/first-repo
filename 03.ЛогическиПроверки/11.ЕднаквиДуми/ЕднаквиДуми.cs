using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ЕднаквиДуми
{
    class ЕднаквиДуми
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine().ToLower(); // ili .ToUpper()
            string second = Console.ReadLine().ToLower();

            if (first == second)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
