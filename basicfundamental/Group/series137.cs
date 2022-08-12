using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Group
{
    class series137
    {

        public void series(int n)
        {
            int a = 1;
            int b = 2;
            Console.Write(a+"  ");
            Console.Write(b+"  ");
            for(int i=1;i<=n;i++)
            {
                int c = a + b;
                Console.Write(c+"  ");
                a = c;
                b = a++;
            }         
        }
        static void Main(string[]args)
        {
            series137 s = new series137();
            int num = int.Parse(Console.ReadLine());
            s.series(num);
        }
    }
}
