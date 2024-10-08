using System;

class Program
{
    static void Main()
    {
        // Запитуємо у користувача вік
        Console.WriteLine("Введіть ваш вік:");
        int age = Convert.ToInt32(Console.ReadLine());

        // Перевіряємо, чи є вік підлітковим (від 12 до 18 років)
        if (age >= 12 && age <= 18)
        {
            Console.WriteLine("Ваш вік підлітковий.");
        }
        else
        {
            Console.WriteLine("Ваш вік не підлітковий.");
        }
    }
}
