using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Oops.Polym
{
    class Calculator
    {
        void Calci(int x , int y)
        {
            Console.WriteLine("Addition is   " +(x+y));
        }
        void Calci(string sb, int a, int b)
        {
            Console.WriteLine("subtractraction    " +(a - b));
        }
        void Calci(double m, double n)
        {
            Console.WriteLine("Division    " +(m/n));
        }

        void Calci(float x,float y)
        {
            Console.WriteLine("Multiplication   " + (x*y));
        }

        static void Main(string[]args)
        {
            Calculator c = new Calculator();
            c.Calci(10, 20);
            c.Calci("Sub",20,10);
            c.Calci(10.0f,20.1f);
            c.Calci(10, 20.00);


        }
    }
}
