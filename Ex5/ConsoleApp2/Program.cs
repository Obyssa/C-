using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tapez un nombre");

            string Carree = Console.ReadLine();

            int convertCarre = int.Parse(Carree);

            Console.WriteLine("Le resultat est");

            Console.WriteLine(convertCarre * convertCarre);
        }
    }
}
