using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
	class Program
	{
		static void Main(string[] args)
		{
			double l = double.Parse(Console.ReadLine());
			double w = double.Parse(Console.ReadLine());
			double a = double.Parse(Console.ReadLine());
			var zal = l * w;
			var gard = a * a;
			var pei = zal / 10;
			var danc = 0.704;
			var freePl = zal - gard - pei;
			Console.WriteLine(Math.Floor(freePl/danc));
		}
	}
}
