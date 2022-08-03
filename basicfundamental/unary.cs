using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental
{
    class unary
    {
        static void Main (string []args)
        {
            int a = 2, b = 3, x;
            x = --a - ++b - a;
            Console.WriteLine(x + " " + a + " " + b);

            x = ++b + ++a + b;
            Console.WriteLine(x + " " + a + " " + b);


            x = a++ + --b - a;
            Console.WriteLine(x + " " + a + " " + b);


            x = --a - --b - a;
            Console.WriteLine(x + " " + a + " " + b);
        }
    }
}
