using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть перше число:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть друге число:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть третє число:");
        int num3 = int.Parse(Console.ReadLine());

        int lastDigit = 3 % 10;

        // Визначаємо межі інтервалу
        int lowerBound = 1;
        int upperBound = 10 + lastDigit;

        // Перевірка чисел на належність інтервалу
        Console.WriteLine("Числа, які належать інтервалу [{0}, {1}]:", lowerBound, upperBound);

        if (IsInInterval(num1, lowerBound, upperBound))
        {
            Console.WriteLine(num1);
        }

        if (IsInInterval(num2, lowerBound, upperBound))
        {
            Console.WriteLine(num2);
        }

        if (IsInInterval(num3, lowerBound, upperBound))
        {
            Console.WriteLine(num3);
        }
    }

    static bool IsInInterval(int number, int lowerBound, int upperBound)
    {
        return number >= lowerBound && number <= upperBound;
    }
}