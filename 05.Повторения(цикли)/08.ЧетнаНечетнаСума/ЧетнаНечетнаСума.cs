using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ЧетнаНечетнаСума
{
    class ЧетнаНечетнаСума
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sumOdd = 0;
            var sumEven = 0;

            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (i%2 == 0)
                {
                    sumOdd += num;
                }
                else
                {
                    sumEven += num;
                }
            }
            if (sumOdd == sumEven)
            {
                Console.WriteLine("Yes, Sum = " + sumEven);
            }
            else
            {
                Console.WriteLine("No, Diff = " + Math.Abs(sumEven-sumOdd));
            }
        }
    }
}
