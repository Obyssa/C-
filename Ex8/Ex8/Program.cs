using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez me donnez l'heure");
            string stringHeure = Console.ReadLine();
            Console.WriteLine("Veuillez me donnez la minute");
            string stringMinute = Console.ReadLine();

            int heure = int.Parse(stringHeure);
            int minute = int.Parse(stringMinute);
            int resultat = minute + 1;

            Console.WriteLine("h" + heure.ToString() + " " + "m" + resultat.ToString());
            Console.WriteLine(resultat);



        }
    }
}
