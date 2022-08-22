using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.StringDEMO
{
    class ReverseSentence
    {
        static string Reverse(string a)
        {
            string s = "";
            for (int i = a.Length-1;i>=0 ;i--)
            {
                s = s + a[i];
            }
            return s;

        }
        static void Main(string[]args)
        {
            Console.WriteLine("Enter Sentence");
            string str = Console.ReadLine();
            string[] Sarr = str.Split(" ");
            for(int i=0;i<Sarr.Length;i++)
            {
                string r = Reverse(Sarr[i]);
                Console.Write(r+" ");
            }

        }
    }
}
