using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.БлаготворителнаКампания
{
	class БлаготворителнаКампания
	{
		static void Main(string[] args)
		{
			
var days = int.Parse(Console.ReadLine());
			var workers = int.Parse(Console.ReadLine());
			var cakesD = int.Parse(Console.ReadLine());
			var wafersD = int.Parse(Console.ReadLine());
			var pancakesD = int.Parse(Console.ReadLine());


			var cakesP = (days * workers * cakesD)*45.00;
			var wafersP = (days * workers * wafersD)*5.80;
			var panacakesP = (days * workers * pancakesD)*3.20;
			var free = (cakesP + wafersP + panacakesP)-(cakesP + wafersP + panacakesP)*0.125;

			Console.WriteLine("{0:f2}", free);

		}
	}
}
