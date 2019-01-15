using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());

			Console.Write('|');
			Console.Write(new string('-',2*n ));
			Console.WriteLine('|');
			Console.Write('|');
			Console.Write(new string('*', 2 * n));
			Console.WriteLine('|');
			Console.Write('|');
			Console.Write(new string('-', 2 * n));
			Console.WriteLine('|');

			for (int i = 1; i < n; i++)
			{
				Console.Write('|');
				Console.Write(new string('-', (2 * n - 2*i) / 2));
				Console.Write(new string('~', 2*i));
				Console.Write(new string('-', (2*n-2*i)/2));
				Console.WriteLine('|');
			}
			for (int j= 2; j < n; j++)
			{
				Console.Write('|');
				Console.Write(new string('-', j));
				Console.Write(new string('~', 2*n-2*j));
				Console.Write(new string('-', j));
				Console.WriteLine('|');
			}
			for (int i = 1; i <= n+3; i++)
			{
				if (i==n/2+1)
				{
					Console.Write(new string('-', i-1));
					Console.Write('\\');
					Console.Write(new string('.', (2 * n -4)/2));
					Console.Write("MERRY");
					Console.Write(new string('.', (2 * n - 4) / 2));
					Console.WriteLine('\\');
				}
				else if (i==n/2+3)
				{
					Console.Write(new string('-', i-1));
					Console.Write('\\');
					Console.Write(new string('.', (2 * n - 4) / 2));
					Console.Write("X-MAS");
					Console.Write(new string('.', (2 * n - 4) / 2));
					Console.WriteLine('\\');
				}
				else if (i==n+3)
				{
					Console.Write(new string('-', i-1));
					Console.Write('\\');
					Console.Write(new string('_', 2*n+1));
					Console.WriteLine(')');
				}
				else
				{
					Console.Write(new string('-', i-1));
					Console.Write('\\');
					Console.Write(new string('.', 2 * n + 1));
					Console.WriteLine('\\');
				}
			}

		}
	}
}
