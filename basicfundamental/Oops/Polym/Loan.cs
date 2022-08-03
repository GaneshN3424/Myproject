using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Oops.Polym
{
    class Loan
    {
       float calculate_loan(int P,float R,int T)
       {
            float loan;
            return loan = (float)P * R * T;
       }
        float calculate_loan(int P,float R1,float R2,int T)
        {
            float loan1;
            if(T<=6)
            {
                return loan1 = (float)P * R1 * T;
            }
            else
            {
                return loan1 = (float)P * R2 * T;
            }
        }
        static void Main(string[]args)
        {

            Loan m = new Loan();
            Console.WriteLine(m.calculate_loan(10000, 12f, 3));
            Console.WriteLine(m.calculate_loan(10000, 2f, 5f, 6));
        }

    }
}
