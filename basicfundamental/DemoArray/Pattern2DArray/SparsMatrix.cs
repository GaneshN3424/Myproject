using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray.Pattern2DArray
{
    class SparsMatrix
    {
        public void CheckSpaese(int[,]a)
        {
            int sum = 1,count = 1;
            for (int i = 0; i <= a.GetLength(0); i++)
            {
                for (int j = 0; j <= a.GetLength(1); j++)
                {
                    if(a[i,j]==0)
                    {
                        count++;
                    }
                    else
                    {
                        sum++;
                    }
                }
            }

            if(count>sum)
            {
                Console.WriteLine("Matrix is Sparse");
            }
            else
            {
                Console.WriteLine("Matrix is Not Sparse");
            }

        }

        static void Main(string[]args)
        {
            int[,] arr = { { 1, 2, 0 }, { 0, 5, 0 }, { 0, 0, 0 } };

          

            SparsMatrix s = new SparsMatrix();
            s.CheckSpaese(arr);
        }
    }
}
