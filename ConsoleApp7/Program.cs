using System;

class Program
{
    static void Main()
    {
        // Запитуємо у користувача число
        Console.WriteLine("Введіть число:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Перевіряємо, чи є число парним або непарним
        if (number % 2 == 0)
        {
            Console.WriteLine("Число парне.");
        }
        else
        {
            Console.WriteLine("Число непарне.");
        }

        // Перевіряємо, чи ділиться число на 3
        if (number % 3 == 0)
        {
            Console.WriteLine("Число ділиться на 3.");
        }
        else
        {
            Console.WriteLine("Число не ділиться на 3.");
        }
    }
}
