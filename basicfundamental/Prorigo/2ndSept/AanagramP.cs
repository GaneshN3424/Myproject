using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Prorigo._2ndSept
{
    class AanagramP
    {
        static bool Display(string a, string b)
        {
            a = a.ToLower();
            b = b.ToLower();
            char[] a1 = a.ToCharArray();
            char[] a2 = b.ToCharArray();
            Array.Sort(a1);
            Array.Sort(a2);
            if (string.Join("", a1) == string.Join("", a2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            bool ch = Display(str1, str2);
            if (ch)
                Console.WriteLine("Anagram");

            else
                Console.WriteLine("Not Anagram");
        }
    }
}
