using System;

namespace exercice_tableau
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] notes = new int[5];
            Console.WriteLine("veuillez saisir les note");
            int a = 1;
            for (int i = 0; i < notes.Length; i++)
            {
                Console.WriteLine("Veuillez rentrer la note "+ a);
                notes[i] = int.Parse(Console.ReadLine());
                a = a + 1;
                
            }
            Console.WriteLine("les notes superrieur a 10 sont");
            for (int i = 0; i < notes.Length; i++)
            {
                
                if (notes[i] >= 10)
                {
                    
                    Console.WriteLine(notes[i]);
                }
                
            }
        }
    }
}
