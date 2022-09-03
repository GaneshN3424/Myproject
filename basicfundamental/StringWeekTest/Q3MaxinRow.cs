using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.StringWeekTest
{
    class Q3MaxinRow
    {
        static void MininRow(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int mx = a[0, i];
                
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (mx < a[i, j])
                    {
                        mx = a[i, j];
                    }

                }
                Console.WriteLine(mx);

            }
            
        }
        
        static void Main(string[]args)
        {
            int[,]arr= { { 1, 8, 4 }, { 10, 20, 40 } };
            MininRow(arr);


        }
    }
}
