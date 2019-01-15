using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.КуриерЕкспрес
{
	class КуриерЕкспрес
	{
		static void Main(string[] args)
		{
			var weight = double.Parse(Console.ReadLine());
			var type = Console.ReadLine();
			var lengt = int.Parse(Console.ReadLine());

			double prize = 0;
			if (type == "standard")
			{
				if (weight < 1.00)
				{
					prize = 0.03 * lengt;
				}
				else if (weight < 11)
				{
					prize = 0.05 * lengt;
				}
				else if (weight < 41)
				{
					prize = 0.10 * lengt;
				}
				else if (weight < 91)
				{
					prize = 0.15 * lengt;
				}
				else
				{
					prize = 0.20 * lengt;
				}
			}
			if (type == "express")
			{
				if (weight < 1.00)
				{
					prize = (0.03+0.03*0.80*weight)*lengt;
				}
				else if (weight < 11)
				{
					prize = (0.05+0.05 * 0.40 * weight) * lengt;
				}
				else if (weight < 41)
				{
					prize = (0.10+0.10 * 0.05 * weight) * lengt;
				}
				else if (weight < 91)
				{
					prize = (0.15+0.15 * 0.02 * weight) * lengt;
				}
				else
				{
					prize = (0.20 + 0.20 * 0.01 * weight) * lengt;
				}
			}
			Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.", weight, prize);

		}
	}
}
