using System;

class Program
{
    static void Main(string[] args)
    {
        int min = 1;
        int max = 20;

        Console.WriteLine("Wybierz liczbę z przedziału od 1 do 20, a ja ją zgadnę!");

        int guess;
        do
        {
            guess = (min + max) / 2; 

            Console.WriteLine($"Czy twoja liczba to {guess}? (Wpisz: -1 jeśli liczba jest mniejsza, 1 jeśli liczba jest większa, 0 jeśli zgadłem)");

            int response = Convert.ToInt32(Console.ReadLine());

            if (response == -1)
            {
                max = guess - 1; 
            }
            else if (response == 1)
            {
                min = guess + 1; 
            }
            else if (response != 0)
            {
                Console.WriteLine("Nieprawidłowa odpowiedź. Wpisz: -1, 1 lub 0.");
            }

        } while (guess != 0); 

        Console.WriteLine("Hurra! Zgadłem!");
    }
}

