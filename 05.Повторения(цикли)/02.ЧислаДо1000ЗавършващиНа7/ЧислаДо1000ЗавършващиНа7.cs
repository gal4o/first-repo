using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ЧислаДо1000ЗавършващиНа7
{
    class ЧислаДо1000ЗавършващиНа7
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 1001; i++)
            {
                if (i%10==7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
