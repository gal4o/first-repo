using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.ОперацииМеждуЧисла
{
	class ОперацииМеждуЧисла
	{
		static void Main(string[] args)
		{
			var n1 = double.Parse(Console.ReadLine());
			var n2 = double.Parse(Console.ReadLine());
			string oper = Console.ReadLine();
			double result = 0;
			string odd = null;

			if ((oper == "+") || (oper == "-") || (oper == "*"))
			{
				switch (oper)
				{
					case "+": result = n1 + n2; break;
					case "-": result = n1 - n2; break;
					case "*": result = n1 * n2; break;
				}
				if (result % 2 == 0)
				{
					odd = "even";
				}
				else
				{
					odd = "odd";
				}
				Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, oper, n2, result, odd);
			}
			else if (oper == "/")
			{
				if (n2 == 0)
				{
					Console.WriteLine("Cannot divide {0} by zero", n1);
				}
				else
				{
					result = n1 / n2;
					Console.WriteLine("{0} / {1} = {2:f2}", n1, n2, result);
				}
			}
			else if (oper == "%")
			{
				if (n2 == 0)
				{
					Console.WriteLine("Cannot divide {0} by zero", n1);
				}
				else
				{
					result = n1 % n2;
					Console.WriteLine("{0} % {1} = {2}", n1, n2, result);
				}
			}
		}
	}
}
