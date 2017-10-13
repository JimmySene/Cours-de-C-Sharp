using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        { // TABLEAU MULTI DIMENSIONS 

            int nombreLignes, nombreColones;

            Console.WriteLine("Entrez le nombre de lignes : ");
            nombreLignes = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le nombre de colones : ");
            nombreColones = int.Parse(Console.ReadLine());

            Random aleatoire = new Random();

            int[,] tableau = new int[nombreLignes, nombreColones];

            for(int i = 0; i < nombreLignes; i++)
            {
                for(int j = 0; j < nombreColones; j++)
                {
                    tableau[i, j] = aleatoire.Next(0,100);
                    Console.Write(tableau[i, j]+ " ");
                }
                Console.WriteLine("");
            }

            
            Console.ReadKey(); 

        

        } 
    }
}
