using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program22
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double radius;

            while (true)
            {
                Console.Write("Радиус сферы (м): ");
                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input) &&
                    double.TryParse(input.Trim(), out radius) &&
                    radius >= 0)
                {
                    break;
                }

                Console.WriteLine("Ошибка: введите неотрицательное число (например, 2.5).");
            }

            double sphereVolume = 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
            double sphereSurface = 4.0 * Math.PI * radius * radius;

            Console.WriteLine($"Объём сферы: {sphereVolume:F2} м³");
            Console.WriteLine($"Площадь поверхности: {sphereSurface:F2} м²");
        }
    }
}