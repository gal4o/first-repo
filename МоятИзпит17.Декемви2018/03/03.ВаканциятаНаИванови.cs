using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
	class Program
	{
		static void Main(string[] args)
		{
			var countN = int.Parse(Console.ReadLine());
			string plase = Console.ReadLine();
			string transport = Console.ReadLine();
			var old = 0.00;
			var child = 0.00;

			if (plase == "Miami")
			{
				if (countN <=10)
				{
					old = 24.99;
					child = 14.99;
				}
				else if (countN<=15)
				{
					old = 22.99;
					child = 11.99;
				}
				else
				{
					old = 20.00;
					child = 10.00;
				}
			}
			else if (plase == "Canary Islands")
			{
				if (countN <= 10)
				{
					old = 32.50;
					child = 28.50;
				}
				else if (countN <= 15)
				{
					old = 30.50;
					child = 25.60;
				}
				else
				{
					old = 28.00;
					child = 22.00;
				}
			}
			else
			{
					if (countN <= 10)
					{
						old = 42.99;
						child = 39.99;
					}
					else if (countN <= 15)
					{
						old = 41.00;
						child = 36.00;
					}
					else
					{
						old = 38.50;
						child = 32.40;
					}
			}
			var prest = (2 * old + 3 * child)*countN + ((2 * old + 3 * child)*countN) * 0.25;
			var oldTransport = 0.00;
			var childTransport = 0.00;
			switch (transport)
			{
				case "train": oldTransport = 22.30;
					childTransport = 12.50;
					break;
				case "bus": oldTransport = 45.00;
					childTransport = 37.00;
					break;
				case "airplane": oldTransport = 90.00;
					childTransport = 68.50;
					break;
			}
			var transportAll = 2 * oldTransport + 3 * childTransport;
			Console.WriteLine("{0:f3}", prest+transportAll);
		}
	}
}
