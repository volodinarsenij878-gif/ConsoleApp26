using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Номер дня недели (1–7): ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input) ||
                !int.TryParse(input.Trim(), out int dayNum) ||
                dayNum < 1 || dayNum > 7)
            {
                Console.WriteLine("Ошибка: введено некорректное значение. Ожидалось число от 1 до 7.");
                return;
            }

            string dayName;
            if (dayNum == 1) dayName = "Понедельник";
            else if (dayNum == 2) dayName = "Вторник";
            else if (dayNum == 3) dayName = "Среда";
            else if (dayNum == 4) dayName = "Четверг";
            else if (dayNum == 5) dayName = "Пятница";
            else if (dayNum == 6) dayName = "Суббота";
            else if (dayNum == 7) dayName = "Воскресенье";
            else dayName = "Некорректный номер";

            Console.WriteLine($"День недели: {dayName}");
        }
    }
}

