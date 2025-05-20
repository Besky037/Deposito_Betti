using System;

class Programma
{
    static void Main(string[] args)
    {
        //Array();
        Lista();
    }

    static void Array()
    {
        int[] voti = new int[5];
        for (int i = 0; i < voti.Length; i++)
        {
            Console.Write($"Inserisci il voto {i + 1}: ");
            voti[i] = int.Parse(Console.ReadLine());
        }

        int max = 0;
        int min = 100;
        int somma = 0;

        for (int i = 0; i < voti.Length; i++)
        {
            somma += voti[i];
            if (voti[i] > max) max = voti[i];
            if (voti[i] < min) min = voti[i];
        }

        float media = somma / (float)voti.Length;

        Console.WriteLine("Media: " + media);
        Console.WriteLine("Alto: " + max);
        Console.WriteLine("Basso: " + min);
    }
    static void Lista(){
        
        List<string> listaSpesa = new List<string>();
        
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Inserisci Prodotto: {i + 1}: ");
            string prodotto = Console.ReadLine();
            listaSpesa.Add(prodotto);
        }
        Console.WriteLine("Lista della spesa:");
        foreach (string oggetto in listaSpesa)
        {
            Console.WriteLine(oggetto);
        }
    }
}