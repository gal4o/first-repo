using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Факториел
{
	class Факториел
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var fact = 1;
			do
			{
				fact = fact* n;
				n--;
			} while (1<n);
			Console.WriteLine(fact);
		}
	}
}
