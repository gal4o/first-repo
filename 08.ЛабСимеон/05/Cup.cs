using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
	class Cup
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n/2; i++)
			{
				Console.Write(new string('.', n+i));
				Console.Write(new string('#', 3*n-2*i));
				Console.WriteLine(new string('.', n + i));
			}
			for (int f = 0; f <= n/2; f++)
			{
				Console.Write(new string('.', n+n/2 + f));
				Console.Write('#');
				Console.Write(new string('.', 2*n -2* f-2));
				Console.Write('#');
				Console.WriteLine(new string('.', n+n/2+f));
			}
			Console.Write(new string('.', 2*n));
			Console.Write(new string('#', n));
			Console.WriteLine(new string('.', 2*n));
			for (int i = 1; i <= n/2; i++)
			{
				Console.Write(new string('.', 2*n -2));
				Console.Write(new string('#', n + 4));
				Console.WriteLine(new string('.', 2*n -2));
			}
			Console.Write(new string('.', (5*n-10)/2));
			Console.Write("D^A^N^C^E^");
			Console.WriteLine(new string('.', (5 * n - 10)/2));
			for (int i = 0; i <= n / 2; i++)
			{
				Console.Write(new string('.', 2 * n - 2));
				Console.Write(new string('#', n + 4));
				Console.WriteLine(new string('.', 2 * n - 2));
			}
		}
	}
}
