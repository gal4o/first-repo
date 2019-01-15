using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
	class Program
	{
		static void Main(string[] args)
		{
			var countDays = int.Parse(Console.ReadLine());
			var kmFirstDay = double.Parse(Console.ReadLine());
			var kmEveryDay = kmFirstDay;
			var kmAll = 0.00;
			for (int i = 1; i <= countDays; i++)
			{
				var k = int.Parse(Console.ReadLine());
				var kD = k / 100.00;
				kmEveryDay = kmEveryDay + kmEveryDay*kD;
				kmAll += kmEveryDay;		
			}
			if (kmAll >= 1000)
			{
				Console.WriteLine("You've done a great job running {0} more kilometers!",Math.Ceiling( (kmAll+kmFirstDay) - 1000));
			}
			else
			{
				Console.WriteLine("Sorry Mrs. Ivanova, you need to run {0} more kilometers", Math.Ceiling(1000-(kmAll+kmFirstDay)));
			}
		}
	}
}
