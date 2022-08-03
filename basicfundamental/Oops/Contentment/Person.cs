using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Oops.Contentment
{

    class Address
    {
        int pincode;
        string city;

        public Address(int pincode,string city)
        {
            this.pincode = pincode;
            this.city = city;
        }
        public void showAddress()
        {
            Console.WriteLine(pincode + "  " + city);
        }
    }
    class Person
    {
        int id;
        string name;
        Address adr;

        Person(int id, string name,Address adr)
        {
            this.id = id;
            this.name = name;
            this.adr = adr;
        }
        void DisplayPerson()
        {
            Console.WriteLine(id + " " + name);
            adr.showAddress();
        }
        static void Main(string[]args)
        {
            Address p = new Address(255,"pune");
            Person m = new Person(240,"Ganesh",p);
            m.DisplayPerson();
        }
    }
}
