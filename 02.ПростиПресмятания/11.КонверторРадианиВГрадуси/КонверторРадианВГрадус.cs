using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.КонверторРадианиВГрадуси
{
    class КонверторРадианВГрадус
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round( 180/Math.PI*rad));
        }
    }
}
