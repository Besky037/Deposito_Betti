using System;
using System.Runtime.CompilerServices;
public class Libro
{
    public string Titolo;
    public string Autore;
    public int AnnoPub;

    public Libro(string titolo, string autore, int annoPub)
    {
        Titolo = titolo;
        Autore = autore;
        AnnoPub = annoPub;
    }
    public override string ToString()
    {
        return $"{Titolo} di {Autore}, {AnnoPub}";
    }
    public override bool Equals(object obj)
    {
        if (obj is Libro altro)
        {
            return Titolo == altro.Titolo && Autore == altro.Autore;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Titolo, Autore);  
    }
}
public class Programma
{
    public static void Main(string[] args)
    {
        //Libro libro1 = new Libro("Who Goes There", "John W. Campbell", 1938);
        //Libro libro2 = new Libro("Murder on the Orient Express", "Agatha Christie", 1934);
        Libro libro1 = new Libro("Titolo1", "Autore1", 2005);
        Libro libro2 = new Libro("Titolo1", "Autore1", 2007);
        Console.WriteLine(libro1.ToString());

        Console.WriteLine(libro1.Equals(libro2));
        
        Console.WriteLine(libro1.GetHashCode() == libro2.GetHashCode());
    }
}