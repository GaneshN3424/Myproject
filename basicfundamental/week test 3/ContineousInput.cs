using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.week_test_3
{
    class ContineousInput
    {

        static void Main(string[]args)
        {
            for(; ; )
            {
                int num = int.Parse(Console.ReadLine());
                if(num==0)
                {
                    Console.WriteLine("you Enter Zero");
                    break;
                }
                else
                {
                    Console.WriteLine("enter Another number");
                }
            }
        }
    }
}
