using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Триъгълник55Звезди
{
	class Триъгълник55звезди
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Console.Write("$");
			for (int i =0 ; i <=n; i++)
			{
				Console.Write(" $");
			}
			Console.WriteLine();
		}
	}
}
