using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Oops.Inheritance
{
    class person
    {
        internal string p_name = "Ganesh";
        public void showperson()
        {
            Console.WriteLine("Name-" + p_name);
        }
    }
    class Emplo:person
    {
        internal int sal = 35000;
        public void showEmplo()
        {
            Console.WriteLine(p_name + "  " + sal);
        }
    }
    class Manager:Emplo
    {
        internal int comm = 30000;
        public void showManager()
        {
            Console.WriteLine(p_name+"  "+sal+"  "+comm);
        }
    }
    class MultilevelDemo
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            m.showperson();
            m.showEmplo();
            m.showManager();
        }


    }
}
