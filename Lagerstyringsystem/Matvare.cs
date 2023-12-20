using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringsystem
{
    internal class Matvare : IProdukt
    {
        public string Navn { get; set; }
        public double Pris { get; set; }

        public double Utløpsdato { get; set; }

        public Matvare(string navn, double pris, double utløpsdato) 
        {
            Navn = navn;
            Pris = pris;
            Utløpsdato = utløpsdato;
        }
        public void SkrivUtInfo()
        {
            Console.WriteLine($"Matvare - Navn: {Navn}, Pris: {Pris}, Utløpsdato: {Utløpsdato} dato");
        }
    }
}
