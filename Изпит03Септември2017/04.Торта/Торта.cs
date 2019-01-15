using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Торта
{
	class Торта
	{
		static void Main(string[] args)
		{
			int shirina = int.Parse(Console.ReadLine());
			int lenght = int.Parse(Console.ReadLine());
			int cakes = 0;
			
			do
			{
				try
				{
					int takeCake = int.Parse(Console.ReadLine());
					cakes += takeCake;
				}
				catch 
				{
					break;
				}

			} while (cakes<=shirina*lenght);

			if (shirina*lenght>cakes)
			{
				Console.WriteLine("{0} pieces are left.", shirina*lenght-cakes);
			}
			else
			{
				Console.WriteLine("No more cake left! You need {0} pieces more.", cakes-shirina*lenght);
			}
		}
	}
}
