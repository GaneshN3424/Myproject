using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Loop.Week_test_2
{
    class Country
    {

        static void Main(string[]args)
        {
            Console.WriteLine("Enter Country Name");
            string c = Console.ReadLine();
            switch(c)
            {
                case "India":Console.WriteLine("Hockey");
                    break;
                case "China":
                    Console.WriteLine("Table Tennis");
                    break;
                case "Bangaladesh":
                     Console.WriteLine("Kabbadi");
                      break;
                case "Italy":
                    Console.WriteLine("FootBall");
                    break;
            }
                
        }
    }
}
