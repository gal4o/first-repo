using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ПирамидаОтЧисла
{
	class ПирамидаОтЧисла
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			int num = 1;
			for (int r = 1; r <= n; r++)
			{
				for (int c = 1; c <= r; c++)
				{
					Console.Write(num +" ");
					num++;
					if (num > n)
					{
						break;
					}
				}
				Console.WriteLine();
				if (num > n)
				{
					break;
				}
			}
		}
	}
}
