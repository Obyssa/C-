using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ecri le nombre 1");

            string a;

            a = Console.ReadLine();

            int nombre1 = int.Parse(a);

            Console.WriteLine("Ecri le nombre 2");

            string b;

            b = Console.ReadLine();

            int nombre2 = int.Parse(b);

            Console.WriteLine("Ecri le nombre 3");

            string c;

            c = Console.ReadLine();

            int nombre3 = int.Parse(c);

            if (nombre1 > nombre2 && nombre2 > nombre3)
            {
                Console.WriteLine("La suite est decroissante");
            }
            else
            {
                Console.WriteLine("Croissant");
            }
            
        }
    }
}
