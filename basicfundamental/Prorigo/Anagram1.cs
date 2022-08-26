using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Prorigo
{
    class Anagram1
    {
       public static bool DisplayAnagram(string a,string b)
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
        static void Main(string[]args)
        {
            string str = Console.ReadLine();
            string str2 = Console.ReadLine();
           bool Ch= DisplayAnagram(str,str2);

            if (Ch == true)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }
        }
    }
}
