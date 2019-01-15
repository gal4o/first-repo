using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.ТръбиВБасеин
{
	class ТръбиВБасеин
	{
		static void Main(string[] args)
		{
			var v = int.Parse(Console.ReadLine());
			var p1 = int.Parse(Console.ReadLine());
			var p2 = int.Parse(Console.ReadLine());
			decimal n = decimal.Parse(Console.ReadLine());
			

			var full = n * p1 + n * p2;
			if (full <=v )
			{
				Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Floor(full*100/v), Math.Floor(n*p1*100/full), Math.Floor(n*p2*100/full));
			}
			else
			{
				Console.WriteLine("For {0} hours the pool overflows with {1:f1} liters.", n, full-v);
			}
		}
	}
}
