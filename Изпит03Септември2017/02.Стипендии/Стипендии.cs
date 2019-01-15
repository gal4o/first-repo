using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Стипендии
{
	class Стипендии
	{
		static void Main(string[] args)
		{
			double money = double.Parse(Console.ReadLine());
			double result = double.Parse(Console.ReadLine());
			double minZapl = double.Parse(Console.ReadLine());

			double socStip = 0;
			double excellentStip = 0;

			if (money<minZapl&&result>4.5)
			{
				socStip = minZapl * 0.35;
			}
			if (result>=5.50)
			{
				excellentStip = result * 25;
			}
			if (socStip==0&&excellentStip==0)
			{
				Console.WriteLine("You cannot get a scholarship!");
			}
			else if (socStip!=0&&socStip>excellentStip)
			{
				Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor( socStip));
			}
			else
			{
				Console.WriteLine("You get a scholarship for excellent results {0} BGN",Math.Floor( excellentStip));
			}
		}
	}
}
