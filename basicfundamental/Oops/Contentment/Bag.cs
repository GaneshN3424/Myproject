using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Oops.Contentment
{

    class Pen
    {
        int length;
        string name;
        string color;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

    }
    class Bag
    {

        string brand_name;
        int price;
        string bgcolor;
        Pen p;


        public string Brand
        {
            get { return brand_name; }
            set { brand_name = value;}
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Bgcolor
        {
            get { return bgcolor; }
            set { bgcolor = value; }
        }
        public Pen P
        {
            get { return p; }
            set { p = value; }
        }
    }
    class BagInfo
    {
        static void Main(string[]args)
        {
            Bag b = new Bag();
            b.Brand = "skybag";
            b.Bgcolor = "black";
            b.Price = 500;
            b.P =new Pen();
            b.P.Color = "black pen";
            b.P.Length = 5;
            b.P.Name = "Trimax";



            Console.WriteLine(b.Brand + "  " + b.Bgcolor + "  " + b.Price + "  " + b.P.Name + "  " + b.P.Length + "  " + b.P.Color);
        }
    }
}
