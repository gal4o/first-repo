using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.ХотелскаСтая
{
	class ХотелскаСтая
	{
		static void Main(string[] args)
		{
			string month = Console.ReadLine();
			var night = int.Parse(Console.ReadLine());
			var studio = 0.00;
			var apartment = 0.00;

			switch (month)
			{
				case "May":
				case "October":
					studio = 50.00;
					apartment = 65.00;
						break;
				case "June":
				case "September":
					studio = 75.20;
					apartment = 68.70;
						break;
				case "July":
				case "August":
					studio = 76.00;
					apartment = 77.00;
						break;
			}
			var studMoney = studio * night;
			var apMoney = apartment * night;
			if (night>14)
			{
				apMoney = apMoney - (apMoney * 0.10);
			}
			if( (night>14)&&(month == "June")||(night>14)&&(month == "September") )
			{
				studMoney = studMoney - (studMoney * 0.20);
			}
			if( (night>14)&&((month=="May")||(month=="October")))
			{
				studMoney = studMoney - (studMoney * 0.30);
			}
			if (((night>7)&&(night<=14))&&((month =="May")||(month == "October")))
			{
				studMoney = studMoney - (studMoney * 0.05);
			}
			Console.WriteLine("Apartment: {0:f2} lv.", apMoney);
			Console.WriteLine("Studio: {0:f2} lv.", studMoney);
		}
	}
}
