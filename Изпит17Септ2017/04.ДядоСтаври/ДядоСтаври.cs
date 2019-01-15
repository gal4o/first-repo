using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ДядоСтаври
{
	class ДядоСтаври
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			double litersAll = 0;
			double degrAll = 0;
			for (int i = 1; i <= n; i++)
			{
				double liter = double.Parse(Console.ReadLine());
				double degrees = double.Parse(Console.ReadLine());
				litersAll += liter;
				degrAll += degrees * liter;
			}
			double degr = degrAll / litersAll;
			Console.WriteLine("Liter: {0:f2}", litersAll);
			Console.WriteLine("Degrees: {0:f2}", degr);
			if (degr<38.00)
			{
				Console.WriteLine("Not good, you should baking!");
			}
			else if (degr<42.00)
			{
				Console.WriteLine("Super!");
			}
			else
			{
				Console.WriteLine("Dilution with distilled water!");
			}
		}
	}
}
