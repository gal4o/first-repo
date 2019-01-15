using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Хистограма
{
	class Хистограма
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			int p1 = 0;
			int p2 = 0;
			int p3 = 0;
			int p4 = 0;
			int p5 = 0;
			for (int i = 1; i <= n; i++)
			{
				var num = int.Parse(Console.ReadLine());
				if (num<200)
				{
					p1 += 1;
				}
				else if (num<400)
				{
					p2 += 1;
				}
				else if (num<600)
				{
					p3 += 1;
				}
				else if (num<800)
				{
					p4 += 1;
				}
				else
				{
					p5 += 1;
				}
			}

			Console.WriteLine("{0:f2}%",(100.00/n)*p1);
			Console.WriteLine("{0:f2}%", (100.00/n)*p2);
			Console.WriteLine("{0:f2}%", (100.00/n)*p3);
			Console.WriteLine("{0:f2}%", (100.00/n)*p4);
			Console.WriteLine("{0:f2}%", (100.00/n)*p5);
		}
	}
}
