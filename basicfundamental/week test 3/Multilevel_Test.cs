using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.week_test_3
{

    class person1
    {
        internal string name = "Saurabh";
        public void Showname()
        {
            Console.WriteLine("Name - " + name);
        }
    }
    class Teacher:person1
    {
        internal string role = "Teacher";
        public void ShowRole()
        {
            Console.WriteLine(name + " is a " + role);
        }
    }
    class Hod:Teacher
    {
        internal string Role2 = "Hod";
        public void show()

        {
            this.Showname();
            this.ShowRole();
            Console.WriteLine(name + "  is also " + Role2);
        }
    }
    class Multilevel_Test
    {
        static void Main(String[] args)
        {
            Hod h = new Hod();
            h.show();
        }
    }
}
