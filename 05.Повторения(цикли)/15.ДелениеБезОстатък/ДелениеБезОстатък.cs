using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ДелениеБезОстатък
{
	class ДелениеБезОстатък
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var p1 = 0;
			var p2 = 0;
			var p3 = 0;
			for (int i = 1; i <= n; i++)
			{
				var num = int.Parse(Console.ReadLine());
				if (num % 2 == 0)
				{
					p1 += 1;

					if (num % 4 == 0)
					{
						p3 += 1;
					}
				}
				if (num % 3 == 0)
				{
					p2 += 1;
				}
			}
			Console.WriteLine("{0:f2}%", (100.00/n)*p1);
			Console.WriteLine("{0:f2}%", (100.00/n)*p2);
			Console.WriteLine("{0:f2}%", (100.00/n)*p3);
		}
	}
}
