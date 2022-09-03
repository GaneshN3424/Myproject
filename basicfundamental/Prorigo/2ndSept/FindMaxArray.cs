using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Prorigo._2ndSept
{
    class FindMaxArray
    {
        static int Display(int[] a)
        {
            int m = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i]>m)
                {
                    m = a[i];
                }
            }
            return m;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of Aarray");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("enter Array Element");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int max=Display(arr);
            Console.WriteLine(max);
        }
    }
}
