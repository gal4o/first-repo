using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
	class ИмеНаГрупа
	{
		static void Main(string[] args)
		{
			char sumbol1 = char.Parse(Console.ReadLine());
			char sumbol2 = char.Parse(Console.ReadLine());
			char sumbol3 = char.Parse(Console.ReadLine());
			char sumbol4 = char.Parse(Console.ReadLine());
			int sumbol5 = int.Parse(Console.ReadLine());
			int count = 0;
			for (char i = 'A'; i <= sumbol1; i++)
			{
				char first = i;
				for (char f = 'a'; f <= sumbol2; f++)
				{
					char sec = f;
					for (char k = 'a'; k <= sumbol3; k++)
					{
						char tri = k;
						for (char l = 'a'; l <= sumbol4; l++)
						{
							char four = l;
							for (int m = 0; m <= sumbol5; m++)
							{
								int five = m;
								count += 1;
							}
						}
					}
				}
			}
			Console.WriteLine(count - 1);
		}
	}
}
