using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.БанкнотиИМонети
{
	class БанкнотиИМонети
	{
		static void Main(string[] args)
		{

			int mon1 = int.Parse(Console.ReadLine());
			int mon2 = int.Parse(Console.ReadLine());
			int bank5 = int.Parse(Console.ReadLine());
			int sum = int.Parse(Console.ReadLine());

			for (int i = 0; i <= mon1; i++)
			{
				var sum1 = i * 1;
				for (int j = 0; j <= mon2; j++)
				{
					var sum2 = j * 2;
					for (int k = 0; k <= bank5; k++)
					{
						var sum5 = k * 5;
						if (sum1 + sum2 + sum5 == sum)
						{
							Console.WriteLine("{0} * 1 lv. + {1} * 2 lv. + {2} * 5 lv. = {3} lv.", i,j,k,sum);
						}
					}
				}
			}
		}
	}
}
