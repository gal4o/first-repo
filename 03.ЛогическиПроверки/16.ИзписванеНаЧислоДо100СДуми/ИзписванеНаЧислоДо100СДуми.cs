using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ИзписванеНаЧислоДо100СДуми
{
	class ИзписванеНаЧислоДо100СДуми
	{
		static void Main(string[] args)
		{
			var num = int.Parse(Console.ReadLine());

			if (num == 0)
			{
				Console.WriteLine("zero");
			}
			else if (num == 10)
			{
				Console.WriteLine("ten");
			}
			else if (num == 11)
			{
				Console.WriteLine("eleven");
			}
			else if (num == 12)
			{
				Console.WriteLine("twelve");
			}
			else if (num == 13)
			{
				Console.WriteLine("thirteen");
			}
			else if (num == 100)
			{
				Console.WriteLine("one hundred");
			}
			else if (num>100 ||num<0)
			{
				Console.WriteLine("invalid number");
			}
			else
			{
				if (num / 10 == 2)
				{
					Console.Write("twenty ");
				}
				else if (num / 10 == 3)
				{
					Console.Write("thirty ");
				}
				else if (num / 10 == 4)
				{
					Console.Write("forty ");
				}
				else if (num / 10 == 5)
				{
					Console.Write("fifty ");
				}
				else if (num / 10 == 6)
				{
					Console.Write("sixty ");
				}
				else if (num / 10 == 7)
				{
					Console.Write("seventy ");
				}
				else if (num / 10 == 8)
				{
					Console.Write("eighty ");
				}
				else if (num / 10 == 9)
				{
					Console.Write("ninety ");
				}

				if (num % 10 == 1)
				{
					Console.Write("one");
				}
				else if (num % 10 == 2)
				{
					Console.Write("two");
				}
				else if (num % 10 == 3)
				{
					Console.Write("three");
				}
				else if (num % 10 == 4)
				{
					Console.Write("four");
				}
				else if (num % 10 == 5)
				{
					Console.Write("five");
				}
				else if (num % 10 == 6)
				{
					Console.Write("six");
				}
				else if (num % 10 == 7)
				{
					Console.Write("seven");
				}
				else if (num % 10 == 8)
				{
					Console.Write("eight");
				}
				else if (num % 10 == 9)
				{
					Console.Write("nine");
				}

				if (num / 10 == 1)
				{
					Console.WriteLine("teen");
				}
			}
		}
	}
}
