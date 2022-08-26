using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.StringDEMO
{
    class TuppleUse2ndWAy
    {

        static (int,int,string) Display(int a,int b)
        {
            int sum = a + b;
            int mul = a * b;
            string name = "Ganesh";
            return (sum, mul, name);
        }
        static void Main(string[]args)
        {
            //  ValueTuple<int, int,string> t = Display(5, 10);
            var (add, mul, name) = Display(10, 5);
            Console.WriteLine(name + " " + add + " " + mul);
        }
    }
}
