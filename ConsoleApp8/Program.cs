
class Program
{
    static void Main()
    {
        // Запитуємо у користувача довжини трьох сторін трикутника
        Console.WriteLine("Введіть довжину першої сторони (a):");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть довжину другої сторони (b):");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть довжину третьої сторони (c):");
        double c = Convert.ToDouble(Console.ReadLine());

        // Визначаємо найдовшу сторону
        double longest = a;
        string longestSide = "a";

        if (b > longest)
        {
            longest = b;
            longestSide = "b";
        }

        if (c > longest)
        {
            longest = c;
            longestSide = "c";
        }

        // Виводимо результат
        Console.WriteLine($"Найдовша сторона: {longestSide}, її довжина: {longest}");
    }
}
