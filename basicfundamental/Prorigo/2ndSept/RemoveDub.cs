using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Prorigo._2ndSept
{
    class RemoveDub
    {
        static void Display(int[] a)
        {
            int c = 0;
            for(int i = 0; i < a.Length; i++)
            {
                c = a[i];
                int flg = 1;
                for(int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        flg = 0;
                        continue;
                    }
                    
                }
                if (flg == 0)
                    Console.WriteLine(a[i]);
                
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 3, 2, 1, 5};
            Display(arr);
        }
    }
}
