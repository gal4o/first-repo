using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ЩастливиЧисла
{
	class ЩастливиЧисла
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= 9; i++)
			{
				//var a1 = 1;
				for (int j = 1; j <= 9; j++)
				{
					//var a2 = 1;
					for (int k = 1; k <= 9; k++)
					{
						//var a3 = 1;
						for (int l = 1; l <= 9; l++)
						{
							//var a4 = 1;
							if (((i+j) == (k+l))&&(n%(i+j)==0))
							{
								Console.Write("{0}{1}{2}{3} ", i,j,k,l);
							}

						}
					}
				}
			}
			Console.WriteLine();
		}
	}
}
