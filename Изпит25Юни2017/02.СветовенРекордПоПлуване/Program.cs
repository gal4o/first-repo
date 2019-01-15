using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.СветовенРекордПоПлуване
{
	class Program
	{
		static void Main(string[] args)
		{
			var recSec = double.Parse(Console.ReadLine());
			var lenghtM = double.Parse(Console.ReadLine());
			var timeIvanM = double.Parse(Console.ReadLine());

			var zabav = (Math.Floor(lenghtM / 15)) * 12.5;
			var ivanRec = lenghtM * timeIvanM+zabav;

			if (ivanRec<recSec)
			{
				Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", ivanRec);
			}
			else
			{
				Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", ivanRec-recSec);
			}
		}
	}
}
