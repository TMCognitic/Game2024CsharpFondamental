namespace SquareNewtonMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal tauxErreur = 0M;
            decimal nombre = 400;

            decimal racinePrecedente = nombre;
            decimal racine = nombre;
            decimal erreur = nombre;

            while (erreur > tauxErreur)
            {
                racine = (racine + (nombre / racine)) / 2;
                erreur = (racinePrecedente - racine) / racinePrecedente;
                racinePrecedente = racine;

                Console.WriteLine($"erreur={erreur} Racine={racine}");
            }

            Console.WriteLine($"la racine carrée de {nombre} est : {racine}");
        }
    }
}
