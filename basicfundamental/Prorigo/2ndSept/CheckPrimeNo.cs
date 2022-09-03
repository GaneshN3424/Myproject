using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Prorigo._2ndSept
{
    class CheckPrimeNo
    {
        static bool Display(int a)
        {
            int flag = 0;
            for(int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool ch=Display(num);
            if (ch)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
