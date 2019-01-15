using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.ЦенаНаТранспорт
{
	class ЦенаНаТранспорт
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			string day = Console.ReadLine();

			if (n < 20)
			{
				if (day == "day")
				{
					Console.WriteLine("{0:f2}", 0.70+n*0.79);
				}
				else if (day == "night")
				{
					Console.WriteLine("{0:f2}", 0.70+n*0.90);
				}
			}
			else if (n<100)
			{
				Console.WriteLine("{0:f2}", n*0.09);
			}
			else
			{
				Console.WriteLine("{0}", n*0.06);
			}
		}
	}
}
