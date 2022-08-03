using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Loop
{
    class SkipNodivisibleby3
    {
        static void Main(string[]args)
        {
            
            for(int num1=1; num1<=30;num1++)
            {
                if(num1%3==0)
                {
                    continue;
                }
                Console.WriteLine(num1);
                

            }
        }
    }
}
