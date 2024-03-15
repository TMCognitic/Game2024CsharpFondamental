using System.Collections;

namespace PrimesLowerThanX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxValue;
            do
            {
                Console.Write("Valeur maximale à ne pas dépasser ? : ");
            }
            while (!int.TryParse(Console.ReadLine(), out maxValue) && maxValue > 0);

            int loopCount = 0;

            ArrayList primes = new ArrayList();

            for (int nombre = 2; nombre <= maxValue; nombre++)
            {
                bool isPrime = true;
                int racine = (int)Math.Sqrt(nombre);

                for (int indice = 0; racine > 1 && isPrime && (int)primes[indice] <= racine; indice++, loopCount++)
                {
                    if (nombre % (int)primes[indice] == 0)
                        isPrime = false;
                }

                if (isPrime)
                {
                    primes.Add(nombre);
                }
            }

            foreach (object nombre in primes)
            {
                Console.WriteLine($"{nombre} is prime...");
            }

            Console.WriteLine();
            Console.WriteLine($"nombre de boucles : {loopCount}");
        }
    }
}
