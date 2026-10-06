using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program24
{
    internal class Program
    {
        private static void Main(string[] args)
        {
                if (args is null)
                {
                    throw new ArgumentNullException(nameof(args));
                }
                // Расстояние между точками
                Console.Write("x1: ");
                double x1 = double.Parse(Console.ReadLine());

                Console.Write("y1: ");
                double y1 = double.Parse(Console.ReadLine());

                Console.Write("x2: ");
                double x2 = double.Parse(Console.ReadLine());

                Console.Write("y2: ");
                double y2 = double.Parse(Console.ReadLine());

                // Вычисление расстояния с исправлением опечаток (Math вместо Nath)
                double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

                // Вывод результата (убран лишний пробел перед F2)
                Console.WriteLine($"Расстояние: {distance:F2}");
            }
        }
    }
