using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.StringDEMO
{
    class ToggleDemo
    {
        public static string Toggle (string a)
        {
            string str = " ";
            foreach(char x in a)
            {
                if(char.IsUpper(x))
                {
                    str = str + char.ToLower(x);
                }
                else if(char.IsLower(x))
                {
                    str = str + char.ToUpper(x);
                }
            }
            return str;
        }
            

        static void Main(string[]args)
        {
            Console.WriteLine("Enter Your Text");
            string s = Console.ReadLine();
            string togg= Toggle(s);
            Console.WriteLine(togg);


        }
    }
}
