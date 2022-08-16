using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray.ArrayTest
{

    
    class PerfectSQ
    {
        public void square(int[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                for(int j=1;j<a[i];j++)
                {
                    if(j*j==a[i])
                    {
                        Console.WriteLine(a[i]);
                        break;
                    }
                }
            }
        }
        static void Main(string[]args)
        {
            int[] arr = { 23, 43, 25, 49, 12, 9, 78, 66, 39, 0 };
            Console.WriteLine("Array is................................");
            Console.WriteLine(string.Join(" ", arr));
            PerfectSQ p = new PerfectSQ();
            p.square(arr);
        }
        
    }
}
