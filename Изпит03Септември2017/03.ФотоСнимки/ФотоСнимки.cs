using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ФотоСнимки
{
	class ФотоСнимки
	{
		static void Main(string[] args)
		{
			int countFotos = int.Parse(Console.ReadLine());
			string typeFotos = Console.ReadLine();
			string online = Console.ReadLine();

			double prise = 0.00;

			switch (typeFotos)
			{
				case "9X13": prise = 0.16*countFotos;
					if (countFotos>=50)
					{
						prise = prise - prise * 0.05;
					}
					break;
				case "10X15": prise = 0.16*countFotos;
					if (countFotos >= 80)
					{
						prise = prise - prise * 0.03;
					}
					break;
				case "13X18": prise = 0.38*countFotos;
					if (countFotos > 100)
					{
						prise = prise - prise * 0.05;
					}
					else if (countFotos >= 50)
					{
						prise = prise - prise * 0.03;
					}
					break;
				case "20X30": prise = 2.90*countFotos;
					if (countFotos > 50)
					{
						prise = prise - prise * 0.09;
					}
					else if (countFotos > 10)
					{
						prise = prise - prise * 0.07;
					}
					break;
			}
			if (online == "online")
			{
				prise = prise - prise * 0.02;
			}
			Console.WriteLine("{0:f2}BGN", prise);
		}
	}
}
