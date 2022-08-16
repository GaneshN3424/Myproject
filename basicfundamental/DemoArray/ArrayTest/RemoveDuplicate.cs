using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray.ArrayTest
{
    class RemoveDuplicate
    {
        public void Remove(int[]a)
        {
            int j = 0;
            for(int i=0;i<a.Length;i++)
            {
              
               if(a[i]!=a[i+1])
                {
                    a[j++] = a[i];
                    
                }
               
            }
            Console.WriteLine(string.Join(" ", a));

        }
        static void Main(string[]args)
        {
            int[] arr = new int[10];
                Console.WriteLine("  Enter 10 Array Element");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i]= int.Parse(Console.ReadLine());
            }

            RemoveDuplicate r = new RemoveDuplicate();
             r.Remove(arr);
            //Console.WriteLine(string.Join(" ", num));
        }
    }
}
