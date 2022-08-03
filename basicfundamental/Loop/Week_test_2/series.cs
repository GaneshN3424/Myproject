using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Loop.Week_test_2
{
    class series
    {
        void ser(int n)
        {

              for (int i = 1;i<=n;i++)
              {
                int r = i * i - 1;
                Console.Write (r);
              }
        }
        static void Main(string[] args)
        {
            series n = new series();
            n.ser(10);
        }
    }
}
