using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Oops
{
    class car
    {
        public int model_Number;
        public string car_name;
        public int car_price;
        public string car_color;



        static void Main(string[] args)
        {
            car audi = new car();
            audi.car_name = "Audi";
            audi.model_Number = 4655555;
            audi.car_price = 1800000;
            audi.car_color = "Black";
            Console.WriteLine(audi.car_name + " " + audi.model_Number + " " + audi.car_price + " " + audi.car_color);



            car i10 = new car();
            i10.car_name = "i10";
            i10.model_Number = 123455;
            i10.car_price = 1000000;
            i10.car_color = "White";
            Console.WriteLine(i10.car_name + " " + i10.model_Number + " " + i10.car_price + " " + i10.car_color);


            car honda = new car();
            honda.car_name = "Honda";
            honda.model_Number = 6874555;
            honda.car_price = 700000;
            honda.car_color = "White";
            Console.WriteLine(honda.car_name + " " + honda.model_Number + " " + honda.car_price + " " + honda.car_color);



            car MG = new car();
            MG.car_name = "MG Vector";
            MG.model_Number = 369855;
            MG.car_price = 1500000;
            MG.car_color = "Black";
            Console.WriteLine(MG.car_name + " " + MG.model_Number + " " + MG.car_price + " " + MG.car_color);



        }

    }
   
}
