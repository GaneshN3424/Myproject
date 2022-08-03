using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Conditonal
{
    class Uppercase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter char");
            char ch = Convert.ToChar(Console.ReadLine());
            if(ch=='A')
            {
                Console.WriteLine("Enter char is Vowel");
            }
            else if(ch=='E')
            {
                Console.WriteLine("Enter char is Vowel");
            }
            else if(ch=='O')
            {
                Console.WriteLine("Enter char is Vowel");
            }
            else if(ch=='I')
            {
                Console.WriteLine("Enter char is Vowel");
            }
            else if(ch=='U')
            {
                Console.WriteLine("Enter char is Vowel");
            }
            else
            {
                Console.WriteLine("Enter char is Consonent");
            }
        }
    }
}
