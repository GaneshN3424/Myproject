using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray.ArrayTest
{
    class ReplaceZero
    {

        public void  Replace(int[]a)
        {
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]==0)
                {
                    a[i] = 1;
                }
            }
            Console.WriteLine(string.Join(" ", a));
        }

        static void Main(string[]args)
        {
            int[] arr = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            Console.WriteLine("Array is................................");
            Console.WriteLine(string.Join(" ", arr));
            ReplaceZero r = new ReplaceZero();
            r.Replace(arr);
        }
    }
}
