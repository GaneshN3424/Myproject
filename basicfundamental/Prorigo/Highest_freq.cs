using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basicfundamental.Prorigo
{
    class Highest_freq
    {
        static void DisplayHigh(string s)
        {
            s = s.ToLower();
            int max = 0;
            string cmax = "";
           
            for(int i = 0; i < s.Length; i++)
            {
                int count = 1;
                bool isVisited = true;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (s[i] == s[k])
                    {
                        isVisited = false;
                        break;
                    }
                }
                if (isVisited == true)
                {
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[i] == s[j])
                        {
                            count++;
                            
                        }
                    }

                    if(max<count)
                    {
                        max = count;
                        cmax =""+ s[i];//overwrite
                    }
                    else if(max==count)
                    {
                       
                        cmax = cmax + s[i]; //append //pa

                    }
                }
            }

            Console.WriteLine($"Character is {cmax} and freq is {max}");
        }
        static void Main(string[] args)
        {
            string str = "papayyy";
            DisplayHigh(str);
        }
    }
}
