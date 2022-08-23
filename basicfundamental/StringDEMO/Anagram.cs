using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.StringDEMO
{
    class Anagram
    {

        static void Main(string[]args)
        {
            Console.WriteLine("Enter two string");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            s1 = s1.ToLower();
            s2 = s2.ToLower();
            char[] a1 = s1.ToCharArray();
            char[] a2 = s2.ToCharArray();

            Array.Sort(a1);
            Array.Sort(a2);

            if()
            {
                Console.WriteLine("Anagram");

            }
            else
            {
                Console.WriteLine("Not anagram");
            }
        }
    }
}
