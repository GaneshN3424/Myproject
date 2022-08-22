using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.StringDEMO
{
    class NameValidation
    {
        static void Validation(string a)
        {
            bool valid = false;
            foreach( char x in a)
            {
                if (!char.IsLetterOrDigit(x))
                {
                    valid = true;
                }
            }

            if(valid==true)
            {
                Console.WriteLine("You Enterd Invalid Name");

            }
            else
            {
                Console.WriteLine("Valid Name");
            }


        }
        static void Main(string []args)
        {
            Console.WriteLine("Enter the Name");
            string str = Console.ReadLine();
            Validation(str);
        }
    }
}
