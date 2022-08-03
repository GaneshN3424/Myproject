using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Oops.Encapsulation
{
    class Property_Car
    {
        int mn;
        string name;
        int price;
        int speed;

        public int MN
        {
            set
            {
                mn = value;
            }
            get
            {
                    return mn;
            }
        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }


        public int Price
        {
            set
            {
                price = value;
            }
            get
            {
                return price;

            }
        }

        public int Speed
        {
            set
            {
                speed = value;
            }
            get
            {
                return speed;
            }
        }
         
    }


    class CarInfo
    {
        static void Main(string[]args)
        {
            Property_Car d = new Property_Car();
            d.MN = 145242;
            d.Name = "BMW";
            d.Price = 1400000;
            d.Speed = 65;

            Console.WriteLine(+d.MN + "  " + d.Name + "  " + d.Price + "  " + d.Speed );

        }
    }
}

