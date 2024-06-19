﻿using System;

class Program
{
    static void Main()
    {
        // Запрос номера операции
        Console.WriteLine("Введите номер операции:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");

        int operation = Convert.ToInt32(Console.ReadLine());

        // Определение операции по введенному номеру
        switch (operation)
        {
            case 1:
                Console.WriteLine("Вы выбрали операцию: Сложение");
                break;
            case 2:
                Console.WriteLine("Вы выбрали операцию: Вычитание");
                break;
            case 3:
                Console.WriteLine("Вы выбрали операцию: Умножение");
                break;
            default:
                Console.WriteLine("Операция неопределена");
                break;
        }
    }
}
