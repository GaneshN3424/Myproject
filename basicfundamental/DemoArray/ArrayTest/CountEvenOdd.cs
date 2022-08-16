using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray.ArrayTest
{
    class CountEvenOdd  //count even odd element from array
    {
        public void count(int[]a)
        {
            int even= 0;
            int odd = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            Console.WriteLine("Even Elements int the array is  " + even);
            Console.WriteLine("............................................. " );
            Console.WriteLine("Odd Elements int the array is  " + odd);

        }
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the size of Array");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("Enter The Array");

            for(int i=0;i<arr.Length;i++)
            {
                arr[i]= int.Parse(Console.ReadLine());
            }

            CountEvenOdd c = new CountEvenOdd();
            c.count(arr);
            
        }
    }
}
