using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.WeekTest.ArrayTest2
{
    class MaxRow
    {

        public void Maximum(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int mx = a[i, 0];
                
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (mx < a[i, j])
                    {
                        mx = a[i, j];
                        Console.WriteLine("Max is " + mx);
                    }
                    

                }
           
                
            }
        }
        static void Main(string[] args)
        {
            int[,] arr = { { 22, 31, 9 }, { 12, 25, 16 } };
            MaxRow m = new MaxRow();
            m.Maximum(arr);
        }
    }
}
