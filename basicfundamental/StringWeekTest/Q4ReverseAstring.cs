using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.StringWeekTest
{
    class Q4ReverseAstring
    {
        static void Reverse(string a)
        {
            char[] inputArray = a.ToCharArray();
            char[] result = new char[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == ' ')
                {
                    result[i] = ' ';
                }
            }
            int j = result.Length - 1;
            for (int i = 0; i < inputArray.Length; i++)
            {


                if (inputArray[i] != ' ')
                {


                    if (result[j] == ' ')
                    {
                        j--;
                    }
                    result[j] = inputArray[i];
                    j--;
             }  }
                for (int i = 0; i < result.Length; i++)
                {
                    Console.Write(result[i]);
                }

        }   
            static void Main(string[] args)
            {
                string str = Console.ReadLine();
                Reverse(str);

            }
        }
    }

