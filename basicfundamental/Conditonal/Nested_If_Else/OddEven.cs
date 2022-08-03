using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Conditonal.Nested_If_Else
{
    class OddEven
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Any Number");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 % 2 == 0)
            {
                if (num1 >= 5 && num1 <= 10)
                {
                    Console.WriteLine("Only Even");
                }
                else
                {
                    Console.WriteLine("Hii Even");
                }
            }
            else if (num1 >= 2 && num1 <= 5)
            {
                Console.WriteLine("Hello Odd");
            }
            else
            {
                Console.WriteLine("Only Odd");
            }
            
        } 
    }
}
