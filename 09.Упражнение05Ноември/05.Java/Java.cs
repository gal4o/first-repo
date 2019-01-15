using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Java
{
	class Java
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				Console.Write(new string(' ',n));
				Console.WriteLine($"~ ~ ~");
			}
			Console.WriteLine(new string('=',( 3*n+5)));
			for (int j= 1; j < n-1; j++)
			{
				Console.Write('|');
				if (j == n/2)
				{
					Console.Write(new string('~', n));
					Console.Write("JAVA");
					Console.Write(new string('~', n));
				}
				else
				{
					Console.Write(new string('~', n*2 + 4));
				}
				Console.Write('|');
				Console.Write(new string(' ',n-1));
				Console.WriteLine('|');
			}
			Console.WriteLine(new string('=', (3*n+5)));
			for (int k = 0; k < n; k++)
			{
				Console.Write(new string(' ',k));
				Console.Write('\\');
				Console.Write(new string('@',(2*n+4)-2*k));
				Console.WriteLine('/');
			}
			Console.WriteLine(new string('=', (2 * n + 6)));
		}
	}
}
