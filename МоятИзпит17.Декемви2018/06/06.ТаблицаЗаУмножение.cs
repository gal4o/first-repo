using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			int ed = n % 10;
			int des = (n / 10) % 10;
			int stot = (n / 100) % 10;
			var a = 0;
			var b = 0;
			var c = 0;

			for (int i = 1; i <= ed; i++)
			{
				a = i;
				for (int j = 1; j <= des; j++)
				{
					b = j;
					for (int k = 1; k <= stot; k++)
					{
						c = k;
						Console.WriteLine("{0} * {1} * {2} = {3};", a, b, c, a*b*c);
					}
				}
			}
		}
	}
}
