using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.StringDEMO
{
    class StringDemo
    {

        static void Main(string[]args)
        {
            string s1 = Console.ReadLine();
                s1.ToLower();
            int v = 0;
            int c = 0;
            for(int i=0;i<s1.Length;i++)
            {
                if (s1[i] == 'a' || s1[i] == 'e' || s1[i] == 'i' || s1[i] == 'o' || s1[i] == 'u') 
                {

                    //Console.WriteLine(s1[i] + " Vowel");
                    v++;

                }
                else
                {
                   // Console.WriteLine(s1[i]+"  Conconent");
                    c++;
                }
            }

            Console.WriteLine("Vowel Count" + v);
            Console.WriteLine("Conspnent Count" + c);

            for(int i=s1.Length-1;i>=0;i--)
            {
                Console.WriteLine(s1[i]);
            }



        }

    }
}
