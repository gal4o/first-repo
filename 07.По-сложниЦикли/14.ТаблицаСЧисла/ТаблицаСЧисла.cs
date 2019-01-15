using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ТаблицаСЧисла
{
	class ТаблицаСЧисла
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			for (int r = 0; r < n; r++)
			{
				for (int c = 0; c < n; c++)
				{
					int num = r + c + 1;
					if (num<=n)
					{
						Console.Write(num + " ");

					}
					else
					{
						int num2 = (2 * n) - num;
						Console.Write(num2+" ");
					}
				}
				Console.WriteLine();
			}
		}
	}
}
