﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06RzutowanieDanych
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
        //    string b = a;

            object c = a; // traktuję inta jako obiekt  (rztuowanie int na object)
            object d = "ala"; // traktuję ten string jako obiekt  (rzutowanie string na object) 
            // w dodatko te rzutowania są niejawne tzn nie muszę tego jawnie pisać

            object e = (object)"ala"; // to nie jest potrzebne 
            // dlatego , że object jest typem barzdiej ogólnym od tpyu string 


            string f = (string)e; // przprowadzam rzutowanie jawne
            // a muszę zrobić rzutwonie jawne poniewaz , z typu 
            // bardziej ogólnego do typu szczgółowego muszę sprecyzować
            // konkretnie na co rzutuję 

             





        }
    }
}
