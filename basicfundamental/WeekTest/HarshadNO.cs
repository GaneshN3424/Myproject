using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.WeekTest
{
    class HarshadNO
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int a = n;
            while(n>0)
            {
                int r = n % 10;
                sum = sum + r;
                n = n / 10;
            }
           
            if (a % sum == 0)
            {
                Console.WriteLine("Harshad Number");
            }
        
        }
    }
}
