using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Oops.Inheritance
{

    class student
    {
        internal string sn = "Prasad";
    }
    class Fifth:student
    {
        internal int per = 80;
        internal string r = "Pass";
        
    }
    class sixth:Fifth
    {
        internal int p = 30;
        internal string s = "Fail";
        public void show()
        {
            Console.WriteLine("Name  " + sn + "fifth  per=" + per + "   Result " + r);

            Console.WriteLine("Name  " + sn + "sixth  per=" + p + "   Result " + s);
        }
    }

    class Multi_task
    {
        static void Main(string[]args)
        {
            sixth s = new sixth();
            s.show();
        }
    }
}
