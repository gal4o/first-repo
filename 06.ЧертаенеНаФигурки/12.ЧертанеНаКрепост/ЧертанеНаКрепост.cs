using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ЧертанеНаКрепост
{
	class ЧертанеНаКрепост
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			Console.Write('/');
			Console.Write(new string('^',n/2));
			Console.Write( "\u005C");
			Console.Write(new string('_', (2 * n) - 4 -2*( n / 2)));
			Console.Write('/');
			Console.Write(new string('^', n / 2));
			Console.WriteLine("\u005C");
			for (int i = 1; i < n-2; i++)
			{
				Console.Write('|');
				Console.Write(new string(' ', 2*n-2));
				Console.WriteLine('|');
			}
			Console.Write('|');
			Console.Write(new string(' ', n/2+1));
			Console.Write(new string('_', 2*n-4-2*(n/2)));
			Console.Write(new string(' ', n/2+1));
			Console.WriteLine('|');

			Console.Write("\u005C");
			Console.Write(new string('_', n / 2));
			Console.Write('/');
			Console.Write(new string(' ', (2 * n) - 4 - 2 * (n / 2)));
			Console.Write("\u005C");
			Console.Write(new string('_', n / 2));
			Console.WriteLine('/');
		}
	}
}
