using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ПресмятанеСДати
{
    class ПресмятанеСДати
    {
        static void Main(string[] args)
        {
            string indate = Console.ReadLine();
            var ind = DateTime.ParseExact(indate, "dd - MM - yyyy", null);

            DateTime outdate = ind.AddDays(1000); 

            Console.WriteLine(outdate.ToString("dd-MM-yyyy"));
        }
    }
}
