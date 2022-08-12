using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Oops.Inheritance
{

    class Laptop1
    {
        public Laptop1(int x)
        {
            Console.WriteLine("Laptop"+x);
        }
    }

    class lenovo:Laptop1
    {
        public lenovo():base(64)
        {
            Console.WriteLine("Lenovo........");
        }
    }
    class BaseDemo3
    {
        static void Main(string[]args)
        {
            lenovo l = new lenovo();
            
        }
    }
}
