using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Conditonal.Nested_If_Else
{
    class TernaryOddEven
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter Any Number");
            int num1 = int.Parse(Console.ReadLine());
            string Num2 = num1 % 2 == 0 ? "Even" : "Odd";
            Console.WriteLine(Num2);
        }
    }
}
