using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.ПоспаливатаКоткаТом
{
	class ПоспаливатаКоткаТом
	{
		static void Main(string[] args)
		{
			var freeDays = int.Parse(Console.ReadLine());
			var gameMinutes = freeDays * 127 + (365 - freeDays) * 63;
			if (gameMinutes>30000)
			{
				var dif = gameMinutes - 30000;
				Console.WriteLine("Tom will run away");
				Console.WriteLine("{0} hours and {1} minutes more for play",dif/60, dif%=60 ) ;
			}
			else
			{
				var dif = 30000 - gameMinutes;
				Console.WriteLine("Tom sleeps well");
				Console.WriteLine("{0} hours and {1} minutes less for play",dif/60, dif%= 60) ;
			}
		}
	}
}
