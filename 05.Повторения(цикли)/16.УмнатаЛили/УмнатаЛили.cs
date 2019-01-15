using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.УмнатаЛили
{
	class УмнатаЛили
	{
		static void Main(string[] args)
		{
			var y = int.Parse(Console.ReadLine());
			var prise = double.Parse(Console.ReadLine());
			var pToy = double.Parse(Console.ReadLine());
			var gmoney = 0;
			var money = 0;
			var toy = 0;
			var brother = 0;
			for (int i = 1; i <= y; i++)
			{
				if (i%2 == 0)
				{
					gmoney += 10;
					money += gmoney;
					brother += 1;
				}
				else
				{
					toy += 1;	
				}
			}
			var have = money + toy * pToy - brother;
			if (have>=prise)
			{
				Console.WriteLine("Yes! {0:f2}", have-prise);
			}
			else
			{
				Console.WriteLine("No! {0:f2}", prise-have);
			}
		}
	}
}
