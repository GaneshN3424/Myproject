using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Conditonal
{
    class ConditionDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number ");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 > 0)
            {
                Console.WriteLine("No is Positive");
            }
            else
            {
                Console.WriteLine("No is Negative");
            }
        }
    }
}

