using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Loop.Week_test_2
{
    class frequency_of_digit
    {
        int fre(long n, int d)
        {
            int c = 0;

            while(n>0)
            {
                if (n%10==d)
                {
                    c++;
                }
                n = n / 10;
            }
            return c;
             
        }

        static void Main(string[]args)
        {
            frequency_of_digit m = new frequency_of_digit();
            int c = m.fre(9890342438, 4);

            Console.WriteLine(c);
        }


    }
}
