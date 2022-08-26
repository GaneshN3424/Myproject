using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.StringDEMO
{
    class RemoveDuplicates
    {

        static void Remove(string s1)
        {
            char s =' ' ;
          
            s1 = s1.ToLower();
            char[] a = s1.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;
                
                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[i] == a[k])
                    {
                        a[i] = s;
                        
                        break;
                    }
                }

                Console.Write(a[i]);


            }
        }
        static void Main(string[]args)
        {

            Console.WriteLine("Enter your text");
            string str = Console.ReadLine();
            Remove(str);
        }
    }
}
