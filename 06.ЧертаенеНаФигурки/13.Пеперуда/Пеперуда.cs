﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Пеперуда
{
	class Пеперуда
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n-2; i++)
			{
				if (i%2 == 0)
				{
					Console.Write(new string('-', n-2));
					Console.Write("\u005C"+" /");
					Console.WriteLine(new string('-', n - 2));
				}
				else
				{
					Console.Write(new string('*', n - 2));
					Console.Write("\u005C" + " /");
					Console.WriteLine(new string('*', n - 2));
				}
			}
			Console.Write(new string(' ', n-1));
			Console.WriteLine('@');
			for (int i = 1; i <= n - 2; i++)
			{
				if (i % 2 == 0)
				{
					Console.Write(new string('-', n - 2));
					Console.Write("/ " + "\u005C");
					Console.WriteLine(new string('-', n - 2));
				}
				else
				{
					Console.Write(new string('*', n - 2));
					Console.Write("/ " + "\u005C");
					Console.WriteLine(new string('*', n - 2));
				}
			}
		}
	}
}
