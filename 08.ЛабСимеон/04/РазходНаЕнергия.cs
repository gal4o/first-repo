using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
	class Program
	{
		static void Main(string[] args)
		{
			var days = int.Parse(Console.ReadLine());
			var dancers = int.Parse(Console.ReadLine());
			var hours = 0;
			var needEnergyAll = 0;

			for (int i = 1; i <= days; i++)
			{
				var needEnergy = 0;
				hours = int.Parse(Console.ReadLine());
				if (i % 2 == 0)
				{
					if (hours % 2 == 0)
					{
						needEnergy = 68 * dancers;
					}
					else
					{
						needEnergy = 65 * dancers;
					}
				}
				else
				{
					if (hours % 2 == 0)
					{
						needEnergy = 49 * dancers;
					}
					else
					{
						needEnergy = 30 * dancers;
					}
				}
				needEnergyAll += needEnergy;
			}
			var allEnergy = 100 * dancers*days;
			double ostEnergyAllDays = allEnergy - needEnergyAll;
			double ostEnergyDanceDay = ostEnergyAllDays / dancers / days;
			if (ostEnergyDanceDay<=50)
			{
				Console.WriteLine("They are wasted! Energy left: {0:f2}", ostEnergyDanceDay);
			}
			else
			{
				Console.WriteLine("They feel good! Energy left: {0:f2}", ostEnergyDanceDay);
			}
		}
	}
}
