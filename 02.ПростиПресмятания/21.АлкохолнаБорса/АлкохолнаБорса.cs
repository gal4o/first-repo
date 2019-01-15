using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.АлкохолнаБорса
{
	class АлкохолнаБорса
	{
		static void Main(string[] args)
		{
			var wisP = double.Parse(Console.ReadLine());
			var beer = double.Parse(Console.ReadLine());
			var vine = double.Parse(Console.ReadLine());
			var rakia = double.Parse(Console.ReadLine());
			var wis = double.Parse(Console.ReadLine());

			var rakiaP = wisP * 0.50;
			var beerP = rakiaP-(rakiaP*0.80) ;
			var vineP = rakiaP-(rakiaP*0.40);

			var need = wis * wisP + beer * beerP + vine * vineP + rakia * rakiaP;

			Console.WriteLine("{0:f2}", need);
		}
	}
}
