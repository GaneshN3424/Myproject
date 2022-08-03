using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Loop.Pattern
{
    class No1234
    {
        static void Main(string[] args)
        {
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
