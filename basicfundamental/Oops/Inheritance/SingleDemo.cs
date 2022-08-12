using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Oops.Inheritance
{
    class Mobile
    {
        internal string memory = "64GB";
    }
    class Apple:Mobile
    {
        public void show()
        {
            Console.WriteLine(memory);
        }
    }
    class SingleDemo
    {
        static void Main(string[] args)
        {
            Apple x = new Apple();
            x.show();

        }
    }
}
