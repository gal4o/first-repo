using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ПаричнаНаграда
{
	class ПаричнаНаграда
	{
		static void Main(string[] args)
		{
			var pieces = int.Parse(Console.ReadLine());
			var monneyDot = double.Parse(Console.ReadLine());
			var dotsAll = 0;
			for (int i = 1; i <= pieces; i++)
			{
				var dots = int.Parse(Console.ReadLine());
				if (i%2 == 0)
				{
					dots = dots * 2;
				}
				dotsAll += dots;
			}
			Console.WriteLine("The project prize was {0:f2} lv.", dotsAll * monneyDot);
		}
	}
}
