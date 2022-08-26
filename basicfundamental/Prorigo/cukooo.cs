using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Prorigo
{
    class cukooo
    {
        static int Display(int a)
        {
            if (a == 1)
            {
                return 0;

            }
            else if (a == 2)
            {
                return 1;
            }
            else
                return 1 * Display(a - 1) + 2 * Display(a - 2) + 3 * 1;

        }
        static void Main(string[]args)
        {
            int num1 = int.Parse(Console.ReadLine());
           int num2= Display(num1);
            Console.WriteLine(num2);
        }
    }
}
