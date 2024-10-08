

class Program
{
    static void Main()
    {
        // Запитуємо користувача ввести річний дохід
        Console.WriteLine("Введіть свій річний дохід:");
        decimal income = decimal.Parse(Console.ReadLine());

        // Обчислюємо податок на дохід
        decimal tax = CalculateTax(income);

        // Виводимо результат
        Console.WriteLine($"Ваш податок на дохід: {tax:C}");
    }

    // Метод для обчислення податку на дохід залежно від доходу
    static decimal CalculateTax(decimal income)
    {
        decimal tax = 0;

        // Податкові ставки
        if (income <= 50000)
        {
            tax = income * 0.05m; // 5% для доходу до 50,000
        }
        else if (income <= 100000)
        {
            tax = 50000 * 0.05m + (income - 50000) * 0.10m; // 10% для доходу від 50,001 до 100,000
        }
        else if (income <= 200000)
        {
            tax = 50000 * 0.05m + 50000 * 0.10m + (income - 100000) * 0.15m; // 15% для доходу від 100,001 до 200,000
        }
        else
        {
            tax = 50000 * 0.05m + 50000 * 0.10m + 100000 * 0.15m + (income - 200000) * 0.20m; // 20% для доходу понад 200,000
        }

        return tax;
    }
}
