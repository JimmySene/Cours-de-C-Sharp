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
                afficheTab(tab);
                Console.WriteLine("\n=== POINTS COLS ===");
                trouverPointsCols(tab);
                Console.WriteLine("\n=== POINTS MIN ===");
                trouverPointsMin(tab);
                Console.WriteLine("\n=== POINTS MAX ===");
                trouverPointsMax(tab);
                Console.WriteLine("\n=== POINTS ISOLES ===");
                trouverPointsIsoles(tab);

                Console.WriteLine("Appuyez sur q et la touche entre pour quitter ou n'importe quelle autre touche pour recommencer.");
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

        static void afficheTab(int[,] tab)
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

        static void trouverPointsCols(int[,] tab)
        {
            bool trouve = false;
            int[] pc = new int[3];
            int[] x = new int[3];
            int[] y = new int[3];

            int min = 11, position = 0;

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

        static void trouverPointsMin(int[,] tab)
        {
            int minimum = 11, position = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tab[i, j] < minimum)
                    {
                        minimum = tab[i, j];
                        position = j;
                    }
                }
                switch (i)
                {
                    case 0:
                        if (minimum < tab[i + 1, position] && minimum < tab[i + 2, position])
                            Console.WriteLine(minimum + " situe en " + i + "," + position + " est un point min !");
                        break;
                    case 1:
                        if (minimum < tab[i - 1, position] && minimum < tab[i + 1, position])
                            Console.WriteLine(minimum + " situe en " + i + "," + position + " est un point min !");
                        break;
                    case 2:
                        if (minimum < tab[i - 2, position] && minimum < tab[i - 1, position])
                            Console.WriteLine(minimum + " situe en " + i + "," + position + " est un point min !");
                        break;
                    default:
                        break;
                }
                minimum = 11;
            }
        }

        static void trouverPointsMax(int[,] tab)
        {
            int maximum = -11, position = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tab[i, j] > maximum)
                    {
                        maximum = tab[i, j];
                        position = j;
                    }
                }
                switch (i)
                {
                    case 0:
                        if (maximum > tab[i + 1, position] && maximum > tab[i + 2, position])
                            Console.WriteLine(maximum + " situe en " + i + "," + position + " est un point max !");
                        break;
                    case 1:
                        if (maximum > tab[i - 1, position] && maximum > tab[i + 1, position])
                            Console.WriteLine(maximum + " situe en " + i + "," + position + " est un point max !");
                        break;
                    case 2:
                        if (maximum > tab[i - 2, position] && maximum > tab[i - 1, position])
                            Console.WriteLine(maximum + " situe en " + i + "," + position + " est un point max !");
                        break;
                    default:
                        break;
                }
                maximum = -11;
            }
        }

        static void trouverPointsIsoles(int[,] tab)
        {
            
            bool trouve = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    
                    switch(i)
                    {
                        case 0:
                            if (tab[i, j] != tab[i + 1, j] && tab[i, j] != tab[i + 2, j])
                                trouve = false;
                            break;
                        case 1:
                            if (tab[i, j] != tab[i - 1, j] && tab[i, j] != tab[i + 1, j])
                                trouve = false;
                            break;
                        case 2:
                            if (tab[i, j] != tab[i - 2, j] && tab[i, j] != tab[i - 1, j])
                                trouve = false;
                            break;
                        default:
                            break;
                    }

                    if(!trouve)
                    {
                        switch(j)
                        {
                            case 0:
                                if (tab[i, j] != tab[i, j + 1] && tab[i, j] != tab[i, j + 2])
                                    Console.WriteLine(tab[i,j] + " situe en " + i + ", " + j + " est un point isole !");
                                break;
                            case 1:
                                if (tab[i, j] != tab[i, j - 1] && tab[i, j] != tab[i, j + 1])
                                    Console.WriteLine(tab[i, j] + " situe en " + i + ", " + j + " est un point isole !");
                                break;
                            case 2:
                                if (tab[i, j] != tab[i, j - 2] && tab[i, j] != tab[i, j - 1])
                                    Console.WriteLine(tab[i, j] + " situe en " + i + ", " + j + " est un point isole !");
                                break;
                            default:
                                break;
                        }
                    }
                }
                trouve = true;
                
                
            }
        }
    }
}
