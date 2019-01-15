using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.БилетиЗаМач
{
	class БилетиЗаМач
	{
		static void Main(string[] args)
		{
			var money = double.Parse(Console.ReadLine());
			string category = Console.ReadLine();
			var people = int.Parse(Console.ReadLine());

			var transport = 0.00;
			if (people<=4)
			{
				transport = money * 0.75;
			}
			else if (people<=9)
			{
				transport = money * 0.60;
			}
			else if (people <= 24)
			{
				transport = money * 0.50;
			}
			else if (people <=49)
			{
				transport = money * 0.40;
			}
			else
			{
				transport = money * 0.25;
			}

			var inMoney = 0.00;
			if (category == "VIP")
			{
				inMoney = 499.99 * people;
			}
			else
			{
				inMoney = 249.99 * people;
			}

			var needMoney = transport + inMoney;
			if (money>=needMoney)
			{
				Console.WriteLine("Yes! You have {0:f2} leva left.", money-needMoney );
			}
			else
			{
				Console.WriteLine("Not enough money! You need {0:f2} leva.", needMoney-money );
			}
		}
	}
}
