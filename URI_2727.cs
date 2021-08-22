using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace URI
{
    class Program
    {
        static readonly IDictionary<string, char> dictionary = new Dictionary<string, char>();
        static void Main(string[] args)
        {
            CreateAlphabet();
            int n;
            string value;
            while ((value = Console.ReadLine()) != null)
            {
                n = int.Parse(value);
                while (n-- > 0)
                    Console.WriteLine(dictionary[Console.ReadLine()]);
            }
        }


        static void CreateAlphabet()
        {
            int fatorA = 'a';
            int fatorB = 'b';
            int fatorC = 'c';

            string a = ".";
            string b = "..";
            string c = "...";

            dictionary[a] = (char)fatorA;
            dictionary[b] = (char)fatorB;
            dictionary[c] = (char)fatorC;

            int calc = 27 / 3 - 1;
            for (int i = 0; i < calc; i++)
            {
                var fa = (char)(fatorA += 3);
                var fb = (char)(fatorB += 3);
                var fc = (char)(fatorC += 3);
                a += " .";
                b += " ..";
                c += " ...";

                dictionary[a] = fa;
                dictionary[b] = fb;
                dictionary[c] = fc;
            }
        }
    }
}
