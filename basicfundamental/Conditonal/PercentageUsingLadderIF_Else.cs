using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Conditonal
{
    class PercentageUsingLadderIF_Else
    {
        static void Main(string []args)
        {
            Console.WriteLine("Enter the five sub Marks");
            int Sub1 = int.Parse(Console.ReadLine());
            int Sub2 = int.Parse(Console.ReadLine());
            int Sub3 = int.Parse(Console.ReadLine());
            int Sub4 = int.Parse(Console.ReadLine());
            int Sub5 = int.Parse(Console.ReadLine());
            int Total = Sub1 + Sub2 + Sub3 + Sub4 + Sub5;
            Console.WriteLine("Total  " + Total);
            int Per = Total / 5;
            Console.WriteLine("Per is   " + Per);
            if(Per>=70)
            {
                Console.WriteLine("Distinction");

            }
            else if(Per>=60 && Per<70)
            {
                Console.WriteLine("First class");
            }
            else if(Per>=50 && Per<60)
            {
                Console.WriteLine("Second Class");
            }
            else if(Per>=35 && Per<50)
            {
                Console.WriteLine("Pass Class");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
