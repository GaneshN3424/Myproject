using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray
{
    class Addition_of_2D
    {
        
        static void Main(string[]args)
        {
            int[,] arr = { { 2, 4 }, { 4, 8 } };
            int[,] add = { { 7, 8 }, { 6, 3 } };

            int[,] c = new int[2, 2];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    c[i, j] = arr[i, j] + add[i, j];
                }
            }

            for(int i=0;i<c.GetLength(0);i++)
            {
                for(int j=0;j<c.GetLength(1);j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
