using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galq
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Здрасти Пиленце,");
			Console.WriteLine("Много те обичам!");
			Console.WriteLine("Каквао ще кажеш?");

			string antw = Console.ReadLine();
			if ( antw == "И аз")
			{
				Console.WriteLine();
				Console.WriteLine(" " + "*" + " " + "*");
				Console.WriteLine("*" + "*" + "*" + "*" + "*");
				Console.WriteLine(" " + "*" + "*" + "*");
				Console.WriteLine(" " + " " + "*");
			}
			else
			{
				Console.Beep();
				Console.WriteLine("Грешкааа");
				Console.WriteLine("Опитай пак");

			}
		}
	}
}
