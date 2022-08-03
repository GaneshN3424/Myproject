using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Conditonal.Switch
{
    class Calculatorusingchar
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter 1st No");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd No");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A.Addition\nS.subtraction\nM.Multiplication\nD.Division");
            Console.WriteLine("Choose intial char");
            char ch = Convert.ToChar(Console.ReadLine());
            switch(ch)
            {
                case 'A':Console.WriteLine(num1 + num2);
                    break;
                case 'S':
                    Console.WriteLine(num1 - num2);
                    break;
                case 'D':
                    Console.WriteLine(num1 / num2);
                    break;
                case 'M':Console.WriteLine(num1 * num2);
                    break;
                default:Console.WriteLine("You Enter Wrong choice");
                    break;
                    
            }


        }
    }
}
