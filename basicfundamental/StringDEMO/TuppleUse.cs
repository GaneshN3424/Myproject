using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.StringDEMO
{
    class TuppleUse
    {

        static Tuple<int, int> Calculate(int a, int b)
        {
            int sum = a + b;
            int prod = a * b;
            return Tuple.Create(sum, prod);

        }
        static void Main(string[]args)
        {
            Tuple<int,int> t = Calculate(10, 20);
            Console.WriteLine(t.Item1);
            Console.WriteLine(t.Item2);

           

        }
    }
}
