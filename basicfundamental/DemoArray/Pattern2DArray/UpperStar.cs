using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray.Pattern2DArray
{
    class UpperStar
    {

        

        static void Main(string[] args)
        {
            char[,] arr = new char[4, 4];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i <= j)
                    {
                       
                        arr[i, j] = '*';
                    }
                    else
                    {
                        arr[i, j] = ' ';
                    }

                }
                Console.WriteLine();
            }
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine(" ");
            }

        }
    }
}
