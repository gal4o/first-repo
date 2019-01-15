using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.РомбОтЗвездички
{
	class РомбОтЗвездички
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			for (int r = 1; r < n; r++)
			{
				Console.Write(new string(' ', n-r));
				Console.Write("*");
				for (int c = 1; c <=r-1 ; c++)
				{
					Console.Write(" *");
				}
				Console.WriteLine(" ");
			}

			Console.Write("*");
			for (int c = 1; c < n; c++)
			{
				Console.Write(" *");
			}
			Console.WriteLine();

			for (int r = 1; r < n; r++)
			{
				Console.Write(new string(' ', r));
				Console.Write("*");
				for (int c = 1; c < n-r; c++)
				{
					Console.Write(" *");
				}
				Console.WriteLine(" ");
			}
		}
	}
}
