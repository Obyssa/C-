using System;

namespace UtiliserDebug
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Rappel Debug : 
            F11 mode Pas A Pas
            F5 passer d'une point d'arrét à un autre ou poursuivre le programme
            Shift + F11 passer à la fonction suivante

            */
            int johan, ghislain, solene, enzo, quentin, theo, alexy, boris, maxence, hugo, thibault, matheo, noe, louis, remi, mathias, abel, mylan, zoe, logan, esteban;


            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < 20; j++)
                {
                    Random random = new Random();
                    int alea = random.Next(1, 200);
                    Console.Write(alea);
                }

            }
            johan = 4 * 456 * 78;
            ghislain = 2 * 4 * 87;
            solene = 7 * 8 * 6;
            enzo = 2 * 3 * 4 * 43 * 45;
            quentin = 2 * 116 * 44 * 4 * 45;
            theo = 2 * 9 * 43 * 45 * 45;
            alexy = 6 * 3 * 13 * 45 * 45;
            boris = 2 * 8 * 4 * 45 * 45;
            maxence = 11 * 3 * 4 * 45 * 45;
            hugo = 2 * 3 * 44 * 45 * 45;
            thibault = 33 * 3 * 4 * 45 * 45;
            matheo = 62 * 38 * 4 * 45 * 45;
             noe = 2 * 3 * 4 * 45 * 45;
            louis = 2 * 14 * 45 * 45 * 45;
            remi = 2 * 45 * 21 * 45 * 45;
            mathias = 2 * 3 * 46 * 45 * 45;
            abel = 6 * 43 * 3 * 45 * 45;
            mylan = 2 * 3 * 36 * 45 * 45;
            zoe = 2 * 3 * 4 * 45 * 45;
            logan = 12 * 3 * 4 * 45 * 45;
            esteban = 2 * 63 * 44 * 45 * 45;

            //Donnez le contenu de votre variable sans ecrire une seule ligne de code ( utiliser le débug) résultat = 19083600

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < 20; j++)
                {
                    Random random = new Random();
                    int alea = random.Next(1, 200);
                    Console.Write(alea);
                }

            }


            int total = johan + ghislain + solene + enzo + quentin + theo + abel + alexy + boris + remi + mathias;
            // donnez le contenu de la variable total MOINS la valeur de votre variable  Modulo 22
            // exemple (total - maVariable % 22) = -6
            

            int variableFin = 0;
        }
    }
}
