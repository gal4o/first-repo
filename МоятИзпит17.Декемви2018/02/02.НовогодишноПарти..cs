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
			var countG = int.Parse(Console.ReadLine());
			var budjet = int.Parse(Console.ReadLine());
			var need = countG * 20;
			if (need<budjet)
			{
				var ost = budjet - need;
				Console.WriteLine("Yes! {0} lv are for fireworks and {1} lv are for donation.", Math.Round( ost*0.40),Math.Round( ost-(ost*0.40)));
			}
			else
			{
				Console.WriteLine("They won't have enough money to pay the covert. They will need {0} lv more.", need-budjet);
			}
		}
	}
}
