using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray
{
    class MaxMin2D
    {
        public void MaxMin(int[,]a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                int mx =a[0,i];
                int mi = a[0, i];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (mx < a[i,j])
                    {
                        mx = a[i,j];
                    }
                    else if(mi>a[i,j])
                    {
                        mi = a[i, j];
                    }
                                         
                }
                Console.WriteLine("Max is " + mx);
                Console.WriteLine("Min is " + mi);
                Console.WriteLine();
            }
        }
        static void Main(string[]args)
        {
            int[,] arr = { { 1, 4, 7 }, { 8, 5, 2 }, { 6, 3, 9 } };
            MaxMin2D m = new MaxMin2D();
            m.MaxMin(arr);
        }
    }
}
