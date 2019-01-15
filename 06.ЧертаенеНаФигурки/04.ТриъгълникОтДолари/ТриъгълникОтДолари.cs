using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ТриъгълникОтДолари
{
	class ТриъгълникОтДолари
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			for (int r = 1; r <= n; r++)
			{
				Console.Write("$");
				for (int c = 1; c <r; c++)
				{
					Console.Write(" $");
				}
				Console.WriteLine();
			}
		}
	}
}
