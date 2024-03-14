namespace XFirstPrimes
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
            for (int i = 0, nombre = 2; i < count; nombre++)
            {
                bool isPrime = true;
                int racine = (int)Math.Sqrt(nombre);

                for (int diviseur = 2; diviseur <= racine && isPrime; diviseur++, loopCount++)
                {
                    if (nombre % diviseur == 0)
                        isPrime = false;
                }

                if (isPrime)
                {
                    Console.WriteLine(nombre);
                    i++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"nombre de boucles : {loopCount}");
        }
    }
}
