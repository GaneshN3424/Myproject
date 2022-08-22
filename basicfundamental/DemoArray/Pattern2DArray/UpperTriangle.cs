using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray.Pattern2DArray
{
    class UpperTriangle
    {
      

        static void Main(string[]args)
        {
            int[,] arr = new int[4, 4];
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    if (i <= j)
                    {
                        Console.WriteLine("Enter Element");
                        arr[i, j] = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        arr[i, j] = 0;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("......................................................................");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine(" ");
            }
       
        }
    }
}
