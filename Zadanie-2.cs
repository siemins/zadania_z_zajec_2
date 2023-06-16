using System;

namespace fib
{
   
    class Fib
    {

        
        public static int fib(int n)
        {
            if ((n == 1) || (n == 2))
                return 1;
            else
                return fib(n - 1) + fib(n - 2);
        }

    
        [STAThread]
        static void Main(string[] args)
        {
            String line;
            int n;

            Console.WriteLine("Podaj, ktory wyraz ciagu Fibonacciego obliczyc");
            line = Console.ReadLine();
            n = int.Parse(line);

            Console.WriteLine(n + "-ty wyraz ciagu Fibonacciego: " + fib(n));
        }
    }
}

