namespace Tri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taille;

            do 
            {
                Console.Write("Veuillez entrer le nombre d'éléments à générer : "); 
            } while (!int.TryParse(Console.ReadLine()!, out taille) || taille < 10);

            int[] values = new int[taille];

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = Random.Shared.Next(100) + 1 ;
            }

            Console.WriteLine(string.Join(", ", values));

            for (int i = 0; i < values.Length - 1; i++) 
            {
                for (int j = i + 1; j < values.Length; j++)
                {
                    if (values[j] < values[i])
                    {
                        int temp = values[i];
                        values[i] = values[j];
                        values[j] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", values));
        }
    }
}
