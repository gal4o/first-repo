using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Диамант
{
	class Диамант
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var lr = (n - 1) / 2;
			if (n % 2 == 0)
			{
				for (int i = 1; i < n / 2; i++)
				{
					var mid = n - 2 * lr - 2;
					if (mid >= 0)
					{
						Console.Write(new string('-', lr));
						Console.Write('*');
						Console.Write(new string('-', mid));
						Console.Write('*');
						Console.WriteLine(new string('-', lr));
						lr = lr - 1;
					}
					else
					{
						Console.Write(new string('-', lr));
						Console.Write('*');
						Console.WriteLine(new string('-', lr));
						lr = lr - 1;
					}
				}
				for (int i = 0; i < n / 2; i++)
				{
					var mid = n - 2 * lr - 2;
					if (mid >= 0)
					{
						Console.Write(new string('-', lr));
						Console.Write('*');
						Console.Write(new string('-', mid));
						Console.Write('*');
						Console.WriteLine(new string('-', lr));
						lr = lr + 1;
					}
					else
					{
						Console.Write(new string('-', lr));
						Console.Write('*');
						Console.WriteLine(new string('-', lr));
						lr = lr + 1;
					}
				}
			}
			else
			{
				for (int i = 1; i <= n / 2; i++)
				{
					var mid = n - 2 * lr - 2;
					if (mid >= 0)
					{
						Console.Write(new string('-', lr));
						Console.Write('*');
						Console.Write(new string('-', mid));
						Console.Write('*');
						Console.WriteLine(new string('-', lr));
						lr = lr - 1;
					}
					else
					{
						Console.Write(new string('-', lr));
						Console.Write('*');
						Console.WriteLine(new string('-', lr));
						lr = lr - 1;
					}
				}
				for (int i = 0; i <= n / 2; i++)
				{
					var mid = n - 2 * lr - 2;
					if (mid >= 0)
					{
						Console.Write(new string('-', lr));
						Console.Write('*');
						Console.Write(new string('-', mid));
						Console.Write('*');
						Console.WriteLine(new string('-', lr));
						lr = lr + 1;
					}
					else
					{
						Console.Write(new string('-', lr));
						Console.Write('*');
						Console.WriteLine(new string('-', lr));
						lr = lr + 1;
					}
				}
			}
		}
	}
}
