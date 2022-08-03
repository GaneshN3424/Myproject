using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Loop
{
    class Table
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter Number");
            int sum = 1;
            int num1 = int.Parse(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                sum = num1* i;
                Console.WriteLine(sum);
            }
        }
    }
}
