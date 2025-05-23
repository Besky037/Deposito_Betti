using System;
using System.ComponentModel.Design;
public class Operatore
{
    private string nome;
    private string turno;

    public string Nome { get; set; }
    public string Turno
    {
        get { return turno; }
        set
        {
            if (value.ToLower() == "giorno" || value.ToLower() == "notte")
            {
                turno = value.ToLower();
            }
        }
    }
    public Operatore(string nome, string turno)
    {
        Nome = nome;
        Turno = turno;
    }
    public virtual void EseguiCompito()
    {
        Console.WriteLine("Operatore generico in servizio.");
    }
}

public class OperatoreEmergenza : Operatore
{
    private int livelloUrgenza;
    public int LivelloUrgenza
    {
        get { return livelloUrgenza; }
        set
        {
            if (value >= 1 && value <= 5)
            {
                livelloUrgenza = value;
            }
        }
    }
    public OperatoreEmergenza(string nome, string turno, int livelloUrgenza) : base(nome, turno)
    {
        LivelloUrgenza = livelloUrgenza;
    }
    public override void EseguiCompito()
    {
        Console.WriteLine($"Gestione emergenza di livello {LivelloUrgenza}");
    }
}

public class OperatoreSicurezza : Operatore
{
    private  string areaSorvegliata;
    public  string AreaSorvegliata { get; set; }
    public OperatoreSicurezza(string nome, string turno, string areaSorvegliata) : base(nome, turno)
    {
        AreaSorvegliata = areaSorvegliata;
    }
    public override void EseguiCompito()
    {
        Console.WriteLine($"Sorveglianza dell'area {AreaSorvegliata}");
    }
}

public class OperatoreLogistica : Operatore
{
    private int numeroConsegne;
    public int NumeroConsegne{
        get { return numeroConsegne; }
        set
        {
            if (value >= 0)
            {
                numeroConsegne = value;
            }
        }
    }
    public OperatoreLogistica(string nome, string turno, int numeroConsegne) : base(nome, turno)
    {
        NumeroConsegne = numeroConsegne;
    }
        public override void EseguiCompito()
    {
        Console.WriteLine($"Coordinamento di {NumeroConsegne} consegne");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Operatore> operatori = new List<Operatore>();
        bool menu = true;
        while (menu)
        { }
    }
}