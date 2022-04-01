using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ecri un nobre toutou");

            string nombre = Console.ReadLine();

            int resultat = int.Parse(nombre);

            if (resultat == 0) {

                Console.WriteLine("votre chiffre est pas ouf");
            }
            else if (resultat > 0)
            {

                Console.WriteLine("Votre chiffre est positif");
            }
            else if (resultat < -0)
            {

                Console.WriteLine("Votre chiffre est negatif");

            }
        }
    }
}
