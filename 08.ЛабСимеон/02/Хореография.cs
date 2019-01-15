using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
	class Program
	{
		static void Main(string[] args)
		{
			var step = int.Parse(Console.ReadLine());
			var danc = int.Parse(Console.ReadLine());
			var days = int.Parse(Console.ReadLine());

			double stepDayly = (step / days);
			double persent = Math.Ceiling((stepDayly / step)*100.00);
			{
				Console.WriteLine("Yes, they will succeed in that goal! {0:f2}%.", persent/danc);
			}
			else
			{
				Console.WriteLine("No, They will not succeed in that goal! Required {0:f2}% steps to be learned per day.", persent/danc);
			}
		}
	}
}
