using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Conditonal
{
    class Divisibleby5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No.");
            int num1 = int.Parse(Console.ReadLine());
             if(num1%5==0)
              {
                 Console.WriteLine("No. is divisible by 5");
              }
             else
              {
                Console.WriteLine("No.is Not divisible by 5");

              }
        }
    }
}
