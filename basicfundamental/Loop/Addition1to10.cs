using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Loop
{
    class Addition1to10
    {
        
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)   //for(inti; condi;change  i=1; i++/i+1; i<=10  ++i, i++
                                            //a+b a=10
                                            //++a+b 
                                            //a++(+b)
            {
                sum = sum + i;

            }
            Console.WriteLine(sum);
        }
    }
}
