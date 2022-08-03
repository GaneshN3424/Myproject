using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental
{
    class swap
    {
        static void Main(string[] args)
        {
            int a = 100, b = 120 ,c=10;
            c = a;
            a = b;
            b = c;                                                                                              
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
