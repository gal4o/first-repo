using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ОграднаМрежа
{
	class ОграднаМрежа
	{
		static void Main(string[] args)
		{
			var lenghtPlace = int.Parse(Console.ReadLine());
			var shirinaPlace = int.Parse(Console.ReadLine());
			var hightMreja = double.Parse(Console.ReadLine());
			var prizeMreja = double.Parse(Console.ReadLine());
			var wegtMreja = double.Parse(Console.ReadLine());

			var lenghtMreja = 2 * (lenghtPlace + shirinaPlace);
			Console.WriteLine(lenghtMreja);
			Console.WriteLine("{0:f2}", lenghtMreja*prizeMreja);
			Console.WriteLine("{0:f3}", lenghtMreja*hightMreja*wegtMreja);
		}
	}
}
