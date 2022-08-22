using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.WeekTest.ArrayTest2
{
    class MergingOftwoArray
    {

        public void Display(int[]a,int[]b)
        {
            int[] arr3 = new int[a.Length+b.Length];
            int indexa = 0;
            int indexb = 0;
            for(int i=0;i<arr3.Length;i++)
            {
                if(indexa<a.Length&&a[indexa]<=b[indexb])
                {
                    arr3[i] = a[indexa];
                    indexa++;
                }
                else if (indexb < b.Length)
                {
                    arr3[i] = b[indexb];
                    indexb++;

                }

            }
            Console.WriteLine(string.Join(" ", arr3));
        }

        static void Main(string []args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] arr2 = { 11, 22, 33, 44 };
            MergingOftwoArray m = new MergingOftwoArray();
            m.Display(arr1, arr2);
        }
    }
}
