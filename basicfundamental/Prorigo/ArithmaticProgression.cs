using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Prorigo
{
    class ArithmaticProgression
    {

        static int Arithmatic(int t2,int t3,int num)
        {
            int d = t3 - t2;
            for(int i=4;i<=num;i++)
            {
                t3 = t3 + d;
            }
            return t3;
        }

        static void Main(string[]args)
        {
            Console.WriteLine("Enter second term ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third term");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Term which you want");
            int num3 = int.Parse(Console.ReadLine());
            int n= Arithmatic(num1, num2, num3);
            Console.Write(n);
        }
    }
}
