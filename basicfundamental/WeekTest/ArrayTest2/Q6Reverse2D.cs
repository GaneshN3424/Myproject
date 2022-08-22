using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.WeekTest.ArrayTest2
{
    class Q6Reverse2D
    {
        public void Reverse(int[,] a)
        {

            for(int i=0;i<a.GetLength(0);i++)
            {
                int temp = a[0,i];
                int b = a.GetLength(0)-1;
                for(int j = 0; j < a.GetLength(1);j++)
                {
                  
                    temp = a[j, i];
                    a[j, i] = a[b,i];
                    a[b,i] = temp;

                }
            }

            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        static void Main(string[]args)
        {
            int[,] arr1 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            Q6Reverse2D r = new Q6Reverse2D();
            r.Reverse(arr1);

        }
    }
}
