namespace LoopIncrementByZeroDotOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (float temperature = 0; temperature < 20; temperature = temperature + 0.1F)
            //{
            //    Console.WriteLine($"{temperature}");
            //}

            //for (double temperature = 0; temperature < 20; temperature = temperature + 0.1)
            //{
            //    Console.WriteLine($"{temperature}");
            //}

            for (decimal temperature = 0; temperature < 20; temperature = temperature + 0.1M)
            {
                Console.WriteLine($"{temperature}");
            }

            //for (int puissance = 1; puissance < 20; puissance++)
            //{
            //    Console.WriteLine(Math.Pow(2, -puissance));
            //}
        }
    }
}
