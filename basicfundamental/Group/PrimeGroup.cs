using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Group
{


    class PrimeGroup
    {
        public void prime(int num)
        {
            int temp = 1;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    temp = 0;
                    break;
                }
            }
            if (num < 0)
            {
                Console.WriteLine("You enter Wrong No");

            }
            else if (temp == 1)
            {
                Console.WriteLine("Prime No");
            }
        }

        static void Main(string[]args)
        {
            PrimeGroup p = new PrimeGroup();
            Console.WriteLine("Enter Your No");
            int num = int.Parse(Console.ReadLine());
            p.prime(num);
            
        }
    }
}
