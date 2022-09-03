using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Prorigo
{
    class NearestNo
    {
        static int CheckNear(int[]a,int b)
        {
            int c = 0;
            int min = int.MaxValue;
            int num_min = int.MinValue;
            for(int i=0;i<a.Length;i++)
            {
                   if(a[i]>b)
                   {
                        c = a[i]-b;
                   }
                   else
                   {
                    c = b - a[i];
                   }
                
                   if(c<min)
                { 
                    min = c;
                    num_min = a[i];
                }
            }
            return num_min;
        }
        static void Main(string[] args)
        {
            int[] arr = { 10, 4, 5, 55, 88, 78, 63, 42 };
            int num = int.Parse(Console.ReadLine());
            int ch=CheckNear(arr, num);
            Console.WriteLine(ch);

        }
    }
}
