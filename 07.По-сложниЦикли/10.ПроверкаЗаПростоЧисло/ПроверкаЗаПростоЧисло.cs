using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ПроверкаЗаПростоЧисло
{
	class ПроверкаЗаПростоЧисло
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			bool isPrime = true;
			for (int i = 2; i < n; i++)
			{

				if (n % i == 0)
				{
					isPrime = false;
					break;
				}
			}
			if (n<=1)
			{
				isPrime = false;
			}
			Console.WriteLine(isPrime?"Prime":"Not prime");
		}
	}
}
