using System;

public class Veicolo
{
    public string Marca { get; set; }
    public string Modello { get; set; }
    public int AnnoImmatricolazione { get; set; }

    public virtual void StampaInfo()
    {
        Console.WriteLine($"Marca: {Marca}, Modello: {Modello}, Anno: {AnnoImmatricolazione}");
    }

    public Veicolo(string marca, string modello, int annoImmatricolazione)
    {
        Marca = marca;
        Modello = modello;
        AnnoImmatricolazione = annoImmatricolazione;
    }
}

public class AutoAziendale : Veicolo
{
    public string Targa { get; set; }
    public bool UsoPrivato { get; set; }
    public AutoAziendale(string marca, string modello, int annoImmatricolazione, string targa, bool usoPrivato)
        : base(marca, modello, annoImmatricolazione)
    {
        Targa = targa;
        UsoPrivato = usoPrivato;
    }

    public override void StampaInfo()
    {
        base.StampaInfo();
        Console.WriteLine($"Targa: {Targa}, Uso Privato: {UsoPrivato}");
    }
}

public class FurgoneAziendale : Veicolo
{
    public int CapacitaCarico { get; set; }
    public FurgoneAziendale(string marca, string modello, int annoImmatricolazione, int capacitaCarico)
        : base(marca, modello, annoImmatricolazione)
    {
        CapacitaCarico = capacitaCarico;
    }

    public override void StampaInfo()
    {
        base.StampaInfo();
        Console.WriteLine($"Capacità Carico: {CapacitaCarico} KG.");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        List<Veicolo> veicoli = new List<Veicolo>
        {
            new AutoAziendale("Fiat", "Punto", 2015, "AB123CD", true),
            new FurgoneAziendale("Iveco", "Daily", 2020, 1200),
        };
        foreach (Veicolo v in veicoli)
        {
            v.StampaInfo();
        }
    }
}