﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga2
{
    class Popotnik : Oseba
    {
        private string elektronskiNaslov;
        public string ElektronskiNaslov
        {
            get { return elektronskiNaslov; }
            set { elektronskiNaslov = value; }
        }

        public Popotnik():base(){}

        public Popotnik(string ime, string priimek, string elektronskiNaslov) :base(ime,priimek)
        {
            this.elektronskiNaslov = elektronskiNaslov;
        }

        sealed public override void izpis()
        { 
            Console.WriteLine(string.Format("{0} {1} {2} {3}", Ime, Priimek, Spol, RojstniDatum, ElektronskiNaslov));
        }
    }
}
