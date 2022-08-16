using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray.ArrayTest
{

    class Car
    {
        int car_id;
        string C_Color;
        Engine en;
        Sub_Engine sb;
        Grear G;
        public int Car_ID
        {
            get { return car_id; }
            set { car_id = value; }
        }
        public string c_color
        {
            get { return C_Color; }
            set { C_Color = value; }
        }
        public Engine En
        {
            get { return en; }
            set { en = value; }
        }
        public Sub_Engine SB
        {
            get { return sb; }
            set { sb = value; }
        }
        public Grear g
        {
            get { return G; }
            set { G = value; }
        }
            

    }
    class Engine
    {
        int engine_id;
        string Last_e_Date;
        public int Engine_ID
        {
            get { return engine_id; }
            set { engine_id = value; }
        }
        public string last_e_date
        {
            get { return Last_e_Date; }
            set { Last_e_Date = value; }
        }
    }
    class Sub_Engine
    {
        string Sub_type;
        public string Sub_Type
        {
            get { return Sub_type; }
            set { Sub_type = value; }
        }

    }
    class Grear
    {
        string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
        


    class Carinfo2
    {

        static void Main(string[]args)
        {
            Car c = new Car();
            c.Car_ID = 525874;
            c.c_color = "Black";
            c.En = new Engine();
            c.En.Engine_ID = 255;
            c.En.last_e_date = "15/08/2022";
            c.SB = new Sub_Engine();
            c.SB.Sub_Type = "Petrol";
            c.g = new Grear();
            c.g.Type = "Auto";

            Console.WriteLine(c.Car_ID + "  \n " + c.c_color + " \n   " + c.En.Engine_ID + "\n  "+c.En.last_e_date + " \n  " + c.SB.Sub_Type + "\n  " + c.g.Type);
        }
    }
}
