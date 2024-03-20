namespace StructurePersonne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne[] personnes = new Personne[5];

            //foreach (Personne personne in personnes) {
            //    // On ne peut pas modifier les membres d'une structure dans une boucle foreach
            //    // Car la variable d'itération d'une boucle foreach contient une copie de valeur de la dite structure
            //    personne.Salaire = 2000; 
            //}

            for (int i = 0; i < personnes.Length; i++)
            {
                personnes[i].Salaire = 2000;
            }

            foreach (Personne personne in personnes)
            {
                Console.WriteLine(personne.Salaire);
            }
        }
    }

    struct Personne
    {
        public int Salaire;
    }
}
