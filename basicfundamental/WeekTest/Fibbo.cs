using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.WeekTest
{
    class Fibbo
    {
        
      static void Main(string[] args)
        {
            int a = 0, b = 1,c=0;
            Console.Write(a + " " + b + " ");
            for(int i=2;i<=18;i++)
            {
                c = a + b;
                Console.Write(c+ " ");
                a = b;
                b = c;
                
            }
        }
    }
}
