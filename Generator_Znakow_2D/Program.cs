namespace Zad1;

class Program
{
    private static Random random = new Random();

    public static string RandomString(int length)
    {
        const string character = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(character, length).Select(s => s[random.Next(s.Length)]).ToArray());
    }

    
    public static void Show_Board(string[,] board)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Console.Write(board[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    public static void Generate_Board(string[,] board)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                board[i, j] = RandomString(1);
            }
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj wymiary obrazu, ktory chcesz wygenerowac: ");
        Console.Write("Wysokosc: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Szerokosc: ");
        int y = int.Parse(Console.ReadLine());
        
        string[,] board = new string[x, y];
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                board[i, j] = "x";
            }
        }
        Console.WriteLine("Obraz podstawowy:");
        Show_Board(board);
        Generate_Board(board);
        Console.WriteLine("Obraz po wygenerowaniu:");
        Show_Board(board);
    }
}