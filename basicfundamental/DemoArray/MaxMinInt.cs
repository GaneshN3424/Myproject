using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray
{
    class MaxMinInt
    {


        public void MaxMin(int []b)
        {
            int max = b[0];
            int min = b[0];

            for(int i=0;i<b.Length;i++)
            {
                if(max<b[i])
                {
                    max = b[i];
                }
            }
            Console.WriteLine("Maxium Number is " + max);

            for (int i = 0; i < b.Length; i++)
            {
                if(min>b[i])
                {
                    min = b[i];

                }
            }

            Console.WriteLine("Minimun number is  " + min);


        }


        static void Main(string[]args)
        {
            int[] a = new int[5];

            for (int i = 0; i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            MaxMinInt m = new MaxMinInt();
            m.MaxMin(a);
               
        }
    }
}
