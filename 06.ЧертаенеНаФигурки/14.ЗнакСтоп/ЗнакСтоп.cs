using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ЗнакСтоп
{
	class ЗнакСтоп
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var count = 2*n;

			Console.Write(new string('.', n+1));
			Console.Write(new string('_', count+1));
			Console.WriteLine(new string('.', n + 1));

			for (int i = n; i >= 1; i--)
			{
				Console.Write(new string('.', i));
				Console.Write("//");
				Console.Write(new string('_', count-1));
				Console.Write("\\"+"\\");
				Console.WriteLine(new string('.', i));
				count = count + 2;
			}
			Console.Write("//");
			Console.Write(new string('_', count/2-3));
			Console.Write("STOP!");
			Console.Write(new string('_', count/2-3));
			Console.WriteLine("\\"+"\\");

			for (int i =0 ; i < n; i++)
			{
				Console.Write(new string('.', i));
				Console.Write("\\"+"\\");
				Console.Write(new string('_', count-1));
				Console.Write("//");
				Console.WriteLine(new string('.', i));
				count = count - 2;
			}

		}
	}
}
