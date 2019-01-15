using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.МобиленОператор
{
	class МобиленОператор
	{
		static void Main(string[] args)
		{
			string time = Console.ReadLine();
			string type = Console.ReadLine();
			string net = Console.ReadLine();
			int mounth = int.Parse(Console.ReadLine());
			double priseMounth = 0;
			if (time == "one")
			{
				switch (type)
				{
					case "Small": priseMounth = 9.98;break;
					case "Middle": priseMounth = 18.99; break;
					case "Large": priseMounth = 25.98; break;
					case "ExtraLarge": priseMounth = 35.99; break;
				}
			}
			else
			{
				switch (type)
				{
					case "Small": priseMounth = 8.58; break;
					case "Middle": priseMounth = 17.09; break;
					case "Large": priseMounth = 23.59; break;
					case "ExtraLarge": priseMounth = 31.79; break;
				}
			}
			if (net == "yes")
			{
				double priseNet = 0;
				if (priseMounth<=10.00)
				{
					priseNet = 5.50;
				}
				else if (priseMounth<=30.00)
				{
					priseNet = 4.35;
				}
				else
				{
					priseNet = 3.85;
				}
				priseMounth = priseMounth + priseNet;
			}
			double otst = 0;
			double prise = priseMounth * mounth;
			if (time == "two")
			{
				otst = prise * 0.0375;
				prise = prise - otst;
			}
			Console.WriteLine("{0:f2} lv.", prise);
		}
	}
}
