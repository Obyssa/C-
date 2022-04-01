using System;

namespace exTAB_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[10];
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("veuillez entrez la valeur " + i);
                string string1 = Console.ReadLine();
                int int1 = int.Parse(string1);
                tab[i] = int1;
            }
            int moyenne = 0;
            for(int i = 0; i < tab.Length; i++)
            {
                moyenne = moyenne + tab[i];
            }
            moyenne = moyenne / tab.Length;
            for(int i = 0; i < tab.Length; i++)
            {
                if(moyenne < tab[i])
                {
                  Console.WriteLine("les valeurs en dessu de la moyenne sont");
                  Console.WriteLine(tab[i]);
                }
            }
        }
    }
    
}
