using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Oops.Inheritance
{

    class Hotel
    {
        protected int service_charge = 100;
    }
    class veg:Hotel
    {
        internal int total_bill = 1000;
        public void showVeg_bill()
        {
            Console.WriteLine("Veg Bill=" +( total_bill + service_charge));
        }
    }
    class Non_veg:Hotel
    {
        internal int total_bill=700;
        public void showNonveg_bill()
        {
            Console.WriteLine("Total Non-Veg bill= " + (total_bill + service_charge));
        }
    }

    class Hira_Task
    {
        static void Main(string[]args)
        {
            veg v = new veg();
            v.showVeg_bill();
            Non_veg n = new Non_veg();
            n.showNonveg_bill();
        }
    }
}
