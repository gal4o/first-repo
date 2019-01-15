using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Кино
{
    class Кино
    {
        static void Main(string[] args)
        {
            string project = Console.ReadLine();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            var place = r * c;

            switch (project)
            {
                case "Premiere": Console.WriteLine($"{ place * 12.00:f2}"); break; //$"{... :закръгляне}"
                case "Normal": Console.WriteLine($"{place *7.50:f2}"); break;      // закръглянето е : f цифра(бр.знаци)-добавя нула отзад
                case "Discount": Console.WriteLine($"{place * 5.00:f2}"); break;    //                 d цифра()-добаввя нули отпред
            }
        }
    }
}
