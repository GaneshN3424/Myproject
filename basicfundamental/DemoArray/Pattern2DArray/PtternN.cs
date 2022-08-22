using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray.Pattern2DArray
{
    class PtternN
    {
        public void Pattern(int[,]a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if (j == 0 || j == a.GetLength(1) - 1||j==i)
                    {
                        Console.Write(" "+a[i,j]);
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }

        }
        static void Main(string[]args)
        {
            int[,] arr = new int[4, 4];
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]+" ");
                }
                Console.WriteLine();
            }
            PtternN p = new PtternN();
            p.Pattern(arr);
        }
    }
}
