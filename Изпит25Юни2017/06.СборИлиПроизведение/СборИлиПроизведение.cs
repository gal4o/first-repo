using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.СборИлиПроизведение
{
	class СборИлиПроизведение
	{
		static void Main(string[] args)
		{
			var m = int.Parse(Console.ReadLine());
			var a = 0;
			var b = 0;
			var c = 0;
			var count = 0;
			for (int i = 1; i <= 30; i++)
			{
				a = i;
				for (int j = 0; j <= 30; j++)
				{
					b = j;
					for (int k = 0; k <= 30; k++)
					{
						c = k;
						if ((a+b+c == m)&&(a<b)&&(b<c))
						{
							count++;
							Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, m);
						}
						else if ((a*b*c==m)&&a>b&&b>c)
						{
							count++;
							Console.WriteLine("{0} * {1} * {2} = {3}", a,b,c,m);
						}
					}
				}
			}
			if (count == 0)
			{
				Console.WriteLine("No!");
			}
		}
	}
}
