namespace Zad1;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Podaj gatunek: ");
        string gatunek = Console.ReadLine();
        
        Console.WriteLine("Podaj wiek: ");
        int wiek = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Podaj plec: ");
        string plec = Console.ReadLine();
        
        Zwierze zwierze1 = new Zwierze(gatunek, wiek, plec);
        zwierze1.Wypisz();
    }
}