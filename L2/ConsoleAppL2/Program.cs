using System;
using ClassLibraryL2;
namespace ConsoleAppL2
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex t1 = new Complex(1, 1);
            Complex t2 = new Complex(2, 3), t3;
            t3 = Complex.sum(t1, t2);
            Console.WriteLine("Комплексные числа:");
            Console.WriteLine(Complex.ToString(t1));
            Console.WriteLine(Complex.ToString(t2));
            Console.WriteLine(Complex.ToString(t3));
            Console.WriteLine("Работа с шахматной доской:");
            Desk desk1 = new Desk(4, 3, 2, 4, 3, 4);
            Console.WriteLine("Размер доски:");
            Console.WriteLine(Desk.Count(desk1));
            Console.WriteLine("Цвет клекти:");
            Console.WriteLine(Desk.Color(desk1));
            Console.WriteLine("Одинаковый цвет клеток, на которых стоят фигуры:");
            Console.WriteLine(Desk.SameSquare(desk1));
            Console.WriteLine("Бьет ли фигура другую фигуру?");
            Desk.Eating(desk1);
            // Задание с датой
            Console.WriteLine("Работа с датой:");
            DateTime d1 = new DateTime(2020, 02, 29);


            DateTime nowDate = DateTime.Now;
            string passedDays = Date.daysFromStart(d1);
            Console.WriteLine(passedDays);

            string remainDays = Date.daysToEnd(d1);
            Console.WriteLine(remainDays);

            Console.WriteLine("Вчера - {0}.{1}.{2}", (d1.AddDays(-1)).Year, (d1.AddDays(-1)).Month, (d1.AddDays(-1)).Day);
            Console.WriteLine("Завтра - {0}.{1}.{2}", (d1.AddDays(1)).Year, (d1.AddDays(1)).Month, (d1.AddDays(1)).Day);

            Console.WriteLine();
            // Числа Армстронга
            Homework.Armstrong();
            

            // Кол-во квадратов
            Console.WriteLine("Стороны прямоугольника");
            int firstSide = Int32.Parse(Console.ReadLine());
            int secondSide = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Кол-во квадратов = {Homework.Squares(firstSide, secondSide)}");
            Console.WriteLine($"Кол-во маленьких квадратов = {firstSide * secondSide}");

            //-----------------------------Самостоятельная работа--------------------------------------------------------
            // Радиус вписанной окружности
            Console.WriteLine("Радиус вписанной окружности");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine($"Радиус = {Homework.Radius(firstNum)}");

            // Cуществование треугольника
            Console.WriteLine("Треугольник?");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            Homework.Task2(a, b, c);

            // Проверка условий
            Homework.Task3();

            // Мужчины и женщины
            Homework.Task4();

            // Задача 3 циклами
            Homework chk = new Homework();
            for (int i = 100; i < 1000; i++)
                if (chk.Task5(i))
                    Console.Write(i + " ");
            Console.WriteLine();

            int ii = 100;
            Homework chkk = new Homework();
            while (ii < 1000)
            {
                if (chkk.Task5(ii))
                    Console.Write(ii + " ");
                ii++;
            }
            Console.WriteLine();
            int iii = 100;
            Homework chkkk = new Homework();
            do
            {
                if (chkk.Task5(iii))
                    Console.Write(iii + " ");
                iii++;
            } while (iii < 1000);

            // Пирамида чисел
            int k = 8;
            int l = 1;
            int q = 1;
            {
                for (q = 1; q <= 8; ++q, Console.WriteLine())
                {
                    if (q % 2 != 0)
                    {
                        for (int jj = 1; jj <= l; ++jj)
                        {
                            Console.Write($" {k}");

                        }
                        k--;


                    }
                    else
                    {
                        for (int jj = 1; jj <= l; ++jj)
                        {
                            Console.Write($" {k}");

                        }
                        l++;
                    }
                }

            }

        }

     


    
    }
}
