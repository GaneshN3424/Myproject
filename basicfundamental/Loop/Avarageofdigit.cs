using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Loop
{
    class Avarageofdigit
    {
      static void Main(string[]args)
        {
            Console.WriteLine("enter Number");
            int num1 = int.Parse(Console.ReadLine());
            int sum = 0;
            int num2 = 0;
            while(num1>0)
            {
                int r = num1 % 10;
                sum = sum + r;
                num2 = num2 + 1;
                num1 = num1 / 10;
            }
            int num = sum / num2;
            Console.WriteLine(num);
        }
    }
}
