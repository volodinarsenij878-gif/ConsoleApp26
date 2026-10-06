using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Program26

{
    class Program
    {
        static void Main()
        {
            double a, b;

            // Ввод катета a (с защитой от ошибок)
            while (true)
            {
                Console.Write("Катет a: ");
                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input) &&
                    double.TryParse(input.Trim(), out a) &&
                    a > 0)
                {
                    break; // корректный ввод — выходим из цикла
                }

                Console.WriteLine("Ошибка: введите положительное число для катета a.");
            }

            // Ввод катета b (с защитой от ошибок)
            while (true)
            {
                Console.Write("Катет b: ");
                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input) &&
                    double.TryParse(input.Trim(), out b) &&
                    b > 0)
                {
                    break; // корректный ввод — выходим из цикла
                }

                Console.WriteLine("Ошибка: введите положительное число для катета b.");
            }

            // Расчёты
            double c = Math.Sqrt(a * a + b * b);
            double rInscribed = (a + b - c) / 2.0;

            Console.WriteLine($"Гипотенуза: {c:F2}, радиус вписанной окружности: {rInscribed:F2}");
        }
    }
}