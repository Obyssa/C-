using System;

namespace classe_exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Livre livre = new Livre("livre1", "jean", 12);

            Livre livre1 = new Livre("livre2", "moi", 12);

            Console.WriteLine(livre.Afficher());
            Console.WriteLine(livre1.Afficher());

        }
    }
}
