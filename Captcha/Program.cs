namespace Zad1;

class Program
{
    private static Random random = new Random();

    public static string RandomString(int length)
    {
        const string znak = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(znak, length).Select(s => s[random.Next(s.Length)]).ToArray());
    }

    public static bool Captcha(string randomstr, string tekst)
    {
        for (int i = 0; i < tekst.Length; i++)
        {
            if (randomstr[i] != tekst[i])
            {
                Console.WriteLine("Niestety, wygenerowany tekst wpisany niepoprawnie!");
                return true;
            }
        }

        Console.WriteLine("Brawo, wpisales tekst poprawnie!");
        return false;
    }

    static void Main(string[] args)
    {
        bool result = true;
        while (result){
            string randomstr = RandomString(6);
            Console.WriteLine("Przepisz ponizszy tekst, by udowodnic, ze nie jestes robotem:\n" + randomstr);
            string tekst = Console.ReadLine();
            result = Captcha(randomstr, tekst);
        }
    }
}