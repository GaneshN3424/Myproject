using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.DemoArray
{
    class CharArray
    {

        static void Main(string[]args)
        {
            Console.WriteLine("Enter the size Of Array");
            int size = int.Parse(Console.ReadLine());

            char[] c = new char[size];

            Console.WriteLine("Enter the char type array element");

            for(int i=0;i<c.Length;i++)
            {
                c[i] = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine("     .......................................          ");
            foreach(char x in c)
            {
                Console.WriteLine(x);
            }


            Console.WriteLine("..........Reverse Array is..........");
            for(int i=c.Length-1;i>=0;i--)
            {
                Console.Write("  "+c[i]);
            }
        }

    }
}
