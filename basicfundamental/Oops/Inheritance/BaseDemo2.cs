using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Oops.Inheritance
{
    class Bird
    {
        public void Fly()
        {
            Console.WriteLine("Bird Is Flying......");
        }
    }
    class Sparrow : Bird
    {
        public void Fly()
        {
            Console.WriteLine("Sparrow Is Flying......");
            base.Fly();
        }
    }
    class BaseDemo2
    {

        static void Main(string[]args)
        {
            Sparrow s = new Sparrow();
            s.Fly();
        }
    }
}
