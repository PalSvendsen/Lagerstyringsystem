using Lagerstyringsystem;

class Program
{
    static void Main()
    {
        Lager lager = new Lager();
       
        IProdukt klær1 = new Klær("LunarStyle", 799.50, "Small");
        IProdukt klær2 = new Klær("UrbanChic", 1299.90, "Large");
        IProdukt elektronikk1 = new Elektronikk("TechWave", 2499, 24);
        IProdukt elektronikk2 = new Elektronikk("ElectroGizmo", 899, 30);
        IProdukt matvare1 = new Matvare("GourmetDelights", 149, 12.12);
        IProdukt matvare2 = new Matvare("Nature'sHarvest", 79, 24.12);

        while(true) { 
        lager.LeggTil(klær1);
        lager.LeggTil(klær2);
        lager.LeggTil(elektronikk1);
        lager.LeggTil(elektronikk2);
        lager.LeggTil(matvare1);
        lager.LeggTil(matvare2);

        lager.VisAlleProdukter();

        Console.WriteLine("Hvilken produkt vil du fjerne?");
        string valg = Console.ReadLine();

        IProdukt produktSomSkalFjernes = lager.HentProdukt(valg);

        if (produktSomSkalFjernes != null)
        {
                Console.Clear();
            lager.Fjern(produktSomSkalFjernes);
            Console.WriteLine($"{produktSomSkalFjernes.Navn} er fjernet fra lageret.");
        }
        else
        {
            Console.WriteLine($"Produktet med navn {valg} ble ikke funnet i lageret.");
        }

    }
}
}