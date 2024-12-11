using System;

class Program {
    static void Main() {
        int[] X = new int[13];

        Random rand = new Random();
        for (int i = 0; i < X.Length; i++) {
            X[i] = rand.Next(1, 100);
        }

        Console.WriteLine("Масив:");
        foreach (int num in X)
            Console.Write(num + " ");
        
        int min = X[0];
        int max = X[0];

        for (int i = 1; i < X.Length; i++) {
            if (X[i] < min) min = X[i];
            if (X[i] > max) max = X[i];
        }

        Console.WriteLine("\nМінімальне значення: " + min);
        Console.WriteLine("Максимальне значення: " + max);
    }
}
