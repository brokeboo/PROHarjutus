﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjHarjutus
{
    class Alamprogramm
    {
        static int  Korruta(int arv1, int arv2)
        {
            return arv1 * arv2;
        }
        static void Main(string[] args)
        {
            int a = 2;
            int b = 5;
            Console.WriteLine("{0} * {1} = {2}", a, b, Korruta(a, b));
        }
    }
}
