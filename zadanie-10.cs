using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę naturalną:");
        int liczba = int.Parse(Console.ReadLine());

        if (liczba < 100)
        {
            Console.WriteLine("Podana liczba ma mniej niż 3 cyfry.");
        }
        else
        {
            Console.WriteLine("Cyfry liczby:");
            WypiszCyfry(liczba);
        }

        Console.ReadLine();
    }

    static void WypiszCyfry(int liczba)
    {
        string liczbaString = liczba.ToString();

        foreach (char cyfra in liczbaString)
        {
            Console.WriteLine(cyfra);
        }
    }
}

