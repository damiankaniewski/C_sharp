namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] plansza = new string[3, 3];
            for (int i = 0; i < plansza.GetLength(0); i++)
            {
                for (int j = 0; j < plansza.GetLength(1); j++)
                {
                    plansza[i, j] = ".";
                }
            }

            static void Info()
            {
                Console.WriteLine("Wspolrzedne oznaczone sa w nastepujacy sposob:");
                Console.WriteLine("  0 1 2 <- x");
                Console.WriteLine("0 . . .");
                Console.WriteLine("1 . . .");
                Console.WriteLine("2 . . .");
                Console.WriteLine("^");
                Console.WriteLine("|");
                Console.WriteLine("y");

                Thread.Sleep(2000);
            }

            static void Show(string[,] plansza)
            {
                Console.WriteLine("Plansza: ");
                for (int i = 0; i < plansza.GetLength(0); i++)
                {
                    for (int j = 0; j < plansza.GetLength(1); j++)
                    {
                        Console.Write(plansza[i, j] + " ");
                    }

                    Console.WriteLine();
                }
            }

            static void MovePlayer(string[,] plansza, string znakPlayer, string znakComputer)
            {
                Console.WriteLine("Ruch gracza: ");
                powrot:
                Console.WriteLine("Wybierz wspolrzedne gdzie chcesz postawic znak: ");
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                if (x > 2 || x < 0 || y > 2 || y < 0)
                {
                    goto powrot;
                }

                if (plansza[y, x] == ".")
                {
                    plansza[y, x] = znakPlayer;
                }
                else
                {
                    Console.WriteLine("Podaj puste pole!");
                    goto powrot;
                }
            }

            static void MoveComputer(string[,] plansza, string znakPlayer, string znakComputer)
            {
                //Console.WriteLine("Wybierz wspolrzedne gdzie chcesz postawic znak: ");
                Random rnd = new Random();
                powrot:
                int x = rnd.Next(0, 3);
                int y = rnd.Next(0, 3);
                if (plansza[y, x] == ".")
                {
                    plansza[y, x] = znakComputer;
                }
                else
                {
                    goto powrot;
                }

                Console.Write("Ruch komputera");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.WriteLine(".");
                Thread.Sleep(200);
            }

            static void Wynik(string[,] plansza, string znakPlayer, string znakComputer)
            {
                if ((plansza[0, 0] == "." && plansza[0, 1] == "." && plansza[0, 2] == ".") ||
                    (plansza[1, 0] == "." && plansza[1, 1] == "." && plansza[1, 2] == ".") ||
                    (plansza[2, 0] == "." && plansza[2, 1] == "." && plansza[2, 2] == ".") ||
                    (plansza[0, 0] == "." && plansza[0, 1] == "." && plansza[2, 0] == ".") ||
                    (plansza[0, 1] == "." && plansza[1, 1] == "." && plansza[2, 1] == ".") ||
                    (plansza[0, 2] == "." && plansza[1, 2] == "." && plansza[2, 2] == ".") ||
                    (plansza[0, 0] == "." && plansza[1, 1] == "." && plansza[2, 2] == ".") ||
                    (plansza[0, 2] == "." && plansza[1, 1] == "." && plansza[2, 0] == "."))
                {
                    Thread.Sleep(100);
                }
                else if ((plansza[0, 0] == "x" && plansza[0, 1] == "x" && plansza[0, 2] == "x") ||
                         (plansza[1, 0] == "x" && plansza[1, 1] == "x" && plansza[1, 2] == "x") ||
                         (plansza[2, 0] == "x" && plansza[2, 1] == "x" && plansza[2, 2] == "x") ||
                         (plansza[0, 0] == "x" && plansza[0, 1] == "x" && plansza[2, 0] == "x") ||
                         (plansza[0, 1] == "x" && plansza[1, 1] == "x" && plansza[2, 1] == "x") ||
                         (plansza[0, 2] == "x" && plansza[1, 2] == "x" && plansza[2, 2] == "x") ||
                         (plansza[0, 0] == "x" && plansza[1, 1] == "x" && plansza[2, 2] == "x") ||
                         (plansza[0, 2] == "x" && plansza[1, 1] == "x" && plansza[2, 0] == "x"))
                {
                    if (znakPlayer == "x")
                    {
                        Console.WriteLine("Brawo! Wygrales!");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Niestety... Komputer wygral :(");
                        Environment.Exit(0);
                    }
                }
                else if ((plansza[0, 0] == "o" && plansza[0, 1] == "o" && plansza[0, 2] == "o") ||
                         (plansza[1, 0] == "o" && plansza[1, 1] == "o" && plansza[1, 2] == "o") ||
                         (plansza[2, 0] == "o" && plansza[2, 1] == "o" && plansza[2, 2] == "o") ||
                         (plansza[0, 0] == "o" && plansza[0, 1] == "o" && plansza[2, 0] == "o") ||
                         (plansza[0, 1] == "o" && plansza[1, 1] == "o" && plansza[2, 1] == "o") ||
                         (plansza[0, 2] == "o" && plansza[1, 2] == "o" && plansza[2, 2] == "o") ||
                         (plansza[0, 0] == "o" && plansza[1, 1] == "o" && plansza[2, 2] == "o") ||
                         (plansza[0, 2] == "o" && plansza[1, 1] == "o" && plansza[2, 0] == "o"))
                {
                    if (znakPlayer == "o")
                    {
                        Console.WriteLine("Brawo! Wygrales!");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Niestety... Komputer wygral :(");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Thread.Sleep(100);
                }
            }

            Console.WriteLine("Wybierz znak x lub o:");
            string gracz = Console.ReadLine();

            if (gracz == "X" || gracz == "O")
            {
                gracz = gracz.ToLower();
            }

            if (gracz != "x" && gracz != "o")
            {
                Console.WriteLine("Nastepnym razem wybierz poprawny znak!");
                Environment.Exit(0);
            }

            string komp = ChooseSign(gracz);
            Console.WriteLine("Grasz " + gracz + " komputer gra " + komp);

            string ChooseSign(string x)
            {
                string y;

                if (x == "x")
                {
                    y = "o";
                }
                else
                {
                    y = "x";
                }

                return y;
            }


            Info();
            for (int i = 0; i < 30; i++)
            {
                MovePlayer(plansza, gracz, komp);
                Show(plansza);
                Wynik(plansza, gracz, komp);
                MoveComputer(plansza, gracz, komp);
                Show(plansza);
                Wynik(plansza, gracz, komp);
            }
        }
    }
}