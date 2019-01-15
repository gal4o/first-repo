using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ЛицаНаФигури
{
    class ЛицаНаФигури
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            
            string fig = Console.ReadLine();

            if (fig == "square")
            {
                a = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(a*a, 3));
            }
            else if (fig =="circle")
            {
                a = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Math.PI*a*a, 3));
            }
            else if (fig == "rectangle")
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(a*b, 3));
            }
            else if (fig == "triangle")
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(a * b/2, 3));
            }
        }
    }
}
