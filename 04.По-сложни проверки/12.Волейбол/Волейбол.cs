using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Волейбол
{
    class Волейбол
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());

            double volley = 0;
            volley += (48 - h) * 3.00 / 4 + 2.00 / 3 * p + h;

            if (year == "leap")
            {
                volley += volley * 15.00 / 100;
            }

            Console.WriteLine(Math.Truncate(volley));  //truncate = закръгли надолу може да има до колко знака

        }
    }
}
