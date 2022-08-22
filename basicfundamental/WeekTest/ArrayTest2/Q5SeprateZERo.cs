using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.WeekTest.ArrayTest2
{
    class Q5SeprateZERo
    {

        public void SeparateZERo(int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {
                    a[count] = a[i];
                    count++;
                }
            }
            while (count < a.Length)
            {
                a[count] = 0;
                count++;
            }
            Console.Write(string.Join("  ", a));

        }

        static void Main(string[] args)
        {
            int[] arr = { 12, 0, 7, 0, 8, 0, 3 };

            Q5SeprateZERo s = new Q5SeprateZERo();
            s.SeparateZERo(arr);
        }
    }
}
