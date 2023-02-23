using System;

namespace MultiplicativePersistence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            long n = long.Parse(Console.ReadLine());

            int persistence = PersistenceSolution(n);

            Console.WriteLine("Multiplicative persistence of {0}: {1}", n, persistence);
            Console.ReadKey();
        }

        public static int PersistenceSolution(long n)
        {
            if (n < 10)
            {
                return 0;
            }
            long product = 1;
            while (n > 0)
            {
                product *= n % 10;
                n /= 10;
            }
            return 1 + PersistenceSolution(product);
        }
    }
}
