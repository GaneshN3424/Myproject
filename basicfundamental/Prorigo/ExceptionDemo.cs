using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Prorigo
{
    class ExceptionDemo
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Addition is " + (a + b));
            }
            catch(FormatException e)
            {
                Console.WriteLine("enter valid number");
            }
            catch(StackOverflowException e)
            {
                Console.WriteLine("Number is too big");
            }
        }
    }
}
