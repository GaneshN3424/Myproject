using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.StringDEMO
{
    class Frequency_of_Each
    {

        static void Frequency(string a)
        {
            a = a.ToLower();
            for (int i = 0; i < a.Length; i++)
                {
                int count = 1;
                    bool isVisited = true;
                    for (int k = i - 1; k >= 0; k--)
                    {
                        if (a[i] == a[k])
                        {
                            isVisited = false;
                            break;
                        }
                    }
                    if (isVisited == true)
                    {
                        for (int j = i + 1; j < a.Length; j++)
                        {
                            if (a[i] == a[j])
                            {
                              count++;
                            }
                        }
                        Console.WriteLine(a[i] + "  " + count);
                    }
                }

            
        }
        static void Main(string[]args)
        {
            Console.WriteLine("Enter your string");
            string str = Console.ReadLine();
            Frequency(str);
        }
    }
}
