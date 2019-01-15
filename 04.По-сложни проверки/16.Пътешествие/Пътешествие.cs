using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Пътешествие
{
	class Пътешествие
	{
		static void Main(string[] args)
		{
			var money = double.Parse(Console.ReadLine());
			string ses = Console.ReadLine();

			if (money<=100)
			{
				Console.WriteLine("Somewhere in Bulgaria" );
				if (ses == "summer")
				{
					Console.WriteLine("Camp - {0:f2}", money*0.30);
				}
				else
				{
					Console.WriteLine("Hotel - {0:f2}", money*0.70);
				}
			}
			else if (money<=1000)
			{
				Console.WriteLine("Somewhere in Balkans");
				if (ses == "summer")
				{
					Console.WriteLine("Camp - {0:f2}", money*0.40);
				}
				else
				{
					Console.WriteLine("Hotel- {0:f2}", money*0.80);
				}
			}
			else
			{
				Console.WriteLine("Somewhere in Europe");
				Console.WriteLine("Hotel - {0:f2}", money*0.90);
			}
		}
	}
}
