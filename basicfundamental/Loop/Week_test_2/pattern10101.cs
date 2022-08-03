using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Loop.Week_test_2
{
    class pattern10101
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {

                    if (j % 2 == 0)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                    }
                }
                Console.WriteLine();
            }
              
            
        }
            
    }
}
