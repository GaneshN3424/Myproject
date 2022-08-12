using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray
{
    class SumofArrayelement

    {
        public int element(int []a)
        {
            int sum = 0;
            for(int i=0;i<a.Length;i++)
            {
                sum = sum + a[i];

            }
            return sum;

        }
        static void Main(string[]args)
        {
            int[] b = new int[10];
            Console.WriteLine("Enter the Array element");
            for(int i=0;i<b.Length;i++)
            {
                b[i] = int.Parse(Console.ReadLine());

            }

            SumofArrayelement c = new SumofArrayelement();
            int sum = c.element(b);
            Console.WriteLine("Total sum of Array element  " + sum);
            
        }
    }
}
