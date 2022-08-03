using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Oops
{
    class Animal
    {
        public string name;
        public int legs;
        public string Food;

        static void Main(string[] args)
        {
            Animal Tiger = new Animal();
            Tiger.name = "Tiger";
            Tiger.legs = 4;
            Tiger.Food = "Carnivorous";
            Console.WriteLine(Tiger.name + "  " + Tiger.legs + "  " + Tiger.Food);


            Animal Rabit = new Animal();
            Rabit.name = "Rabit";
            Rabit.legs = 4;
            Rabit.Food = "Herbivorous";
            Console.WriteLine(Rabit.name + "  " + Rabit.legs + "  " + Rabit.Food);
        }
    }
}
