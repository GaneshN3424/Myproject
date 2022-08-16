using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray
{
    class freq
    {
        public int frequency(int[]a,int b)
        {
            int count = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]==b)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[]args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 1, 3, 1, 15, 6, 1, 18, 1, 20 };
            Console.WriteLine("...............Given Array is...............");
            Console.WriteLine(string.Join("   ", arr));

            Console.WriteLine("////////////////////////////////////////////");
            Console.WriteLine("..............Enter the element...............");
            int num = int.Parse(Console.ReadLine());
            freq f = new freq();
            int fr = f.frequency(arr, num);
            Console.Write("Frequency of  " + num + "  is  " + fr);


        }
    }
}
