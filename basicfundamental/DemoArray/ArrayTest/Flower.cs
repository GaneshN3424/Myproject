using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray.ArrayTest
{
    class Flower
    {
        public virtual void color()
        {
            Console.WriteLine("Colourful Flower");
        }
    }
    class Rose:Flower
    {
        public override void color()
        {
            Console.WriteLine("Rose is colorful");

        }

    }
    class OverRideDemo
    {
        static void Main(string[]args)
        {
            Flower r = new Rose();
            r.color();
        }
    }
}
