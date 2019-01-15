using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.МеждувалутенКонвектор
{
    class МеждувалутенКонвектор
    {
        static void Main(string[] args)
        {
            var incount = double.Parse(Console.ReadLine());
            string incurrency = Console.ReadLine();
            string outcurrency = Console.ReadLine();

            double bgn = 0;
            
            if (incurrency == "BGN")
            {
                bgn = incount;
            }
            else if (incurrency == "USD")
            {
                bgn = incount * 1.79549;
            }
            else if (incurrency == "EUR")
            {
                bgn = incount * 1.95583;
            }
            else
            {
                bgn = incount * 2.53405;
            }

            double outcount = 0;

            if (outcurrency == "BGN")
            {
                Console.WriteLine(Math.Round(bgn,2)); 
            }
            else if (outcurrency == "USD")
            {
                Console.WriteLine(Math.Round( bgn / 1.79549,2));
            }
            else if (outcurrency == "EUR")
            {
                Console.WriteLine(Math.Round( bgn / 1.95583,2));
            }
            else
            {
                Console.WriteLine(Math.Round( bgn /2.53405,2));
            }
        }
    }
}
