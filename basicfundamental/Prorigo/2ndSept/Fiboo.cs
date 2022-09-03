using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Prorigo._2ndSept
{
    class Fiboo
    {
        static void Display(int n)
        {
            int a = 0;
            Console.Write(a + " ");
            int b = 1;
            Console.Write(b + " ");
            int c = 0;
            for(int i = 0; i < n ; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;

            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter nth term");
            int num = int.Parse(Console.ReadLine());
            Display(num);
        }
    }
}
