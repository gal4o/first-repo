using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000.Упражнение
{
	class Цифри
	{
		static void Main(string[] args)
		{
			var num = int.Parse(Console.ReadLine());
			var a3 = num % 10;			
			var a2 = (num/10) % 10;
			var a1 = num / 100;
			var r = a1 + a2;
			var c = a1 + a3;

			for (int i = 1; i <= r; i++)
			{
				for (int j = 1; j <= c; j++)
				{
					if (num%5 ==0)
					{
						num = num - a1;
					}
					else if (num%3 == 0)
					{
						num = num - a2;
					}
					else
					{
						num = num + a3;
					}
					Console.Write("{0} ", num);
				}
				Console.WriteLine();
			}
		}
	}
}
