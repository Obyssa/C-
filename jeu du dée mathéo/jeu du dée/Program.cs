using System;

namespace jeu_du_dée
{
    class Program
    {
        static void Main(string[] args)
        {

            
            void manche()
            {

                Console.WriteLine("Veuillez entrée le nombre de joueur");//nombre de joueur
                int nbrjoueur = int.Parse(Console.ReadLine());
                string[] nomjoueur = new string[nbrjoueur];
                int score = 0;
                int[] score1 = new int[nbrjoueur];
                int[] dee = new int[nbrjoueur];
                int var = 1;
                int restart = 1;
                for (int i = 0; i < nbrjoueur; i++)
                {

                    Console.WriteLine("Rentrez nom joueur " + var);
                    nomjoueur[i] = Console.ReadLine();
                    var = var + 1;
                }
                while (restart == 1)
                {

                
                    
                    for (int i = 0; i < nbrjoueur; i++)//dée aléatoire
                    {
                        Random aleatoire = new Random();
                        int dice = aleatoire.Next(1, 7);
                        dee[i] = dice;


                    }

                    int plusgrand = 0;//trouvée le plus grand
                    for (int i = 0; i < dee.Length; i++)
                    {
                        if (plusgrand < dee[i])
                        {
                            plusgrand = dee[i];

                        }

                    }
                    int conteur = 0;//combien de fois le plus grand nombre revient
                    for (int i = 0; i < dee.Length; i++)
                    {
                        if (plusgrand == dee[i])
                        {
                            conteur = conteur + 1;
                        }
                    }

                    for (int i = 0; i < dee.Length; i++)
                    {
                        if ((conteur == 2) && (dee[i] == plusgrand))
                        {
                            score1[i] = score1[i] + 1;
                        }
                        else if ((conteur == 1) && (dee[i] == plusgrand))
                        {
                            score1[i] = score1[i] + 2;
                        }


                    }


                    Console.Clear();

                    for (int i = 0; i < nomjoueur.Length; i++)//affichage
                    {
                        Console.WriteLine("- " + nomjoueur[i] + ": " + score1[i] + " Point");
                        
                    }
                    Console.WriteLine("1 pour redémarer");
                    Console.WriteLine("3 pour arréter");
                    restart = int.Parse(Console.ReadLine());
                    
                }
            }
            manche();
            

        }
       
}
}
