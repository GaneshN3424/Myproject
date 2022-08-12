using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Oops.Inheritance
{

    class Laptop
    {
        internal string color = "Black";
        internal string memory = "1TB";
    }
    class Dell:Laptop
    {
        public void Display()
        {
            Console.WriteLine(color + "  " + memory);
        }
    }
    class Single_Task
    {
       static void Main(string[]args)
       {
            Dell d = new Dell();
            d.Display();
       }
    }
}
