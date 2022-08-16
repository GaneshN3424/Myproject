using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray.ArrayTest
{
    class Buzz
    {
       static void Main(string[]args)
        {
            int b = 1;
            int f = 1;
            int bf = 1;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("buzzfizz");
                    bf++;
                }
                else if(i%5==0)
                {
                    Console.WriteLine("fizz");
                    f++;
                }
                else if(i%3==0)
                {
                    Console.WriteLine("buzz");
                    b++;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("buzz is printed  " + b + "  times");
            Console.WriteLine("fizz is printed  " + f + "  times");
            Console.WriteLine("buzzfizz is printed  " + bf + "  times");

        }
            
    }
}
