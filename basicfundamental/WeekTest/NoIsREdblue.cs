using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.WeekTest
{
    class NoIsREdblue
    {
        static void Main(string[]args)
        {
            for(int i=1;i<=100;i++)
            {
                if(3%i==0 && 5%i==0)
                {
                    Console.WriteLine("RedBlue");
                }
                else if(3%i==0)
                {
                    Console.WriteLine("Red");

                }else if(5%i==0)
                {
                    Console.WriteLine("blue");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
