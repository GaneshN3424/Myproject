using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.WeekTest.ArrayTest2
{
    class Q3frequency
    {

        public void DisplayFrequency(int[]a)
        {
            for(int i=0;i<a.Length;i++)
            {
                int count = 1;
                bool isVisited = true;
                for (int k = i-1; k >=0; k--)
                {
                    if(a[i]==a[k])
                    {
                        isVisited = false;
                        break;
                    }
                }
                if (isVisited == true)
                {
                    for (int j = i+1; j< a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(a[i] + "  " + count);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 1, 2, 2, 2, 6, 4, 1, 1, 6, 3, 5, 2 };
            Q3frequency s = new Q3frequency();
            s.DisplayFrequency(arr1);
        }
    }
}
