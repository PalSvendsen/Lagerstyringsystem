using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringsystem
{
    internal class Elektronikk : IProdukt
    {
        public string Navn { get; set; }
        public double Pris { get; set; }
        public int Garantitid { get; set; }
        public Elektronikk(string navn, double pris, int garantitid) 
        { 
            Navn = navn;
            Pris = pris;
            Garantitid = garantitid;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Elektronikk - Navn: {Navn}, Pris: {Pris}, Garantitid: {Garantitid} måneder");
        }
    }
}
