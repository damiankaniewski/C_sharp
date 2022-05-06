namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe, z ktorej chcesz obliczyc silnie: ");
            int x = int.Parse(Console.ReadLine());
            int silnia = 1;
            for (int i = 1; i <= x; i++)
            {
                silnia = silnia * i;
            }
            Console.WriteLine("Silnia to: " + silnia);
        }
    }
}