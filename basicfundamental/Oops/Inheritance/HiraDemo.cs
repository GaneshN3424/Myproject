using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Oops.Inheritance
{
    class vehicle
    {
        protected int wheel = 4;

    }
    class car:vehicle
    {
        internal string cname="BMW";
        public void showcar()
        {
            Console.WriteLine("car Name-" + cname + " wheel-" + wheel);
        }
    }
    class Truck:vehicle
    {
        internal string sr = "Tata";
        public void showTruck()
        {
            wheel = 8;
            Console.WriteLine("Truck Name-" + sr + "   wheel  " + wheel);
        }
    }
    class HiraDemo
    {
        static void Main(string[]args)
        {
            car c = new car();
            c.showcar();
            Truck t = new Truck();
            t.showTruck();
        }
    }
}
