using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.МагазинЗаПлодове
{
    class МагазинЗаПлодове
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            var count = double.Parse(Console.ReadLine());

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day=="Friday" )    //||=или
            {                                                                                                        // && = и
                switch (fruit)                                                                                       // != - не равно
                {
                    case "banana": Console.WriteLine(count * 2.50); break;
                    case "apple": Console.WriteLine(count * 1.20); break;
                    case "orange": Console.WriteLine(count * 0.85); break;
                    case "grapefruit": Console.WriteLine(count * 1.45); break;
                    case "kiwi": Console.WriteLine(count*2.70 );break;
                    case "pineapple": Console.WriteLine(count*5.50 );break;
                    case "grapes": Console.WriteLine(count*3.85);break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (day == "Saturday" || day =="Sunday")
            {
                switch (fruit)
                {
                    case "banana": Console.WriteLine(count * 2.70); break;
                    case "apple": Console.WriteLine(count * 1.25); break;
                    case "orange": Console.WriteLine(count * 0.90); break;
                    case "grapefruit": Console.WriteLine(count * 1.60); break;
                    case "kiwi": Console.WriteLine(count * 3.00); break;
                    case "pineapple": Console.WriteLine(count * 5.60); break;
                    case "grapes": Console.WriteLine(count * 4.20); break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
