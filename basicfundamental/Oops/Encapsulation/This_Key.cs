using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Oops.Encapsulation
{
    class College
    {
        string St_N;
        int Year;
        int Total_fees;
        int insu;

        College(string St_N,int Year,int Total_fees,int insu )
        {
            this.St_N = St_N;
            this.Year = Year;
            this.Total_fees = Total_fees;
            this.insu = insu;
            
        }

        College():this("Ganesh",4,46000,200)
        {
            Total_fees = Total_fees + insu;
            Fees();
        }
        void Fees()
        {
            Console.WriteLine(Total_fees);
        }

        static void Main(string[]args)
        {
            College d = new College();
        }

    }
}
