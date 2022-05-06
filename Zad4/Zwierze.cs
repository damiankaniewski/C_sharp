namespace Zad1;

public class Zwierze
{
    public string Gatunek;
    public int Wiek;
    public string Plec;
    public Zwierze(string gatunek, int wiek, string plec)
    {
        Gatunek = gatunek;
        Wiek = wiek;
        Plec = plec;
    }

    public void Wypisz()
    {
        Console.WriteLine("Gatunek: " + Gatunek + "\tWiek: " + Wiek + "\tPlec: " + Plec);
    }
}