using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.StringDEMO
{
    class Coprime
    {

        static void prime(int a,int b)
        {
            int count = 0;
            for(int i = 1; i <= a; i++)
            {
              if (b % i == 0 && a % i == 0)
              {
                    count++;
              }   
            }
            if(count ==1)
            {
                Console.WriteLine("No is coprime");
            }
        }

        static void Main(string[]args)
        {
            Console.WriteLine("enter number");
            int num1 = int.Parse(Console.ReadLine());
            
        }
    }
}
