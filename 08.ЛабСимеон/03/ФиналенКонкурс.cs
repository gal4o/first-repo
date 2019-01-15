using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
	class Program
	{
		static void Main(string[] args)
		{
			var countDancer = int.Parse(Console.ReadLine());
			var point = double.Parse(Console.ReadLine());
			var sesson = Console.ReadLine();
			var place = Console.ReadLine();
			double money = 0;

			if (place=="Bulgaria")
			{
				money = point * countDancer;
				if (sesson=="summer")
				{
					money = money - (money * 5 / 100.00);
				}
				else

				{
					money = money - (money * 8 / 100.00);
				}
			}
			else
			{
				money = (point * countDancer);
				money = ((money * 50) / 100) + money;
				if (sesson=="summer")
				{
					money = money - (money * 10 / 100.00);
				}
				else
				{
					money = money - (money * 15 / 100.00);
				}
			}
			var dar = (money*75)/ 100;
			Console.WriteLine("Charity - {0:f2}", dar);
			Console.WriteLine("Money per dancer - {0:f2}", (money - dar) / countDancer);
		}
	}
}
