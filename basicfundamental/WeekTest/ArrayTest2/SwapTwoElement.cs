using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.WeekTest.ArrayTest2
{
    class SwapTwoElement
    {

        public void DisplaySwap(int[]a)
        {
            for(int i=0;i<a.Length;i++)
            {
                int temp = 0;
                if(i==0)
                {
                    temp = a[i];
                    a[i] = a[a.Length - 1];
                    a[a.Length - 1] = temp;
                }
                else if (i == 1)
                {
                    temp = a[i];
                    a[i] = a[a.Length - 2];
                    a[a.Length - 2] = temp;
                }
            }
            Console.WriteLine(string.Join(" ", a));

        }

        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8,9,10 };
            SwapTwoElement s = new SwapTwoElement();
            s.DisplaySwap(arr1);
        }
    }
}
