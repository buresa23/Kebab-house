﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kebab_house
{
    internal class Kebaby
    {
        public string Nazev { get; private set; }
        public int PotrebneMaso {  get; private set; }
        public int PotrebneSalat { get; private set; }
        public int PotrebneZeli { get; private set; }

        public Kebaby(string nazev, int potrebneMaso, int potrebneSalat, int potrebneZeli) 
        {
        PotrebneMaso = potrebneMaso;
        PotrebneSalat = potrebneSalat;
        PotrebneZeli = potrebneZeli;
        }

    }
}
