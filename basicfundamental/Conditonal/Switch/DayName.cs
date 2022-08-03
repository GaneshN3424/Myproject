using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Conditonal.Switch
{
    class DayName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Day Name");
            int num1 = int.Parse(Console.ReadLine());
            switch(num1)
            {
                case 1:Console.WriteLine("Monday");
                    break;
                case 2:Console.WriteLine("Tuesday");
                    break;
                case 3:Console.WriteLine("Wed");
                    break;
                case 4:Console.WriteLine("Thur");
                    break;
                case 5:Console.WriteLine("Fri");
                    break;
                case 6:Console.WriteLine("Sat");
                    break;
                case 7:Console.WriteLine("Sun");
                    break;
                default:Console.WriteLine("Enter No is Invalid ");
                    break;
            }
        }
    }
}
