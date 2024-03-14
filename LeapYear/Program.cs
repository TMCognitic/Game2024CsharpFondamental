using System.Text.RegularExpressions;

namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Exercice année bisextile --");
            Console.Write("Veuillez entrer une année : ");  
            
            string input = Console.ReadLine()!;

            // @"^[1-9]\d{3}$" : la chaine de caractère doit commencer par un chiffre compris entre 1 et 9 et être suivi de 3 chiffres
            if (!Regex.IsMatch(input, @"^[1-9]\d{3}$")) 
            { 
                Console.WriteLine("Format de l'année invalide!");
                return;
            }

            int annee = int.Parse(input);

            bool isLeapYear = annee % 4 == 0 && annee % 100 != 0 || annee % 400 == 0;
            Console.WriteLine($"{annee} {(isLeapYear ? "est" : "n'est pas")} une année bisextile");
        }
    }
}
