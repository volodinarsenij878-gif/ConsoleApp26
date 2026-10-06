using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Раскомментируй нужную строку, чтобы запустить только один блок
            Block3_ConstantsAndFormulas();

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        static void Block3_ConstantsAndFormulas()
        {
            Console.WriteLine("=== БЛОК 3: Константы и формулы ===\n");

            const double g = 9.80665;
            double mass, height;

            // Ввод массы с повторной попыткой
            while (true)
            {
                Console.Write("Масса тела (кг): ");
                string  input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input) &&
                    double.TryParse(input.Trim(), out mass) &&
                    mass >= 0)
                {
                    break;
                }

                Console.WriteLine("Ошибка: введите неотрицательное число (например, 10.5).");
            }

            // Ввод высоты с повторной попыткой
            while (true)
            {
                Console.Write("Высота (м): ");
                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input) &&
                    double.TryParse(input.Trim(), out height) &&
                    height >= 0)
                {
                    break;
                }

                Console.WriteLine("Ошибка: введите неотрицательное число (например, 5.2).");
            }

            double potentialEnergy = mass * g * height;
            Console.WriteLine($"\nПотенциальная энергия: {potentialEnergy:F2} Дж");
        }
    }
}





