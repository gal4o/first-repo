﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ЛицеИПериметърНаКръг
{
    class ЛицеИПериметърНаКръг
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());

            Console.WriteLine("Area = " + Math.PI*r*r);
            Console.WriteLine("Perimeter = " + 2*Math.PI*r);
        }
    }
}
