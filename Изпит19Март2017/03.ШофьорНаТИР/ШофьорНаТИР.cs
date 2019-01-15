using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ШофьорНаТИР
{
	class ШофьорНаТИР
	{
		static void Main(string[] args)
		{
			string sesson = Console.ReadLine();
			var kmMonth = double.Parse(Console.ReadLine());
			var prize = 0.00;
			if (kmMonth<=5000)
			{
				switch (sesson)
				{
					case "Summer": prize = 0.90 * kmMonth*4; break;
					case "Winter": prize = 1.05 * kmMonth*4; break;
					default:prize = 0.75 * kmMonth*4;
						break;
				}
			}
			else if (kmMonth<=10000)
			{
				switch (sesson)
				{
					case "Summer": prize = 1.10 * kmMonth*4; break;
					case "Winter": prize = 1.25 * kmMonth*4; break;
					default:
						prize = 0.95 * kmMonth*4;
						break;
				}
			}
			else 
			{
				prize = 1.45 * kmMonth*4;
			}
			Console.WriteLine("{0:f2}", prize-prize*0.10);
		}
	}
}
