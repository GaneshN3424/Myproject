using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.week_test_3
{

    class ConstructorChain
    {
        string St_N;
        int Year;
        int Total_fees;
        int insu;

        ConstructorChain(string St_N, int Year, int Total_fees, int insu)
        {
            this.St_N = St_N;
            this.Year = Year;
            this.Total_fees = Total_fees;
            this.insu = insu;

        }

        ConstructorChain() : this("Ganesh", 4, 46000, 200)
        {
            Total_fees = Total_fees + insu;
            Fees();
        }
        void Fees()
        {
            Console.WriteLine(St_N+"  "+Year+"  "+ Total_fees);
        }

        static void Main(string[] args)
        {
            ConstructorChain d = new ConstructorChain();
        }

    }
}
