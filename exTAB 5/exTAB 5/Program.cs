using System;

namespace exTAB_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[100];
            
            for (int i = 0; i < tab.Length; i++)
            {
                Random aleatoire = new Random();
                int entierUnChiffre = aleatoire.Next(10);
                tab[i] = entierUnChiffre;
            }
            Console.WriteLine("saisisser la valeur max svp");
            string string1 = Console.ReadLine();
            int int1 = int.Parse(string1);
            for (int i = 0; i< tab.Length; i++)
            {
                if (tab[i] > int1)
                {
                    tab[i] = 0;
                }
                Console.WriteLine(tab[i]);
            }
        }
    }
}
