using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Loop
{
    class Armstron
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter Number");
            int num1 = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = num1;
            while (num1 > 0)
            {
                int r = num1 % 10;
                sum = sum + r * r * r;
                num1 = num1 / 10;
            }
           // Console.WriteLine(sum); 
                if (temp==sum)
                {
                    Console.WriteLine("No is Armstrong");
                }
                else
                {
                    Console.WriteLine("No is Not Armstrong");
                }
            
        }
    }
}
