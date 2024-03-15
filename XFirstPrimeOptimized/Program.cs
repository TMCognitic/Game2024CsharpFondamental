namespace XFirstPrimeOptimized
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count;
            do
            {
                Console.Write("Combien de nombre premier voulez-vous ? : ");
            }
            while (!int.TryParse(Console.ReadLine(), out count) && count > 0);

            int loopCount = 0;

            List<int> primes = new List<int>();
            for (int i = 0, nombre = 2; i < count; nombre++)
            {
                bool isPrime = true;
                int racine = (int)Math.Sqrt(nombre);

                for (int indice = 0; racine > 1 && isPrime && primes[indice] <= racine ; indice++, loopCount++)
                {
                    if (nombre % primes[indice] == 0)
                        isPrime = false;
                }

                if (isPrime)
                {
                    primes.Add(nombre);
                    i++;
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, primes));

            //foreach (int item in primes)
            //{
            //    Console.WriteLine(item);
            //}


            Console.WriteLine();
            Console.WriteLine($"nombre de boucles : {loopCount}");
        }
    }
}
