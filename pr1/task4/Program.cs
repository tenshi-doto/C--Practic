using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        int[] X = new int[13]; 
        Random rand = new Random();

        for (int i = 0; i < X.Length; i++) {
            X[i] = rand.Next(-50, 51);
        }

        Console.WriteLine("Масив X:");
        foreach (int num in X)
            Console.Write(num + " ");

        Console.WriteLine("\n\nВведіть число M:");
        int M = int.Parse(Console.ReadLine());

        List<int> Y = new List<int>();

        for (int i = 0; i < X.Length; i++) {
            if (Math.Abs(X[i]) > M) {
                Y.Add(X[i]);
            }
        }

        Console.WriteLine("\nЧисло M: " + M);

        Console.WriteLine("Масив Y (елементи з X, що більше по модулю за M):");
        if (Y.Count > 0) {
            foreach (int num in Y)
                Console.Write(num + " ");
        } else {
            Console.WriteLine("Немає елементів, які задовольняють умову.");
        }
    }
}
