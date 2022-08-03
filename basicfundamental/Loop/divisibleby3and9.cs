using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Loop
{
    class divisibleby3and9
    {
        static void Main(string[] args)
        {

            for (int num1 = 1; num1 <= 15; num1++)
            {
                if (num1 % 3 == 0 && num1%9==0)
                {
                    break;
                }
                Console.WriteLine(num1);


            }
        }
    }
}

