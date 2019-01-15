using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ВъншноОценяване
{
	class ВъншноОценяване
	{
		static void Main(string[] args)
		{
			var students = int.Parse(Console.ReadLine());
			
			int markPoor = 0;
			int markSatisfactory = 0;
			int markGood = 0;
			int markVeryGood = 0;
			int markExcellent = 0;

			for (int i = 1; i <= students; i++)
			{
				double points = double.Parse(Console.ReadLine());
				if (points<22.5)
				{
					markPoor +=1;
				}
				else if (points<40.5)
				{
					markSatisfactory += 1;
				}
				else if (points<58.5)
				{
					markGood += 1;
				}
				else if (points<76.5)
				{
					markVeryGood += 1;
				}
				else
				{
					markExcellent +=1;
				}
			}
			Console.WriteLine("{0:f2}% poor marks", (100.00/students)*markPoor);
			Console.WriteLine("{0:f2}% satisfactory marks", (100.00/students)*markSatisfactory);
			Console.WriteLine("{0:f2}% good marks", (100.00/students)*markGood);
			Console.WriteLine("{0:f2}% very good marks", (100.00/students)*markVeryGood);
			Console.WriteLine("{0:f2}% excellent marks", (100.00/students)*markExcellent);

		}
	}
}
