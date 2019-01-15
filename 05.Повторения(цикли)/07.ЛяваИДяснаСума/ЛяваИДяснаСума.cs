using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ЛяваИДяснаСума
{
    class ЛяваИДяснаСума
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum1 = 0;
            var sum2 = 0;

            for (int i = 1; i <=n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum1 += num;
            }
            for (int i = n+1; i <= 2*n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum2 += num;
            }
            if (sum1==sum2)
            {
                Console.WriteLine("Yes, sum = " + sum1);
            }
            else
            {
                var sum = Math.Abs(sum1 - sum2);
                Console.WriteLine("No, diff = " + sum);
            }
        }
    }
}
