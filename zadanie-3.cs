using System;

static private int zad3()

{


    
    Console.WriteLine("obliczymy  m = (n! - k!) / k!    podaj n k   uwaga n i k musza byc liczbami naturalnymi nie mniejszymi niz 5!");
    int n = Convert.ToInt32(Console.ReadLine());
    int k = Convert.ToInt32(Console.ReadLine());


    while (n < 5)
    {
        Console.WriteLine("n mniejsz niz 5 ! podaj wieksza !");
        n = Convert.ToInt32(Console.ReadLine());

    }

    while (k < 5)
    {
        Console.WriteLine("n mniejsz niz 5 ! podaj wieksza !");
        n = Convert.ToInt32(Console.ReadLine());
    }

    int silniaN = 1;
    int silniaK = 1;

    for (int i = 1; i < n + 1; i++)
    {
        silniaN = silniaN * i;
    }

    for (int i = 1; i < n + 1; i++)
    {
        silniaK = silniaK * i;
    }


    int m = (silniaN - silniaK) / silniaK;

    Console.WriteLine("m = " + m);


    return m;
}


