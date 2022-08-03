using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.WeekTest
{
    class No1to100
    {
        static void Main(string[] args)
        {

            for (int num1 = 1; num1 <= 100; num1++)
            {
                if (num1 % 5 == 0 || num1 % 10 == 0)
                {
                    continue;
                }
                Console.WriteLine(num1);


            }
        }
    }
}
