using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Шевица
{
	class Шевица
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			Console.Write(new string('.', (3*n)/2));
			Console.Write('x');
			Console.WriteLine(new string('.', (3 * n) / 2));
			Console.Write(new string('.', (3 * n-2) / 2));
			Console.Write("/x"+"\\");
			Console.WriteLine(new string('.', (3 * n-2) / 2));
			Console.Write(new string('.', (3 * n - 2) / 2));
			Console.Write("x|x");
			Console.WriteLine(new string('.', (3 * n - 2) / 2));
			for (int i = 0; i <= n/2; i++)
			{
				Console.Write(new string('.', (n-1)/2-i ));
				Console.Write(new string('x', n+i));
				Console.Write('|');
				Console.Write(new string('x', n + i));
				Console.WriteLine(new string('.', (n - 1) / 2-i));
			}
			for (int j= 1; j <= n/2; j++)
			{
				Console.Write(new string('.', j));
				Console.Write(new string('x', (3*n -1- 2*j)/2));
				Console.Write('|');
				Console.Write(new string('x', (3 * n - 1 - 2 * j) / 2));
				Console.WriteLine(new string('.', j));
			}
			Console.Write(new string('.', (3 * n - 2) / 2));
			Console.Write("/x" + "\\");
			Console.WriteLine(new string('.', (3 * n - 2) / 2));
			Console.Write(new string('.', (3 * n - 2) / 2));
			Console.Write("\\x/");
			Console.WriteLine(new string('.', (3 * n - 2) / 2));
			for (int i = 0; i <= n / 2; i++)
			{
				Console.Write(new string('.', (n - 1) / 2 - i));
				Console.Write(new string('x', n + i));
				Console.Write('|');
				Console.Write(new string('x', n + i));
				Console.WriteLine(new string('.', (n - 1) / 2 - i));
			}
			for (int j = 1; j <= n / 2; j++)
			{
				Console.Write(new string('.', j));
				Console.Write(new string('x', (3 * n - 1 - 2 * j) / 2));
				Console.Write('|');
				Console.Write(new string('x', (3 * n - 1 - 2 * j) / 2));
				Console.WriteLine(new string('.', j));
			}
			Console.Write(new string('.', (3 * n - 2) / 2));
			Console.Write("x|x");
			Console.WriteLine(new string('.', (3 * n - 2) / 2));
			Console.Write(new string('.', (3 * n - 2) / 2));
			Console.Write("\\x/");
			Console.WriteLine(new string('.', (3 * n - 2) / 2));
			Console.Write(new string('.', (3 * n) / 2));
			Console.Write('x');
			Console.WriteLine(new string('.', (3 * n) / 2));
		}
	}
}
