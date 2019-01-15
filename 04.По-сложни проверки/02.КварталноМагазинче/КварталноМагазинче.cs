using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.КварталноМагазинче
{
    class КварталноМагазинче
    {
        static void Main(string[] args)
        {
            string prod = Console.ReadLine();
            string city = Console.ReadLine();
            var count = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (prod == "coffee")
                    Console.WriteLine(count * 0.50);
                else if (prod == "water")
                    Console.WriteLine(count * 0.80);
                else if (prod == "beer")
                    Console.WriteLine(count * 1.20);
                else if (prod == "sweets")
                    Console.WriteLine(count * 1.45);
                else
                    Console.WriteLine(count * 1.60);
            }

            else if (city == "Plovdiv")
            {
                switch (prod)
                {
                    case "coffee": Console.WriteLine(count * 0.40); break;
                    case "water": Console.WriteLine(count * 0.70); break;
                    case "beer": Console.WriteLine(count * 1.15); break;
                    case "sweets": Console.WriteLine(count * 1.30); break;
                    default:
                        Console.WriteLine(count * 1.50);
                        break;
                }
            }
            else
            {
                if (prod == "coffee")
                    Console.WriteLine(count * 0.45);
                else if (prod == "water")
                    Console.WriteLine(count * 0.70);
                else if (prod == "beer")
                    Console.WriteLine(count * 1.10);
                else if (prod == "sweets")
                    Console.WriteLine(count * 1.35);
                else
                    Console.WriteLine(count * 1.55);
            }
        }
    }
}

