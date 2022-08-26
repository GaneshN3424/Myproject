using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Prorigo
{
    class SubArray
    {
        static int Display(int[]a)
        {
            int max = 0;
            for(int i = 0; i < a.Length; i++)
            {
                int z = 0;
                int one = 0;
                for(int j = 0; j < a.Length; j++)
                {
                    if (a[j] == 1)
                    {
                        one++;
                    }
                    else
                    {
                        z++;
                    }

                    if(z==one)
                    {
                        if (max < (j - i + 1))
                        {
                            max = j - i + 1;
                        }
                    }
                }
            }
            return max;

        }
        static void Main(string[]args)
        {
            Console.WriteLine("Enter The Size of Array");
            int Size = int.Parse(Console.ReadLine());
            int[] arr = new int[Size];

            Console.WriteLine("Enter Array Element");

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int Max=Display(arr);
            Console.WriteLine(Max);

        }
    }
}
