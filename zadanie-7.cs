using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Pary liczb, ktorych suma jest rowna {0}:", n);
        PrintNumberPairs(n);
    }

    public static void PrintNumberPairs(int n)
    {
        for (int i = 1; i <= n / 2; i++)
        {
            int j = n - i;
            Console.WriteLine("({0}, {1})", i, j);
        }
    }
}

