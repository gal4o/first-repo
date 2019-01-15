using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ПроверкаЗаЧетноЧисло
{
	class ПроверкаЗаЧетно
	{
		static void Main(string[] args)
		{
			var n = Console.ReadLine();
			while (true)
			{
				try
				{
					int a = int.Parse(n);
					if (a % 2 == 0)
					{
						Console.WriteLine("Even number entered: {0}", a);
						break;
					}
					else
					{
						Console.WriteLine("The number is not even");
					}
					n = Console.ReadLine();
				}
				catch (Exception)
				{
					Console.WriteLine("Invalid number");
					throw;
				}
				
			}
		}
	}
}
