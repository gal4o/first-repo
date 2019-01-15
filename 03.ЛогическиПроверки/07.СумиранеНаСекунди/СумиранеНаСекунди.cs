using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.СумиранеНаСекунди
{
    class СумиранеНаСекунди
    {
        static void Main(string[] args)
        {
            int sec1 = int.Parse(Console.ReadLine());
            int sec2 = int.Parse(Console.ReadLine());
            int sec3 = int.Parse(Console.ReadLine());

            int sumsec = sec1 + sec2 + sec3;
            var min = 0;
            var sec = 0;

            if (sumsec < 60)
            {
                min = 0;
            }
            else if (sumsec<120)
            {
                min = 1;
            }
            else
            {
                min = 2;
            }

            sec = sumsec - min * 60;
            Console.Write(min + ":");
            if (sec<10)
            {
                Console.WriteLine("0"+sec);
            }
            else
            Console.WriteLine(sec);
        }
    }
}
