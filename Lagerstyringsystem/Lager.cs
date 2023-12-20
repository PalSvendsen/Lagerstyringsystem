using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringsystem
{
    internal class Lager
    {
        private List<IProdukt> produkter;
       public Lager() 
        {
            produkter = new List<IProdukt>();
        }

        public void LeggTil(IProdukt produkt)
        {
           produkter.Add(produkt);
        }

        public void Fjern(IProdukt produkt)
        {
            if (produkter.Contains(produkt)) { 
            produkter.Remove(produkt);
            Console.WriteLine($"Produktet {produkt.Navn} er fjernet fra lageret.");
            }
            else
            {
                Console.WriteLine($"Produktet {produkt.Navn} er ikke funnet i lageret.");
            }
        }

        public void VisAlleProdukter()
        {
            foreach (var produkt in produkter)
            {
                produkt.SkrivUtInfo();
            }
        }

        public IProdukt HentProdukt(string navn)
        {
            foreach (var produkt in produkter)
            {
                if (produkt.Navn.Equals(navn, StringComparison.OrdinalIgnoreCase))
                {
                    return produkt;
                }
            }
            return null; 
        }
    }
}
