using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ТримаБратя
{
	class ТримаБратя
	{
		static void Main(string[] args)
		{
			double first = double.Parse(Console.ReadLine());
			double second = double.Parse(Console.ReadLine());
			double trit = double.Parse(Console.ReadLine());
			double father = double.Parse(Console.ReadLine());

			var cleaningTime = 1 / (1 / first + 1 / second + 1 / trit);
			var needTime = cleaningTime + cleaningTime * 0.15;
			Console.WriteLine("Cleaning time: {0:f2}", needTime);

			if (needTime>father)
			{
				Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.",Math.Ceiling( Math.Abs(needTime-father)));
			}
			else
			{
				Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.", Math.Floor(Math.Abs(needTime - father)));
			}
		}
	}
}
