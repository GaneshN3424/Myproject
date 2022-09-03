using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Prorigo._2ndSept
{
    class Prime1to100
    {
        static  void Display()
        {
            for(int i = 2; i <= 100; i++)
            {
                int p=0;   
                for(int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        p++;
                    }
                }
                if (p == 0)
                    Console.Write(i + " ");
                
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Prime no between 1 to 100");
            Display();
        }
    }
}
