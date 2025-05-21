using System;
//Crea  Classe Film con Titolo, Regista, Anno e Genere
public class Film
{
    public string Titolo;
    public string Regista;
    public int Anno;
    public string Genere;

    public Film(string titolo, string regista, int anno, string genere)
    {
        Titolo = titolo;
        Regista = regista;
        Anno = anno;
        Genere = genere;
    }
    public void Stampa()
    {
        Console.WriteLine($"Titolo: {Titolo}, Regista: {Regista}, Anno: {Anno}, Genere: {Genere}");
    }
}
//Crea Lista di oggetti film (VideoTeca)
public class VideoTeca
{
    private List<Film> videoTeca = new List<Film>();

    public void InserisciFilm()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nInserisci Film {i + 1}:");

            Console.Write("Titolo: ");
            string titolo = Console.ReadLine();

            Console.Write("Regista: ");
            string regista = Console.ReadLine();

            Console.Write("Anno: ");
            int anno = int.Parse(Console.ReadLine());

            Console.Write("Genere: ");
            string genere = Console.ReadLine();

            videoTeca.Add(new Film(titolo, regista, anno, genere));
        }
    }
    public void StampaFilm()
    {
        foreach (Film film in videoTeca)
        {
            film.Stampa();
        }
    }
    public void Ricerca(string genere)
    {
        foreach (var film in videoTeca)
        {
            if (film.Genere.Equals(genere))
            {
                film.Stampa();
            }
        }
    }
    public static void Main()
    {
        VideoTeca videoteca = new VideoTeca();

        videoteca.InserisciFilm();

        Console.WriteLine("Ricerca per Genere: ");        string genere = Console.ReadLine();
        videoteca.Ricerca(genere);
    }
}

//Permetti all'utente di inserire film (almeno 3) con dati, Stampare tutti i film, ricerca per genere