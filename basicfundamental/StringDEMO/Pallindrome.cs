using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.StringDEMO
{
    class Pallindrome
    {
        public static string  Reverse(string str)
        {
            string s1 = "";
            for(int i=str.Length-1;i>=0;i--)
            {
                s1 = s1 + str[i];
            }
            return s1;
        }
        static void Main(string[]args)
        {
            string s = Console.ReadLine();
            string rev=Reverse(s);
            if(rev==s)
            {
                Console.WriteLine("Pallimdrom");
            }
            else
            {
                Console.WriteLine("Not Palli. ");
            }
        }
    }
}
