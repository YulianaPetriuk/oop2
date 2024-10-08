using System;

class Program
{
    static void Main()
    {
        // Запитуємо у користувача три числа
        Console.WriteLine("Введіть перше число:");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть друге число:");
        double number2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть третє число:");
        double number3 = Convert.ToDouble(Console.ReadLine());

        // Визначаємо найбільше число
        double largest = number1;

        if (number2 > largest)
        {
            largest = number2;
        }

        if (number3 > largest)
        {
            largest = number3;
        }

        // Виводимо результат
        Console.WriteLine($"Найбільше число: {largest}");
    }
}
