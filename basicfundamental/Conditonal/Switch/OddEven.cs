using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Conditonal.Switch
{
    class OddEven
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter Number");
            int num1 = int.Parse(Console.ReadLine());
            switch(num1%2)
            {
                case 0 :Console.WriteLine("Even");
                    break;
                default:Console.WriteLine("Odd");
                    break;
            }
                
        }
    }
}
