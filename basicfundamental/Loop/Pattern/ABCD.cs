using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Loop.Pattern
{
    class ABCD
    {
        static void Main(string[]args)
        {
            for(char i='D';i>='A';i--)
            {
                for(char j='A'; j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
