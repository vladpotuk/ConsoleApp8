using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть число: ");
        double number = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть відсоток: ");
        double percent = Convert.ToDouble(Console.ReadLine());

        double result = (percent / 100) * number;

        Console.WriteLine($"Результат: {percent}% від {number} = {result}");
    }
}

