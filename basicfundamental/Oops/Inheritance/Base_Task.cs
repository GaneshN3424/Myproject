using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Oops.Inheritance
{

    class Sport
    {
        public int player = 11;

        public Sport(string Caption)
        {
            Console.WriteLine("Caption is" + Caption);
        }
        public void Team()
        {
            Console.WriteLine("Team Name is India");
        }
    }

    class Cricket:Sport
    {

        public int player=3;
        public Cricket():base("Rohit")
        {
            Console.WriteLine("Reserved Player" + player);
        }

        public void Team()
        {
            Console.WriteLine("Player=" +base.player);
            base.Team();
        }
    }
    class Base_Task
    {
        static void Main(string[]args)
        {
            Cricket c = new Cricket();
            c.Team();
        }
    }
}
