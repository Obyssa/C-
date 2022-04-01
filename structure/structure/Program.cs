using System;
using System.Collections.Generic;

namespace structure
{
    class Program
    {
        //struct Librairie
        //{
            //public string Titre;
            //public string Auteur;
            //public double Prix;
            ///constructeur de la structure
            //public Librairie(string Titre, string Auteur, double Prix)
            //{
                //this.Titre = Titre;
                //this.Auteur = Auteur;
                //this.Prix = Prix;
            //}
        //}
        //static void Main(string[] args)
        //{
            ///création des trois structures éléves
            //Librairie livre1 = new Librairie("L'Art de la guerre", "Sun Tzu", 5.90 );
            //Librairie livre2 = new Librairie("L'attaque des titant", "Hajime Isayama" , 5.60 );
            //Librairie livre3 = new Librairie("No Game No Life", "Yū Kamiya", 7.99 );
            //Librairie livre4 = new Librairie("Erase", "Kei Sanbe", 7.66 );
            //Librairie livre5 = new Librairie("Bleach", "Tite Kubo", 6.90 );
            ///création d'une liste
            //List<Librairie> uneListe = new List<Librairie>();
            ///modifie la classe de l'éléve Forest Gump
            //unEleve3.classe = "103";
            ///ajout des eleves à la liste
            //uneListe.Add(livre1);
            //uneListe.Add(livre2);
            //uneListe.Add(livre3);
            //uneListe.Add(livre4);
            //uneListe.Add(livre5);
            ///parcours de la liste
            
            //foreach (Librairie item in uneListe)
            //{
                
                //Console.WriteLine(item.Titre + " " + item.Auteur + " " + item.Prix);
            //}
            //Console.Read();
        //}

        
        struct Magasin
        {

            public int Référence;
            public string Nom;
            public int Prix;
            public int Quantité;

            public Magasin(int Référence, string Nom, int Prix, int Quantité)
            {

                this.Référence = Référence;
                this.Nom = Nom;
                this.Prix = Prix;
                this.Quantité = Quantité;


            }

            static void Main(string[] args)
            {
                string val = "start";

                List<Magasin> uneListe = new List<Magasin>();
                
                while(val == "start")
                {
                    Console.WriteLine("Saisir la Référence");
                    int Référence = int.Parse(Console.ReadLine());
                    Console.WriteLine("Saisir le Nom");
                    string Nom = Console.ReadLine();
                    Console.WriteLine("Saisir le Prix");
                    int Prix = int.Parse(Console.ReadLine());
                    Console.WriteLine("Saisir la Quantité");
                    int Quantité = int.Parse(Console.ReadLine());

                    Magasin Article = new Magasin(Référence, Nom, Prix, Quantité-1); 

                    uneListe.Add(Article);

                    Console.WriteLine("Veuillez écrire start pour continué ou stop pour arréter");

                    val = Console.ReadLine();

                }

               

                foreach(Magasin item in uneListe)
                {

                    Console.WriteLine(item.Référence + " " + item.Nom + " " + item.Prix + " " + item.Quantité);

                    if (item.Quantité<4)
                    {

                        Console.WriteLine("Attention stock faible!!!!!!!!!!!!");


                    }

                }



            }



        }


    } 
}

