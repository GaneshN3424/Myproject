using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.week_test_3
{
    class Pattern1234567
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int c = 1;
            for (int i = n; i > 1; i--)
            {
               // c++;
                for (int j = i; j >= 2; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * (n - i + 1) - 1; k++)
                {
                     while(c<=n)
                    {
                        Console.Write(c);
                        c++;
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
