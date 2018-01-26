using System;

namespace TP_5___Points_Cols
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] tab = new int[3,3];
            bool quit = false;
            string key;

            do
            {

                remplirTab(ref tab);
                afficheTab(ref tab);
                trouverPointsCols(ref tab);

                Console.WriteLine("Appuyez sur q pour quitter ou n'importe quelle autre touche pour recommencer.");
                key = Console.ReadLine();
                if (key == "q")
                    quit = true;
            } while (!quit);
        }

        static void remplirTab(ref int[,] tab)
        {
            Random nbAleatoire = new Random();
            int nombre = 0; 
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    nombre = nbAleatoire.Next(-10, 10);
                    tab[i, j] = nombre;
                }
            }
        }

        static void afficheTab(ref int[,] tab)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    
                        Console.Write(" " + tab[i, j] + " ");
                }
                Console.WriteLine(" ");
               
            }
        }

        static void trouverPointsCols(ref int[,] tab)
        {
            bool trouve = false;
            int[] pc = new int[3];
            int[] x = new int[3];
            int[] y = new int[3];

            int min = 11, max = -11, position = 0;

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(tab[i,j] < min)
                    {
                        min = tab[i, j];
                        position = j;
                        
                    }
                }
                switch (i)
                {
                    case 0:
                        if(tab[i,position] > tab[i+1, position])
                        {
                            if (tab[i, position] > tab[i + 2, position])
                            {
                                pc[i] = tab[i, position];
                                x[i] = i;
                                y[i] = position;
                                trouve = true;
                            }
                        }
                        break;
                    case 1:
                        if (tab[i, position] > tab[i - 1, position])
                        {
                            if (tab[i, position] > tab[i + 1, position])
                            {
                                pc[i] = tab[i, position];
                                x[i] = i;
                                y[i] = position;
                                trouve = true;
                            }
                        }
                        break;
                    case 2:
                        if (tab[i, position] > tab[i - 2, position])
                        {
                            if (tab[i, position] > tab[i - 1, position])
                            {
                                pc[i] = tab[i, position];
                                x[i] = i;
                                y[i] = position;
                                trouve = true;
                            }
                        }
                        break;
                    default:
                        break;
                }
                min = 11;

            }

            if (trouve)
            {
                Console.WriteLine("Les points cols sont : ");
                for (int k = 0; k < 3; k++)
                {
                    if(pc[k] != 0)
                        Console.Write(pc[k] + " (" + x[k] + ", " + y[k] + ")");
                }
            } else
            {

                Console.WriteLine("Il n'y a aucun points cols dans le tableau !");
            }
        }
    }
}
