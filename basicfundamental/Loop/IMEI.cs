using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Loop
{
    class IMEI
    {
        static void Main(string []args)
        {
            Console.WriteLine("Enter 15 digit No");
            long sum = 0;
            long i = long.Parse(Console.ReadLine());
            while (i > 0)
            {
                long r=i%10;
                sum = sum + r;
                i = i / 10;

            }
            if(sum%10==0)
            {
                Console.WriteLine("Correct IMEI");
            }
            else
            {
                Console.WriteLine("Invalid no");
            }
               
        }
    }
}
