using System;

namespace Exercice_tableau_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nombre = new int[4];
            int test = 100;
            Console.WriteLine("veuillez entrer 4 valeurs");
            int a = 1;
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("valeur "+ a);
                nombre[i] = int.Parse(Console.ReadLine());
                a++;
            }

            for (int i = 0; i < nombre.Length; i++)
            {
                if (nombre[i] < test)
                {
                    test=nombre[i];
                }
                
            }
            Console.WriteLine(test);
        }
    }
}
