using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray
{
    class Assending
    {

        public  int[] AssDe(int []a)
        {
            for(int i=0;i<a.Length;i++)
            {
                for(int j=0;j<(a.Length)/2;j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
                int c = 0;
                for(int k= ((a.Length) / 2) + c; k<a.Length;k++)
                {
                    if (a[i] > a[k])
                    {
                        int temp = a[i];
                        a[i] = a[k];
                        a[k] = temp;
                    }
                }
            }
            return a;
        }

            static void Main(string[]args)
            {
                int[] arr = { 10, 20, 30, 40, 50, 1, 2, 3, 4, 8 };
                Assending m = new Assending();
                int[] As = m.AssDe(arr);
                Console.WriteLine(string.Join("  " , As));
            }
        
    }
}
