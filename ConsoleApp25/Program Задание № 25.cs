using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program25
{
    internal class Program
    {
        static void Main(string[] args)
        {
                const decimal baseRate = 0.05m; // 5% годовых

                Console.Write("Сумма вклада: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal principal) || principal < 0)
                {
                    Console.WriteLine("Ошибка: введите корректную неотрицательную сумму.");
                    return;
                }

                Console.Write("Срок в месяцах: ");
                if (!int.TryParse(Console.ReadLine(), out int months) || months < 0)
                {
                    Console.WriteLine("Ошибка: введите корректный неотрицательный срок в месяцах.");
                    return;
                }

                decimal interest = principal * baseRate * (decimal)months / 12m;
                Console.WriteLine($"Простые проценты: {interest:C2}");

                // Можно дополнительно вывести итоговую сумму
                Console.WriteLine($"Итоговая сумма (вклад + проценты): {(principal + interest):C2}");
            }
        }
    }

