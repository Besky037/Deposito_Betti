class Esercizi
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Inserire i fattori:");
        int fattore1 = int.Parse(Console.ReadLine());
        int fattore2 = int.Parse(Console.ReadLine());

        int somma = Somma(fattore1, fattore2);
        int moltiplica = Moltiplica(fattore1, fattore2);
        int dividi = Dividi(fattore1, fattore2);

        StampaRisultato("Somma", somma);
        StampaRisultato("moltiplicazione", moltiplica);
        StampaRisultato("divisione", dividi);
    }

    static int Somma(int fattore1, int fattore2)
    {
        return fattore1 + fattore2;
    }

    static int Moltiplica(int fattore1, int fattore2)
    {
        return fattore1 * fattore2;
    }

    static int Dividi(int fattore1, int fattore2)
    {
        if (fattore2 == 0)
        {
            Console.WriteLine("We non posso dividere pe' 0");
            return 0;
        }
        else
        {
            return fattore1 / fattore2;
        }
    }

    static void StampaRisultato(string operazione, int risultato)
    {
        Console.WriteLine($"Il risultato della {operazione} è {risultato}");
    }
}