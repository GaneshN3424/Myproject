using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Oops.Inheritance
{

    class Animal
    {
        public int leg = 4;
    }
    class frog : Animal
    {
        public int leg = 2;
        public void show()
        {
            Console.WriteLine(" Frog leg " + leg + "   Animal leg=" + base.leg);
        }
    }

    class Dog:Animal
    {
        public void Display()
        {
            Console.WriteLine("Dog legs =" + base.leg);
        }
    }
    class BaseDemo1
    {

        static void Main(string[]args)
        {
            frog f = new frog();
            f.show();
            Dog d = new Dog();
            d.Display();
        }
    }
}
