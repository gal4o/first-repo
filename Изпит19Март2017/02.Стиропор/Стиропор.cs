using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Стиропор
{
	class Стиропор
	{
		static void Main(string[] args)
		{
			var bujet = double.Parse(Console.ReadLine());
			var hause = double.Parse(Console.ReadLine());
			var windows = int.Parse(Console.ReadLine());
			var stirPack = double.Parse(Console.ReadLine());
			var prizePack = double.Parse(Console.ReadLine());
			var needStir = (hause - (windows * 2.4)) + (hause - (windows * 2.4)) * 0.10;
			var needPack = needStir / stirPack;
			var needMonney = Math.Ceiling(needPack) * prizePack;
			if (bujet>=needMonney)
			{
				Console.WriteLine("Spent: {0:f2}", needMonney);
				Console.WriteLine("Left: {0:f2}", bujet-needMonney);
			}
			else
			{
				Console.WriteLine("Need more: {0:f2}", needMonney-bujet);
			}
		}
	}
}
