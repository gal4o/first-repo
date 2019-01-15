using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.НавремеЗаИзпит
{
	class НавремеЗаИзпит
	{
		static void Main(string[] args)
		{
			var hTest = int.Parse(Console.ReadLine());
			var minTest = int.Parse(Console.ReadLine());
			var hCom = int.Parse(Console.ReadLine());
			var minCom = int.Parse(Console.ReadLine());

			int test = hTest * 60 + minTest;
			int com = hCom * 60 + minCom;
			int diff =Math.Abs( test - com);

			if (com > test)
			{
				Console.WriteLine("Late");
				if (diff < 60)
				{
					Console.WriteLine("{0} minutes after the start", diff);
				}
				else
				{
					Console.WriteLine("{0}:{1:d2} hours after the start", diff / 60, diff % 60);
				}
			}
			else if (com >= test - 30)
			{
				Console.WriteLine("On time");
				if (com != test)
				{
					Console.WriteLine("{0} minutes before the start", diff);
				}
			}
			else
			//if (com < test)
			{
				Console.WriteLine("Early");
				if (diff<60)
				{
					Console.WriteLine("{0} minutes before the start", diff);
				}
				else
				{
					Console.WriteLine("{0}:{1:d2} hours before the start", diff/60, diff%60 );
				}
			}
		}
	}
}
