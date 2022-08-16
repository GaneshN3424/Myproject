using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray.ArrayTest
{
    class Number
    {
        public static void Main(String []args)
        {
            int[] var = new int[10];
            for (int i = 0; i < 10; ++i)
            {
                var[i] = i;
                Console.WriteLine(var[i] +" ");
                i++;
            }// output  0 2 4 6 8
        }
    }
}
