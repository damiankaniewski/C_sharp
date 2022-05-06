using System.Security.Authentication.ExtendedProtection;

namespace Zad1
{
    class Program
    {
        public class Triangle
        {
            public Triangle(double a, double b, double c)
            {
                A = a;
                B = b;
                C = c;
            }

            public double A { get; }
            public double B { get; }
            public double C { get; }

            public double Area()
            {
                var p = (A + B + C) / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }

            public double Circumference()
            {
                return A + B + C;
            }
        }

        static void Main(string[] args)
        {
            double x = 0;
            double y = 0;
            double z = 0;
            
            var triangle1 = new Triangle(x, y, z);
            Console.WriteLine("Bok 1 = " + triangle1.A);
            Console.WriteLine("Bok 2 = " + triangle1.B);
            Console.WriteLine("Bok 3 = " + triangle1.C);
            Console.WriteLine("Pole = " + triangle1.Area());
            Console.WriteLine("Obwod = " + triangle1.Circumference());
        }

        public static bool Check(double a, double b, double c)
        {
            if (a < b + c && b < a + c && c < a + b)
            {
                return true;
            }

            Console.WriteLine("Podaj poprawne boki!");
            return false;
        }
    }
}