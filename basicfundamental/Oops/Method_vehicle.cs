using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Oops
{
    class Method_vehicle
    {
        public int model_no;
        public string ty;
        public int nw;
        public int avg;

        public void Accept(int mn, string sr, int wheel)
        {
            model_no = mn;
            ty = sr;
            nw = wheel;
            
        }
        public void Avg()
        {
            if(nw==2||nw==4)
            {
                avg = 20;
            }
            else
            {
                avg = 10;
            }
        }
        public void Displsy()
        {
            Console.WriteLine(+model_no + "  " + ty + " " + nw + " " + avg + "");
        }
        static void Main(string[]args)
        {
            Method_vehicle d = new Method_vehicle();
            d.Accept(4123, "Moped Bike", 8);
            d.Avg();
                d.Displsy();

        }

    }
}
