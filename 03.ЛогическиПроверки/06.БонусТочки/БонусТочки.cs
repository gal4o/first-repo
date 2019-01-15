using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.БонусТочки
{
    class БонусТочки
    {
        static void Main(string[] args)
        {
            var score = int.Parse(Console.ReadLine());

            double bonus = 0;

            if (score <= 100)
            {
                bonus = 5;
            }
            else if (score <= 1000)
            {
                bonus = score*0.2;
            }
            else if (score > 1000)
            {
                bonus = score*0.1;
            }


            int bonus2 = 0;

            if (score % 2 == 0)
            {
                bonus2 = 1;
            }
            else if (score % 5 == 0)
            {
                bonus2 = 2;
            }
            else
            {
                bonus2 = 0;
            }
            Console.WriteLine(bonus+bonus2);
            Console.WriteLine(score+bonus+bonus2);
        }
    }
}
