using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringQuestion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            count();
            Console.WriteLine();
            containstring();
        }

        public static void count()
        {
            string s = "codenera";
            Console.WriteLine(s);

            int v = 0;
            int c = 0;
            
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                    v++;
                }
                else if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z'))
                {
                    c++; // Increment the consonant count
                }

            }

            Console.WriteLine("Vowels:  {0}", v);
            Console.WriteLine("consonants :  {0}",  c);
        }


        public static void containstring()
        {
            string s = "Hello wel come home";
            string s2 = "come";

            Console.WriteLine(s);

            bool m = s.Contains(s2); 

         
            if (m) 
                Console.Write("The substring exists in the string.\n\n");
            else
                Console.Write("The substring does not exist in the string.\n\n");
        }
    }
}
