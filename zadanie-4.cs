using System;



class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź kwotę początkową:");
        double kwota = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Wprowadź oprocentowanie konta w skali roku:");
        double oprocentowanie = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Wprowadź liczbę miesięcy oszczędzania:");
        int liczbaMiesiecy = Convert.ToInt32(Console.ReadLine());

        double odsetki = ObliczOdsetki(kwota, oprocentowanie, liczbaMiesiecy);
        double kwotaKoncowa = kwota + odsetki;

        Console.WriteLine("Kwota zarobiona (uwzględniając podatek Belki): {0}", kwotaKoncowa);
        Console.ReadLine();
    }

    static double ObliczOdsetki(double kwota, double oprocentowanie, int liczbaMiesiecy)
    {
        double oprocentowanieMiesieczne = oprocentowanie / 12 / 100;
        double kwotaZOdsetkami = kwota * Math.Pow(1 + oprocentowanieMiesieczne, liczbaMiesiecy);
        double podatekBelki = kwotaZOdsetkami * 0.23; 

        return kwotaZOdsetkami - podatekBelki;
    }
}

