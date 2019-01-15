using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ГроздеИРакия
{
	class ГроздеИРакия
	{
		static void Main(string[] args)
		{
			var loze = double.Parse(Console.ReadLine());
			var productKvM = double.Parse(Console.ReadLine());
			var miss = double.Parse(Console.ReadLine());
			var product = loze * productKvM - miss;
			var grapeMonney = (product*0.55)*1.50;
			var rakiaMonney = ((product * 0.45) / 7.5) * 9.80;
			Console.WriteLine("{0:f2}", rakiaMonney);
			Console.WriteLine("{0:f2}", grapeMonney);
		}
	}
}
