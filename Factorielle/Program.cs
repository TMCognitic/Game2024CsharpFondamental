namespace Factorielle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre;
            do
            {
                Console.Write("Donner un entier positif > 0 : ");
            }
            while (!int.TryParse(Console.ReadLine(), out nombre) || nombre < 0);

            int result = nombre;

            while (nombre > 1)
            {
                result *= --nombre;
            }

            Console.WriteLine(result);
        }
    }
}
