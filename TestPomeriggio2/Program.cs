public class ContoCorrente
{
    private decimal saldo;
    private int numeroOperazioni;

    public decimal Saldo
    {
        get { return saldo; }
    }

    public int NumeroOperazioni
    {
        get { return numeroOperazioni; }
    }
    public void Versa(decimal versato)
    {
        if (versato >= 0)
        {
            saldo += versato;
            numeroOperazioni++;
        }
    }
    public void Preleva(decimal valore)
    {
        if (valore >= 0 && valore <= saldo)
        {
            saldo -= valore;
            numeroOperazioni++;
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        ContoCorrente conto = new ContoCorrente();

        conto.Versa(100);
        conto.Preleva(20);

        Console.WriteLine($"Saldo finale {conto.Saldo}, numero operazioni svolte {conto.NumeroOperazioni}");
    }
}