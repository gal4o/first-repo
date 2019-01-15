using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.СлънчевиОчила
{
	class СлънчевиОчила
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			Console.Write(new string('*', 2*n));
			Console.Write(new string(' ', n));
			Console.Write(new string('*', 2*n));
			Console.WriteLine();

			for (int r = 1; r < n-1; r++)
			{
				if (n == 3)
				{
					Console.Write("*");
					Console.Write(new string('/', 2 * n - 2));
					Console.Write("*");
					Console.Write(new string('|', n));
					Console.Write("*");
					Console.Write(new string('/', 2 * n - 2));
					Console.WriteLine("*");
				}
				else if (n==4)
				{
					if (r == n / 2-1)
					{
						Console.Write("*");
						Console.Write(new string('/', 2 * n - 2));
						Console.Write("*");
						Console.Write(new string('|', n));
						Console.Write("*");
						Console.Write(new string('/', 2 * n - 2));
						Console.WriteLine("*");
					}
					else
					{
						Console.Write("*");
						Console.Write(new string('/', 2 * n - 2));
						Console.Write("*");
						Console.Write(new string(' ', n));
						Console.Write("*");
						Console.Write(new string('/', 2 * n - 2));
						Console.WriteLine("*");
					}

				}
				else
				{
					if (n % 2 == 0)
					{
						if (r == (n / 2 - 1))
						{
							Console.Write("*");
							Console.Write(new string('/', 2 * n - 2));
							Console.Write("*");
							Console.Write(new string('|', n));
							Console.Write("*");
							Console.Write(new string('/', 2 * n - 2));
							Console.WriteLine("*");
						}
						else
						{
							Console.Write("*");
							Console.Write(new string('/', 2 * n - 2));
							Console.Write("*");
							Console.Write(new string(' ', n));
							Console.Write("*");
							Console.Write(new string('/', 2 * n - 2));
							Console.WriteLine("*");
						}
					}
					else
					{
						if (r == (n / 2))
						{
							Console.Write("*");
							Console.Write(new string('/', 2 * n - 2));
							Console.Write("*");
							Console.Write(new string('|', n));
							Console.Write("*");
							Console.Write(new string('/', 2 * n - 2));
							Console.WriteLine("*");
						}
						else
						{
							Console.Write("*");
							Console.Write(new string('/', 2 * n - 2));
							Console.Write("*");
							Console.Write(new string(' ', n));
							Console.Write("*");
							Console.Write(new string('/', 2 * n - 2));
							Console.WriteLine("*");
						}
					}
				}
			}

			Console.Write(new string('*', 2 * n));
			Console.Write(new string(' ', n));
			Console.Write(new string('*', 2 * n));
			Console.WriteLine();
		}
	}
}
