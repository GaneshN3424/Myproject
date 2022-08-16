using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray
{
    class Sum_of_Each_Col
    {
        public static void Minimum(int[,]a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                int sum = 0;
                for(int j=0;j<a.GetLength(1);j++)
                {
                    sum = sum + a[j, i];
                   
                }
                Console.Write("sum =" + sum);
                Console.WriteLine();
            }

        }
            
        static void Main(string[] args)
        {
            int[,] arr = { { 6, 3, 4 }, { 4, 5, 6 },{ 7,8,9} };
            Sum_of_Each_Col.Minimum(arr);

        }
    }
}
