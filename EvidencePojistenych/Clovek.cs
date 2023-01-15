﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistenych
{
    internal class Clovek
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Vek { get; set; }
        public int Telefon { get; set; }

        public Clovek(string jmeno, string prijmeni, int vek, int telefon)
        {
            this.Jmeno = jmeno;
            this.Prijmeni = prijmeni;
            this.Vek = vek;
            this.Telefon = telefon;
        }
        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}", Jmeno, Prijmeni, Vek, Telefon);
        }
        

    }

}
