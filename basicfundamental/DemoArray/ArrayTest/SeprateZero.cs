using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray.ArrayTest
{
    class SeprateZero
    {

        public  void Seprte(int[]a)
        {
            int count = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]!=0)
                {
                    a[count] = a[i];
                    count++;
                }
            }
            while(count<a.Length)
            {
                a[count] = 0;
                count++;
            }
            Console.Write(string.Join("  ", a));

        }

        static void Main(string[]args)
        {
            int[] arr = { 2, 4, 5, 0, 4, 0, 8, 0, 7, 8 };

            SeprateZero s = new SeprateZero();
            s.Seprte(arr);
        }
    }
}
