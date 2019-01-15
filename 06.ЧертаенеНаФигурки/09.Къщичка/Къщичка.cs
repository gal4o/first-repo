using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Къщичка
{
	class Къщичка
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			//pokriw
			for (int r = 1; r <= (n + 1) / 2; r++)
			{
				if (n % 2 == 0)
				{
					Console.Write(new string('-', (n - 2 * r) / 2));
					Console.Write(new string('*', 2 * r));
					Console.WriteLine(new string('-', (n - 2 * r) / 2));
				}
				else
				{
					Console.Write(new string('-', (n - (2 * r - 1)) / 2));
					Console.Write(new string('*', 2 * r - 1));
					Console.WriteLine(new string('-', (n - (2 * r - 1)) / 2));
				}
			}
			//Osnowi
			for (int i = 1; i <= n / 2; i++)
			{
				Console.Write("|");
				Console.Write(new string('*', n - 2));
				Console.WriteLine("|");
			}
		}
	}
}
