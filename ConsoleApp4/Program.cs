

class Program
{
    static void Main()
    {
        // Запитуємо користувача ввести символ
        Console.WriteLine("Введіть один символ:");
        char input = char.Parse(Console.ReadLine().ToUpper()); // Перетворюємо на верхній регістр для зручності

        // Перевіряємо, чи символ є літерою
        if (!char.IsLetter(input))
        {
            Console.WriteLine("Введений символ не є літерою.");
        }
        else if (IsVowel(input))
        {
            Console.WriteLine($"{input} є голосною.");
        }
        else
        {
            Console.WriteLine($"{input} є приголосною.");
        }
    }

    // Метод для перевірки, чи є символ голосною
    static bool IsVowel(char ch)
    {
        // Масив голосних літер
        char[] vowels = { 'A', 'E', 'I', 'O', 'U' };

        // Перевірка, чи входить символ до масиву голосних
        return Array.Exists(vowels, vowel => vowel == ch);
    }
}
