using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.МагическиЧисла
{
	class МагическиЧисла
	{
		static void Main(string[] args)
		{
			var mag = int.Parse(Console.ReadLine());
			var n = 1;

			for (int a1 = 1; a1 <= 9; a1++)
			{
				for (int a2 = 1; a2 <= 9; a2++)
				{
					for (int a3 = 1; a3 <= 9; a3++)
					{
						for (int a4 = 1; a4 <= 9; a4++)
						{
							for (int a5 = 1; a5 <= 9; a5++)
							{
								for (int a6 = 1; a6 <= 9; a6++)
								{
									n = a1 * a2 * a3 * a4 * a5 * a6;
									if (n==mag)
									{
										Console.Write("{0}{1}{2}{3}{4}{5} ",a1,a2,a3,a4,a5,a6);
									}
								}
							}
						}
					}
				}
			}

		}
	}
}
