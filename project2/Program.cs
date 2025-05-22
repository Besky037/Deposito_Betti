using System;
public class VoloAereo
{
    private int postiOccupati;
    private const int maxPosti = 150;
    public string codicevolo { get; set; }

    public int PostiOccupati
    {
        get { return postiOccupati; }
    }

    public int PostiLiberi
    {
        get { return maxPosti - postiOccupati; }
    }

    public void EffettuaPrenotazione(int numeroPosti)
    {
        if (numeroPosti <= PostiLiberi && numeroPosti > 0)
        {
            postiOccupati += numeroPosti;
            Console.WriteLine($"{numeroPosti} posti prenotati.");
        }
        else
        {
            Console.WriteLine("Prenotazione Fallita");
        }
    }
    public void AnnullaPrenotazione(int numeroPosti)
    {
        if (numeroPosti <= PostiOccupati && numeroPosti > 0)
        {
            postiOccupati -= numeroPosti;
            Console.WriteLine($"{postiOccupati} posti annullati");
        }
        else
        {
            Console.WriteLine("Annullazione Fallita");
        }
    }

    public void VisualizzaStato()
    {
        Console.WriteLine($"CODICE: {codicevolo}, POSTI OCCUPATI: {postiOccupati}, LIBERI: {PostiLiberi}");
    }
}
class Program
{
    static void Main()
    {
        VoloAereo voloAereo = new VoloAereo();
        voloAereo.codicevolo = "RM037";
        bool repeat = true;
        while (repeat)
        {
            Console.WriteLine("Selezionare Opzione Volo: \n[1]Prenotare \n[2]Annullare \n[3]Visualizzare \n[4]Abbandona ");
            int opzione = int.Parse(Console.ReadLine());
            switch (opzione)
            {
                case 1:
                    Console.WriteLine("Inserire Numero Passeggeri");
                    voloAereo.EffettuaPrenotazione(int.Parse(Console.ReadLine()));
                    voloAereo.VisualizzaStato();
                    break;
                case 2:
                Console.WriteLine("Inserire Numero Passeggeri");
                    voloAereo.AnnullaPrenotazione(int.Parse(Console.ReadLine()));
                    voloAereo.VisualizzaStato();
                    break;
                case 3:
                    voloAereo.VisualizzaStato();
                    break;
                case 4:
                    repeat = false;
                    break;
                default:
                    Console.WriteLine("Input Sconosciuto");
                    break;
            }
        }
    }
}