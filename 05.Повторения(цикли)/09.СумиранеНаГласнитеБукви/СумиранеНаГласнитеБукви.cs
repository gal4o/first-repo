﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.СумиранеНаГласнитеБукви
{
    class СумиранеНаГласнитеБукви
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a':sum += 1; break;
                    case 'e': sum += 2; break;
                    case 'i': sum += 3; break;
                    case 'o': sum += 4; break;
                    case 'u': sum += 5; break;
                    default:
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
