using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray
{
    class FloatDisplay
    {
        static void Main(string[]args)
        {
            float[] a = new float[5];
                Console.WriteLine("Enter the array element");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = float.Parse(Console.ReadLine());

            }
            Console.WriteLine("...........using for..................");
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }


            Console.WriteLine("...........using foreach..................");
            foreach(float x in a)
            {
                Console.WriteLine(x);
            }


            Console.WriteLine("...........using join..................");


            Console.Write(string.Join("  ", a));
        }
    }
}
