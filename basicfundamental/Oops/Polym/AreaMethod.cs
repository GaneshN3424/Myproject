using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Oops.Polym
{
    class AreaMethod
    {
        void Area(int r, double PI)
        {
            
            Console.WriteLine("Area of Circle   " + (PI * r * r));

        }
        void Area(int x,int y )
        {
            Console.WriteLine("Area of Reactangle  " + (x * y));
        }
        void Area(float x,float y)
        {
            Console.WriteLine("Area of Triangle  " + ((x * y) / 2));
        }
        int Area(int s)
        {
            return s * s;
        }

        static void Main(string[]args)
        {
            AreaMethod m = new AreaMethod();
            m.Area(5, 3.14);
            m.Area(6, 7);
            m.Area(5f, 8f);
            int diff = m.Area(10);
            Console.WriteLine("Area of Square   " + diff);
        }
    }
}
