using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Conditonal
{
    class WeekDays
    {
        static void Main(string []args)
        {
            Console.WriteLine("Enter the Day number");
            int num1 = int.Parse(Console.ReadLine());
            if(num1==1)
            {
                Console.WriteLine("Monday");
            }
            else if(num1==2)
            {
                Console.WriteLine("Tuesday");
            }
            else if(num1==3)
            {
                Console.WriteLine("Wednesday");
            }
            else if(num1==4)
            {
                Console.WriteLine("Thursday");
            }
            else if(num1==5)
            {
                Console.WriteLine("Friday");
            }
            else if(num1==6)
            {
                Console.WriteLine("Saturday");
            }
            else if(num1==7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("You Enter Wrong No.");
            }
        }
    }
}
