using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray
{
    class EvenOddArray
    {


        public void EvenOdd(int []b)
        {
            int[] c = new int[10];
            int[] d = new int[10];
            int j=0;
            int k=0;

            for (int i = 0; i < b.Length; i++)
            {
                if(b[i]%2==0)
                {
                    c[j] = b[i];
                    j++;
                }
                else
                {
                    d[k] = b[i];
                    k++;
                }

            }
            Console.WriteLine("Even Elements are.............................");
            foreach(int x in c)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("Odd Elements Are....................................");
           foreach(int z in d)
            {
                Console.WriteLine(d);
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            EvenOddArray e = new EvenOddArray();
            e.EvenOdd(a);
        }
    }
}
