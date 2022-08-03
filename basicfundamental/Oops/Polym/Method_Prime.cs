using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Oops.Polym
{
    class Method_Prime
    {

        bool Prime(int n)
        {
            int temp = 0;
            for(int i=2;n>i;i++)
            {
                if(n%i==0)
                {
                    temp = 1;
                    break;
                }
            }
            if(temp==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[]args)
        {
            Method_Prime m = new Method_Prime();
            bool d=m.Prime(9);
            if(d==true)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }

        }

    }
}
