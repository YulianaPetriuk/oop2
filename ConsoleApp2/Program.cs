

class Program
{
    static void Main()
    {
        // Запитуємо користувача ввести рік
        Console.WriteLine("Введіть рік:");
        int year = int.Parse(Console.ReadLine());

        // Перевіряємо, чи є рік високосним
        if (IsLeapYear(year))
        {
            Console.WriteLine($"{year} є високосним роком.");
        }
        else
        {
            Console.WriteLine($"{year} не є високосним роком.");
        }
    }

    // Метод для перевірки, чи є рік високосним
    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
