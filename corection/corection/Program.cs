using System;
using System.Collections.Generic;

namespace corection
{
    class Program
    {
        static void Main(string[] args)
        {

            //ex 3


            //int[] nombre = new int[10];//création du tableau
            //for(int i = 0; i < nombre.Length; i++)//boucle pour remplire le tableau
            //{

            //    Console.WriteLine("veuillez entrer le nombre " + (i + 1));

            //    nombre[i] = int.Parse(Console.ReadLine());

            // }


            //int nombremax = 0;//création des variable pour le nombre max et le nombre min
            // int nombremini = nombre[0];


            //for(int i = 0; i<nombre.Length; i++)//boucle qui parcoure le tableau pour trouvée le nombre max et le nombre mini
            //{

            //    if (nombremax < nombre[i])//pour le nombre max
            //    {


            //        nombremax = nombre[i];


            //    }



            //   if (nombremini > nombre[i])//pour le nombre mini
            //  {


            //     nombremini = nombre[i];


            //   }




            // }


            //for (int i = 0; i<nombre.Length; i++)//boucle pour écrire le tableau
            //{


            //    Console.WriteLine(nombre[i]);


            //}


            //Console.WriteLine("voici le nombre max");//écrit le nombre max
            //Console.WriteLine(nombremax);



            //Console.WriteLine("Voici le nombre mini");//écrit le nombre mini
            //Console.WriteLine(nombremini);




            //ex 4


            List<float> taille = new List<float>();
            Console.WriteLine("veuillez rentrée les taille en m entrée 0 pour arréter");
            int taille1 = int.Parse(Console.ReadLine()); ;
            

            while (taille1 > 0)
            {
                taille.Add(taille1);
                taille1 =int .Parse(Console.ReadLine());

               

                

            }


            Console.WriteLine(taille.Count);


            List<float> masse = new List<float>();

            int masse1 = 0;

            for(int i = 0; i < taille.Count; i++)
            {
                masse1 = int.Parse(Console.WriteLine());




            }



        }
    }
}
