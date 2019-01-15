using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.МесечниРазходи
{
	class МесечниРазходи
	{
		static void Main(string[] args)
		{
			var monts = int.Parse(Console.ReadLine());
			var moneyMont = 0.00;
			for (int i = 1; i <= monts; i++)
			{
				var energy = double.Parse(Console.ReadLine());
				moneyMont = energy + 20 + 15 + (energy + 20 + 15) * 0.20;
			}
			 x
		}
	}
}
