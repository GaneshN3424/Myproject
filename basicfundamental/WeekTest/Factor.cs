using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.WeekTest
{
    class Factor
    {
        static void Main(string[]args)
        {
            int i = int.Parse(Console.ReadLine());
            int fact = 1;
            for(int num=1;num<=i;num++)
            {
                fact = fact * num;
                Console.WriteLine(fact);
                fact = 1;
            }
        }
    }
}
