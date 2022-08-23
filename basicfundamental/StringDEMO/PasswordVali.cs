using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.StringDEMO
{
    class PasswordVali
    {

        static void PasswordV(string a)
        {
            bool sp = false;
            bool digit = false;
            bool up = false;
            bool low = false;
            bool length = false;
            if (a.Length >8)
            {
                length = true;
            }
                foreach(char x in a)
                {
                      
                    if(char.IsDigit(x))
                    {
                        digit = true;
                    }
                    else if(char.IsUpper(x))
                    {
                        up = true;
                    }
                    else if(char.IsLower(x))
                    {
                       low = true;
                    }
                    else if(!char.IsLetterOrDigit(x))
                    {
                        sp = true;
                    }
                    
                    
                }
               
                
            
            if (length &&  sp && low &&up==true&&digit==true)
            {
                Console.WriteLine("Password Is Valid");

            }
            else
            {
                Console.WriteLine("Password Invalid");
            }


        }

        static void Main(string []args)
        {
            Console.WriteLine("Enter the Password");
            string str = Console.ReadLine();
             PasswordV(str);

        }
    }
}
