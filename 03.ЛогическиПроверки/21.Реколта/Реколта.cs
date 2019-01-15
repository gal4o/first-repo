using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Реколта
{
	class Реколта
	{
		static void Main(string[] args)
		{
			var pl = int.Parse(Console.ReadLine());
			var grape = double.Parse(Console.ReadLine());
			var needVine = int.Parse(Console.ReadLine());
			var works = int.Parse(Console.ReadLine());

			var haveVine = pl * grape * 0.40 / 2.5;
			if (haveVine>=needVine)
			{
				Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(haveVine));
				Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(haveVine-needVine), Math.Ceiling((haveVine-needVine)/works));
			}
			else
			{
				Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(needVine-haveVine));
			}
			
		}
	}
}
