using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Лютеница
{
	class Лютеница
	{
		static void Main(string[] args)
		{
			var tomato = double.Parse(Console.ReadLine());
			var boxPlace = int.Parse(Console.ReadLine());
			var jarPlace = int.Parse(Console.ReadLine());

			var lutenica = tomato / 5;
			var jarLutenica = lutenica / 0.535;
			var boxLutenica = jarLutenica/ jarPlace;
			Console.WriteLine("Total lutenica: {0} kilograms.",Math.Floor( lutenica));
			if (boxLutenica >= boxPlace)
			{
				Console.WriteLine("{0} boxes left.", Math.Floor((boxLutenica-boxPlace)));
				Console.WriteLine("{0} jars left.", Math.Floor((jarLutenica-(boxPlace*jarPlace))));
			}
			else
			{
				Console.WriteLine("{0} more boxes needed.",Math.Floor(boxPlace-boxLutenica ));
				Console.WriteLine("{0} more jars needed.",Math.Floor(jarPlace*boxPlace-jarLutenica));
			}
		}
	}
}
