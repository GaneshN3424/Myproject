using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.StringDEMO
{
    class SentenceOccurance
    {
        static void Occurance(string a,char b)
        {
            int count = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(b==a[i])
                {
                    count++;
                }
            }
            Console.WriteLine("Occurance " + count + "  Times");
        }
        static void Main(string[]args)
        {
            Console.WriteLine("Enter Sentence");
            string str = Console.ReadLine();
            Console.WriteLine("/////////////////////////////////////////////////");
            Console.WriteLine("Enter Char");
            char s = Convert.ToChar(Console.ReadLine());
            Occurance(str, s);
        }
    }
}
