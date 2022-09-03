using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Prorigo._2ndSept
{
    class MultiplicationWithout
    {
        public static int Display(int a,int b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }
            else
            {
                int c = 0;
                for(int i = 1; i <= b; i++)
                {
                    c=c+a;
                }
                return c;
            }

        }
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
           int num= Display(num1, num2);
            Console.Write(num);
        }
    }
}
