using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Loop.Week_test_2
{
    class Loop54321
    { 
        static void Main(string[]args)
        {
              for(int i=1;i<=5;i++)
            {
                for(int j=i;j>=1;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
        }
        
    }
}
