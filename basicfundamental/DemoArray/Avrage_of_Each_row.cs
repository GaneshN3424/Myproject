using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray
{
    class Avrage_of_Each_row
    {

        public void Avrage(int[,]a)
        {

            for(int i=0;i<a.GetLength(0);i++)
            {
                int count = 1;
                int sum = 0;
                for(int j=0;j<a.GetLength(1);j++)
                {
                    sum = sum + a[i, j];
                    count++;
                }
                Console.Write("Avrage is "+sum / count);
                Console.WriteLine();
            }

        }

        static void Main(string[]args)
        {
            int[,] arr = new int[3,3];
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
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Avrage_of_Each_row e = new Avrage_of_Each_row();
            e.Avrage(arr);
        }
    }
}
