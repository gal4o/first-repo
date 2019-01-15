using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ТърговскиКомисионни
{
    class ТърговскиКомисионни
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();                 // ТоLower - всички букви стават малки
            var sales = double.Parse(Console.ReadLine());               //ToUpper = всички букви стават големи

            double kom = 0.0;

            if (city == "sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine($"{sales * 5 / 100.00:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine( $"{ sales * 7 / 100.00:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine($"{ sales * 8 / 100.00:f2}");
                }
                else if (sales > 10000)
                {
                    Console.WriteLine($"{sales * 12 / 100.00:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine($"{sales * 5.5 / 100.00:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine($"{ sales * 8 / 100.00:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine($"{ sales * 12 / 100.00:f2}");
                }
                else if (sales > 10000)
                {
                    Console.WriteLine($"{sales * 14.5 / 100.00:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine($"{sales * 4.5 / 100.00:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine($"{ sales * 7.5 / 100.00:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine($"{ sales * 10 / 100.00:f2}");
                }
                else if (sales > 10000)
                {
                    Console.WriteLine($"{sales * 13 / 100.00:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
