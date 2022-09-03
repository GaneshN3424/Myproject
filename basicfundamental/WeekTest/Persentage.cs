using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental
{
    class Persentage
    {
      static void Main(string []args)
        {
            int English = 50, Hindi = 45, Marathi = 65, Math = 40, Science = 65;
            int Total;
            double Percentage;
            Total = English + Hindi + Marathi + Math + Science;
            Percentage = Total / 5;
            Console.WriteLine(Percentage +"%");
        }    
    }
}
