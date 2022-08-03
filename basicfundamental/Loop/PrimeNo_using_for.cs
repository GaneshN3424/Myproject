using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Loop
{
    class PrimeNo_using_for
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter number");
            int num1 = int.Parse(Console.ReadLine());
            int temp = 0;
            for(int i=2;i<num1;i++)
            {
                if(num1%i==0)
                {
                    temp = 1;
                    break;

                }
            }
            if(temp==0)
            {
                Console.WriteLine("No is Prime");

            }
            else
            {
                Console.WriteLine("No is Not Prime");
            }

        }
    }
}
