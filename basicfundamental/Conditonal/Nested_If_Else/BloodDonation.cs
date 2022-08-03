using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Conditonal.Nested_If_Else
{
    class BloodDonation
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter weight");
            int wh = int.Parse(Console.ReadLine());
            if(age>18)
            {
                if (wh > 50)
                {
                    Console.WriteLine(" Eligible For Blood Donation");
                }
                else
                {
                    Console.WriteLine("Not Eligible");
                }
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
             

        }
    }
}
