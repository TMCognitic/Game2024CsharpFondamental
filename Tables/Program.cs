namespace Tables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int maxFacteur = 20, maxTable = 5;

            for (int facteur = 1; facteur < maxFacteur + 1; facteur++)
            {
                for (int table = 1; table < maxTable + 1; table++)
                {
                    Console.Write($"{table:D2} * {facteur:D2} = {table * facteur:D2}   ");
                }
                Console.WriteLine();
            }

            
        }
    }
}
