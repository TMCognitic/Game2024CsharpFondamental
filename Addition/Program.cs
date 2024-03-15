using System.Text.RegularExpressions;

namespace Addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^\d+$"; // ^ début de chaine, \d+ au moins 1 chiffre, $ fin de chaine

            string valeur1, valeur2;

            do
            {
                Console.Write("Entrez un premier nombre : ");
                valeur1 = Console.ReadLine()!;
            } while(!Regex.IsMatch(valeur1, pattern));

            do
            {
                Console.Write("Entrez un second nombre : ");
                valeur2 = Console.ReadLine()!;
            } while (!Regex.IsMatch(valeur2, pattern));

            Stack<int> nombre1 = new Stack<int>();
            foreach (char c in valeur1)
            {
                nombre1.Push(c - 48);
            }

            Stack<int> nombre2 = new Stack<int>();
            foreach (char c in valeur2)
            {
                nombre2.Push(c - 48);
            }

            string result = "";
            int report = 0;

            while (nombre1.Count > 0 || nombre2.Count > 0)
            {
                int chiffre1 = nombre1.Count > 0 ? nombre1.Pop() : 0;
                int chiffre2 = nombre2.Count > 0 ? nombre2.Pop() : 0;

                int addition = report + chiffre1 + chiffre2;
                result = $"{addition % 10}{result}";
                report = addition / 10;
            }

            if(report > 0)
            {
                result = $"{report}{result}";
            }

            Console.WriteLine(result);
        }
    }
}
