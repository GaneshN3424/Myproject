using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.StringWeekTest
{
    class Q6RemoveChar
    {
        static string Remove(string a,string b)
        {
            a = a.ToLower();
            string s1 = "";
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] != 'i' && a[i] != 'n')
                {
                    s1 = s1 + a[i];
                }
            }
            return s1;
        }

        static void Main(string[] args)
        {
            string str = "India is great nation";
            string s = "in";
           string m = Remove(str, s);
            Console.WriteLine(m);
        }
    }
}
