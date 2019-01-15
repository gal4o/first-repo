using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.СпециалниЧисла
{
	class СпециалниЧисла
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			for (int a1 = 1; a1 <= 9; a1++)
			{
				if (n%a1==0)
				{
					for (int a2 = 1; a2 <= 9; a2++)
					{
						if (n % a2 == 0)
						{
							for (int a3 = 1; a3 <= 9; a3++)
							{
								if (n % a3 == 0)
								{
									for (int a4 = 1; a4 <= 9; a4++)
									{
										if (n % a4 == 0)
										{
											Console.Write("{0}{1}{2}{3} ", a1, a2, a3, a4);
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
}
