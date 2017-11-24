using System;

namespace projetConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = new int[10];
            Random Aleatoire = new Random();

            int[] valeurs = new int[10];
            int[] frequence = new int[10];

            bool trouve = false;
            int position = 0;

            for (int i = 0; i < 10; i++) // INITIALISATION DU TABLEAU DES RANDOM
            {
                tableau[i] = Aleatoire.Next(1,10);
                Console.WriteLine(tableau[i] + " ");
                valeurs[i] = 0;
                frequence[i] = 1;
            }


            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j <= i && !trouve; j++) 
                {
                    if(tableau[i] == valeurs[j])
                    {
                        frequence[j] += 1;
                        trouve = true;
                    }
                }
                if(!trouve)
                {
                    valeurs[position] = tableau[i];
                    position += 1;
                }

                trouve = false;
            }

            int max = 0;
            position = 0;

            for (int k = 0; k < valeurs.Length; k++)
            {
                if(max < frequence[k])
                {
                   max = frequence[k];
                   position = k;
                }
            }

            Console.WriteLine("La valeur la plus representee est " + valeurs[position] + " - " + max + " fois.");

           for (int k = 0; k < 10; k++)
            {
                Console.Write(valeurs[k] + " ");
            }
            Console.WriteLine("\n");
            for (int k = 0; k < 10; k++)
            {
                Console.Write(frequence[k] + " ");
            } 



            Console.ReadKey(); // Attend de presser sur une touche pour fermer l'appli
        }
    }
}
