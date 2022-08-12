using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray
{
    class EvenPosition
    {


        public void even(int []arr)
        {

            Console.WriteLine("....................Even position Array...............");
            for(int i=0;i<arr.Length;i++)
            {
                if(i==0||i%2==0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        static void Main(string[]args)
        {
            Console.WriteLine(".................Enter the size of Array....................");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("..............Enter Array.............");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }
            EvenPosition e = new EvenPosition();
            e.even(a);
        }
    }
}
