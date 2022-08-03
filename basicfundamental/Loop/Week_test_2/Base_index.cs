using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Loop.Week_test_2
{
    class Base_index
    {
        void power(int x,int y)
        {
            int n = 1;
            int m = 1;
            while(n<=y)
            {
                m = m * x;
                n++;

            }
            Console.WriteLine(m);
        }
        static void Main(string[]args)
        {
            Base_index d = new Base_index();
            d.power(7, 2);
            
        }
    }
}
