using System;
public class Studente
{
    public string Nome;
    public int Matricola;
    public double MediaVoti;

    public void Stampa()
    {
        Console.WriteLine($"Dati studente: \nNome: {Nome}, \nMatricola: {Matricola}, \nMedia {MediaVoti}.");
    }

    public class Programma
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 2; i++)
            {
                Studente mioStudente = new Studente();
                Console.WriteLine($"Inserire Nome Studente {i}:");
                mioStudente.Nome = Console.ReadLine();
                Console.WriteLine($"Inserire Matricola {i}:");
                mioStudente.Matricola = int.Parse(Console.ReadLine());
                Console.WriteLine($"Inserire Media {i}:");
                mioStudente.MediaVoti = double.Parse(Console.ReadLine());
                mioStudente.Stampa();
            }
            

        }
    }
}
