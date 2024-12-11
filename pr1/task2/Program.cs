﻿using System;

class Program {
    static void Main() {
        double a, b, c;
        
        Console.WriteLine("Введіть першу сторону трикутника:");
        while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
            Console.WriteLine("Невірний формат даних. Спробуйте ще раз:");
        
        Console.WriteLine("Введіть другу сторону трикутника:");
        while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
            Console.WriteLine("Невірний формат даних. Спробуйте ще раз:");
        
        Console.WriteLine("Введіть третю сторону трикутника:");
        while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
            Console.WriteLine("Невірний формат даних. Спробуйте ще раз:");
        
        if (IsValidTriangle(a, b, c)) {
            double perimeter = a + b + c;
            Console.WriteLine("Периметр трикутника: " + perimeter);

            double s = perimeter / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("Площа трикутника: " + area);

            Console.WriteLine("Тип трикутника: " + DetermineTriangleType(a, b, c));
        } else
            Console.WriteLine("Трикутник з такими сторонами не може існувати.");
    }

    static bool IsValidTriangle(double a, double b, double c) {
        return a + b > c && a + c > b && b + c > a;
    }

    static string DetermineTriangleType(double a, double b, double c) {
        if (a == b && b == c)
            return "Рівносторонній";
        else if (a == b || b == c || a == c)
            return "Рівнобедрений";
        else
            return "Різносторонній";
    }
}