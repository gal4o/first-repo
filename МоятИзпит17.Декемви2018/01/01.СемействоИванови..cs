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
			var budjet = double.Parse(Console.ReadLine());
			var prize1 = double.Parse(Console.ReadLine());
			var prize2 = double.Parse(Console.ReadLine());
			var prize3 = double.Parse(Console.ReadLine());
			var ost = budjet - (prize1 + prize2 + prize3);
			var dar = ost - ost * 0.10;
			Console.WriteLine("{0:f2}", dar);
		}
	}
}
