using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ПесентаНаКолелетата
{
	class ПесентаНаКолелетата
	{
		static void Main(string[] args)
		{
			var m = int.Parse(Console.ReadLine());
			int a = 1;
			int b = 1;
			int c = 1;
			int d = 1;
			var count = 0;
			bool pass =false ;
			var password = 0;
			for (int i = 1; i <= 9; i++)
			{
				a = i;
				for (int f = a+1; f <= 9; f++)
				{
					b = f;
					for (int g = 1; g <= 9; g++)
					{
						c = g;
						for (int j = 1; j < c; j++)
						{
							d = j;
							if (a*b+c*d == m)
							{
								Console.Write("{0}{1}{2}{3} ", a,b,c,d);
								count ++;
								if (count==4)
								{
									pass = true;
									password = a * 1000 + b * 100 + c * 10 + d;
								}
							}
						}
					}
				}
			}
			Console.WriteLine();
			Console.WriteLine(pass?"Password: "+ password :"No!");
		}
	}
}
