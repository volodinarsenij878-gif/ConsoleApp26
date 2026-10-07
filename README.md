using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program26
{
    internal class Program
    {
        static void Main()
        {
            // 1. Объявляем константу гравитационного ускорения (g ≈ 9.81 м/с²)
            const double Gravity = 9.81;

            Console.WriteLine($"Константа g = {Gravity} м/с² (используется в дальнейших расчётах при необходимости).\n");

            // 2. Запрашиваем катеты прямоугольного треугольника
            double a, b;

            Console.Write("Введите длину первого катета (a): ");
            while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.Write("Ошибка: введите положительное число для катета a: ");
            }

            Console.Write("Введите длину второго катета (b): ");
            while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.Write("Ошибка: введите положительное число для катета b: ");
            }

            // 3. Вычисляем гипотенузу по теореме Пифагора: c = √(a² + b²)
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            // 4. Вычисляем радиус вписанной окружности для прямоугольного треугольника: r = (a + b - c) / 2
            double r = (a + b - c) / 2;

            // Вывод результатов
            Console.WriteLine("\n--- Результаты ---");
            Console.WriteLine($"Катет a: {a}");
            Console.WriteLine($"Катет b: {b}");
            Console.WriteLine($"Гипотенуза c: {c:F2}");
            Console.WriteLine($"Радиус вписанной окружности r: {r:F2}");
        }
    }
}
