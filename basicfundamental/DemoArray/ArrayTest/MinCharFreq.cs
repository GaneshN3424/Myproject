using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray.ArrayTest
{
    class MinCharFreq
    {
        public char Minimum(char[] a)
        {
            char m = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (m > a[i])
                {

                    m = a[i];

                }
            }

            return m;


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size = int.Parse(Console.ReadLine());
            char[] arr = new char[size];
            Console.WriteLine("Enter the char element of array");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i]= Convert.ToChar(Console.ReadLine());
            }

            MinCharFreq m = new MinCharFreq();

            char min = m.Minimum(arr);

            Console.WriteLine("minimum Char is  " + min);

        }
    }
}
