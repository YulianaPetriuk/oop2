class Program
{
    static void Main()
    {
        Console.Write("Введіть число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("Число додатнє.");
        }
        else if (number < 0)
        {
            Console.WriteLine("Число від'ємне.");
        }
        else
        {
            Console.WriteLine("Число дорівнює нулю.");
        }
    }
}