using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.StringWeekTest
{
    class Q7SortString
    {
        static void Main(string[]args)
        {
            string str = Console.ReadLine();
            string[] arr = str.Split(" ");
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].Length > arr[j].Length)
                    {
                        string temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
