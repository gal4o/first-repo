using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.КоледнаЕлха
{
	class КоледнаЕла
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			Console.Write(new string(' ', n+1));
			Console.WriteLine("|");

			for (int r = 1; r <= n; r++)
			{
				Console.Write(new string(' ', n-r));
				Console.Write(new string('*', r));
				Console.Write(" | ");
				Console.WriteLine(new string('*', r));
			}
		}
	}
}
