using System;
namespace ClassLibraryL2
{
    public class Complex
    {
        double re, im;

        public Complex(double r, double i)
        {
            re = r;
            im = i;
        }


        public static Complex sum(Complex C1, Complex C2)
        {
            return new Complex(C1.re + C2.re, C1.im + C2.im);
        }

        public static string ToString(Complex C1)
        {
            return "" + C1.re + "  " + C1.im;
        }

    }

    public class Desk
    {
        int n, a, b, c, d, figure;

        public Desk(int nn, int aAttac, int bAttac, int cc, int dd, int ff)
        {
            a = aAttac;
            b = bAttac;
            c = cc;
            d = dd;
            n = nn;
            figure = ff;
        }
        // Количество Клеток на доске
        public static int Count(Desk C1)
        {
            return C1.n * C1.n;
        }
        //Цвет клетки
        public static string Color(Desk C1)
        {
            if ((C1.a % 2 != 0) && (C1.b % 2 == 0)) { return C1.a + " " + C1.b + " is white"; }
            if ((C1.a % 2 == 0) && (C1.b % 2 != 0)) { return C1.a + " " + C1.b + " is black"; }
            return "";
        }
        //Одинаковый цвет
        public static string SameSquare(Desk C1)
        {
            bool tempa, tempb;
            if ((C1.a % 2 != 0) && (C1.b % 2 == 0)) { tempa = true; } else { tempa = false; };
            if ((C1.a % 2 == 0) && (C1.b % 2 != 0)) { tempb = false; } else { tempb = true; };
            if (tempa == tempb) { return "YES"; } else { return "NO"; };

        }
        //Фигура под ударом
        public static void Eating(Desk C1)
        {

            switch (C1.figure)
            {
                case 1:
                    Console.WriteLine(EatPown(C1.a, C1.b, C1.c, C1.d));
                    break;
                case 2:
                    Console.WriteLine(EatEleph(C1.a, C1.b, C1.c, C1.d));
                    break;
                case 3:
                    Console.WriteLine(EatTower(C1.a, C1.b, C1.c, C1.d));
                    break;
                case 4:
                    Console.WriteLine(EatQueen(C1.a, C1.b, C1.c, C1.d));
                    break;
                case 5:
                    Console.WriteLine(EatHorse(C1.a, C1.b, C1.c, C1.d));
                    break;

                default:
                    Console.WriteLine("There is no such figure");
                    break;
            }
        }

        // координаты с названием фигуры = координаты фигуры которая бьет.
        // xf yf = координаты фигуры которую бьют
        public static string EatPown(int xPawn, int yPawn, int xf, int yf)
        {
            if (((yf == yPawn + 1) || (yf == yPawn - 1)) && (xf == xPawn + 1)) { return "Eat"; } else { return "No eat"; };

        }
        public static string EatEleph(int xEleph, int yEleph, int xf, int yf)
        {
            if (((xf - xEleph) == (yf - yEleph)) || ((xf - xEleph) == (-yf + yEleph))) { return "Eat"; } else { return "No eat"; }
        }
        public static string EatTower(int xTower, int yTower, int xf, int yf)
        {
            if ((xTower == xf) || (yTower == yf)) { return "Eat"; } else { return "No eat"; }
        }
        public static string EatQueen(int xQueen, int yQueen, int xf, int yf)
        {
            if ((((xf - xQueen) == (yf - yQueen)) || ((xf - xQueen) == (-yf + yQueen))) || ((xQueen == xf) || (yQueen == yf))) { return "Eat"; } else { return "No eat"; }

        }
        public static string EatHorse(int xHorse, int yHorse, int xf, int yf)
        {
            if (((xHorse - 1 == xf) && (yHorse - 2 == yf)) || ((xHorse - 1 == xf) && (yHorse + 2 == yf)) || ((xHorse + 1 == xf) && (yHorse - 2 == yf)) || ((xHorse + 1 == xf) && (yHorse + 2 == yf)) || ((xHorse - 2 == xf) && (yHorse - 1 == yf)) || ((xHorse - 2 == xf) && (yHorse + 1 == yf)) || ((xHorse + 2 == xf) && (yHorse - 1 == yf)) || ((xHorse + 2 == xf) && (yHorse + 1 == yf))) { return "Eat"; } else { return "No eat"; }

        }
    }
    public class Date
    {

        public static string daysFromStart(DateTime d1)
        {
            DateTime d2 = new DateTime(d1.Year, 1, 1);
            int days = (d1 - d2).Days;
            return "Прошло " + days + " дней";
        }

        public static string daysToEnd(DateTime d1)
        {
            DateTime d2 = new DateTime(d1.Year, 12, 31);
            int days = (d2 - d1).Days;
            return "Осталось " + days + " дней";
        }
    }

    public class Homework
    {
        public static void Armstrong()
        {
            for (int i = 100; i < 1000; i++)
            {
                int x = i / 100;
                int y = i % 100 / 10;
                int z = i % 10;
                int q = (int)Math.Pow(x, 3) + (int)Math.Pow(y, 3) + (int)Math.Pow(z, 3);
                if (q == i) Console.WriteLine($"Число Армстронга - {q}");
            }
        }

        public static int Squares(int N, int M)
        {
            if (N == 0 || M == 0) return 0;
            if (N == M) return 1;
            int min = Math.Min(N, M);
            int max = Math.Max(N, M);
            return 1 + Squares(min, max - min);
        }

        public static double Radius(double a)
        {
            return (a / 2 * Math.Tan(30));
        }

        public static void Task2(int a, int b, int c)
        {
            if ((a < b + c) && (b < a + c) && (c < a + b)) { Console.WriteLine("Существует"); }
            else Console.WriteLine("Не существует");
        }

        public static void Task3()
        {
            Console.WriteLine("x и y");
            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());
            if (((x * x + y * y < 144) && (y - x < 0))) Console.WriteLine("Внутри");
            else if (((x * x + y * y == 144) && (y - x == 0))) Console.WriteLine("На границе");
            else Console.WriteLine("Вне");
        }

        public static void Task4()
        {
            Console.WriteLine("w - woman m - man");
            string sex = Console.ReadLine();
            switch (sex)
            {
                case "m": Console.WriteLine("Дима "+"Сережа "+"Миша"); break;
                case "w": Console.WriteLine("Маша " + "Даша " + "Вика"); break;
            }
        }
        public bool Task5(int num)
        {
            int a = num / 100; //получаем первую цифру числа
            int b = (num % 100) / 10; //получаем вторую цифру
            int c = num % 10; //третью
            if ((a == b) || (a == c) || (b == c))
                return true;
            return false;
        }
    }
}

        


