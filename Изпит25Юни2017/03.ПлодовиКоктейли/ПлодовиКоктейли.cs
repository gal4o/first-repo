using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ПлодовиКоктейли
{
	class ПлодовиКоктейли
	{
		static void Main(string[] args)
		{
			string fruid = Console.ReadLine();
			string biggar = Console.ReadLine();
			var countCoktails = int.Parse(Console.ReadLine());

			var prise = 0.00;

			if (biggar == "small")
			{
				switch (fruid)
				{
					case "Watermelon": prise = 56.00 * 2*countCoktails; break;
					case "Mango": prise = 36.66 * 2*countCoktails; break;
					case "Pineapple": prise = 42.10 * 2*countCoktails; break;
					case "Raspberry": prise = 20.00 * 2*countCoktails; break;
				}
			}
			else
			{
				switch (fruid)
				{
					case "Watermelon": prise = 28.70 * 5*countCoktails; break;
					case "Mango": prise = 19.60 * 5*countCoktails; break;
					case "Pineapple": prise = 24.80 * 5*countCoktails; break;
					case "Raspberry": prise = 15.20 * 5*countCoktails; break;
				}
			}

			if (prise>1000)
			{
				prise = prise - (prise * 0.50);
			}
			else if (prise>=400)
			{
				prise = prise - (prise * 0.15);
			}
			Console.WriteLine("{0:f2} lv.", prise);
		}
	}
}
