using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.StringDEMO
{
    class ReplaceVowel
    {

        public static void Replace(string a)
        {
            a = a.ToLower();
            for(int i= 0;i < a.Length;i++)
            {
                a = a.Replace('a', 'b');
                a = a.Replace('e', 'f');
                a = a.Replace('i', 'j');
                a = a.Replace('o', 'p');
                a = a.Replace('u', 'v');
            }
            Console.WriteLine(a);
        }
        static void Main(string[]args)
        {
            Console.WriteLine("Enter text");
            string str=Console.ReadLine();
            Replace(str);
        }
    }
}
