using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistenych
{
    public class Databaze
    {

        private List<Clovek> pojistenci;


        public Databaze()
        {
            pojistenci = new List<Clovek>();
            pojistenci.Add(new Clovek("Adam", "Gott", 22, 222222222));
        }

        public void PridejPojistence()
        {
            int vek, telefon;
            Console.WriteLine(" \n\nZadej jmeno:");
            string jmeno = Console.ReadLine();

            Console.WriteLine("Zadej prijmeni:");
            string prijmeni = Console.ReadLine();
            Console.WriteLine("Zadej vek:");
            //int vek = int.Parse(Console.ReadLine());
            //Console.WriteLine("Zadej telefon:");
            //int telefon = int.Parse(Console.ReadLine());

            while (!int.TryParse(Console.ReadLine(), out vek))
            {
                Console.WriteLine("Špatně zadáno");
            }
            Console.WriteLine("Zadej telefon:");
            while (!int.TryParse(Console.ReadLine(), out telefon))
            {
                Console.WriteLine("Špatně zadáno");
            }
            pojistenci.Add(new Clovek(jmeno, prijmeni, vek, telefon));

        }
        public void VypisPojistence()
        {
            Console.WriteLine("\n\nPojištěnci v databázi:");
            foreach (Clovek c in pojistenci)
                Console.WriteLine(c);
        }
        public void VyhledejPojistence()
        {
            string jmeno, prijmeni;
            Console.WriteLine("\n\nZadejte jméno:");
            jmeno= Console.ReadLine();
            Console.WriteLine("Zadejte prijmeni:");
            prijmeni = Console.ReadLine();
            Clovek x = null;
            foreach (Clovek c in pojistenci)
            {
                if (c.Jmeno == jmeno && c.Prijmeni == prijmeni)
                {
                    x = c; break;
                }
            }
            if (x != null) { Console.WriteLine(x); }
            else
            Console.WriteLine("Pojištěnec nenalezen");
        }
    }
}





