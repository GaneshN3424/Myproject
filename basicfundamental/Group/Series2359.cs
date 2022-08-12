using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Group
{
    class Series2359
    {
        public void show(int n)
        {
            
            int b = 2;
            Console.Write(b + "  ");
            for(int i=1;i<n;i++)
            {
                // int c = a + b;
                // a = b;
                //b = c;
                b = b + (b - 1);
                Console.Write(b+"  ");
              
            }
        }
        static void Main(string[]args)
        {
            Series2359 s = new Series2359();
            int num = int.Parse(Console.ReadLine());
            s.show(num);
        }
    }
}
