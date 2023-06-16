using System;

class Program
{
    static void Main()
    {
        double x = 2; 
        int n = 15; 

        double result = ExponentialApproximation(x, n);
        Console.WriteLine($"Szacowana wartość e^{x} = {result}");
    }

    static double ExponentialApproximation(double x, int n)
    {
        double sum = 1; 
        double term = 1;

        for (int i = 1; i <= n; i++)
        {
            term *= x / i; 
            sum += term; 
        }

        return sum;
    }
}

