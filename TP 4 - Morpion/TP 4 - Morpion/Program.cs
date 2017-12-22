using System;

namespace TP_4___Morpion
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] plateau = new string[3,3];
            string caractere, saisieModeDeJeu;

            remplirPlateau(ref plateau);

            Console.WriteLine("Selectionnez un mode de jeu : \n");
            Console.WriteLine("1.Mode aleatoire");
            Console.WriteLine("2.Mode offensif");
            Console.WriteLine("3.Mode defensif");

            saisieModeDeJeu = Console.ReadLine();

            modeDeJeu(int.Parse(saisieModeDeJeu), ref plateau);

            caractere = Console.ReadLine();

            Console.ReadKey();

        }

        static void remplirPlateau(ref string[,] plateau)
        {
            int x = 0, y = 0, nextX = 0, nextY = 0;
            for(int i = 0; i < 9; i++)
            {
                plateau[x, y] = "_";
                caseSuivante(x,y,ref nextX,ref nextY);
                x = nextX;
                y = nextY;
            }
        }

        static void affichePlateau(string[,] plateau)
        {
            int x = 0, y = 0, nextX = 0, nextY = 0;
            for(int i = 0; i<9; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(" ");
                }
                Console.Write(" " + plateau[x,y] + " ");
                caseSuivante(x,y,ref nextX, ref nextY);
                x = nextX;
                y = nextY;
            }
        }

        static void caseSuivante(int x, int y, ref int nextX, ref int nextY)
        {
            if (y == 2)
            {
                nextX = x + 1;
                nextY = 0;
            }
            else
            {
                nextX = x;
                nextY = y + 1;
            }
        }

        static void modeDeJeu(int saisieModeDeJeu, ref string [,] plateau)
        {
            switch(saisieModeDeJeu)
            {
                case 1:
                    modeAleatoire(ref plateau);
                    break;
                case 2:
                    modeOffensif(ref plateau);
                    break;
                case 3:
                    modeDefensif(ref plateau);
                    break;
                default:
                    modeAleatoire(ref plateau);
                    break;
            }
        }

        static void modeAleatoire(ref string[,] plateau)
        {
            Console.WriteLine("\n=== MODE ALEATOIRE ===\n");

            bool fini = false;

            Random commence = new Random();
            int joueur = commence.Next(0, 1);
 
            int positionX;
            int positionY;

            do
            {
                if (joueur == 0)
                {
                    Random x = new Random();
                    Random y = new Random();
                    positionX = x.Next(0, 3);
                    positionY = y.Next(0, 3);

                    if (plateau[positionX, positionY] == "_")
                    {
                        plateau[positionX, positionY] = "X";
                        Console.WriteLine("\n\nL'ordinateur joue... ");
                        affichePlateau(plateau);
                        Console.WriteLine("\n\nL'ordinateur a joue ! C'est a votre tour...\n");
                        joueur = 1;
                        verifGagne(ref plateau, ref fini);
                    }

                   
                }
                else
                {
                    Console.WriteLine("Choisissez la position X : ");
                    positionX = int.Parse(Console.ReadLine());
                    Console.WriteLine("Choisissez la position Y : ");
                    positionY = int.Parse(Console.ReadLine());

                    if (plateau[positionX, positionY] == "_")
                    {
                        plateau[positionX, positionY] = "O";
                        affichePlateau(plateau);
                        joueur = 0;
                        verifGagne(ref plateau, ref fini);

                    } else
                    {
                        Console.WriteLine("Cette case est deja prise !");
                    }
                }
            } while (!fini);
        }

        static void modeOffensif(ref string[,] plateau)
        {
            Console.WriteLine("\n=== MODE OFFENSIF ===\n");

            bool fini = false;

            Random commence = new Random();
            int joueur = commence.Next(0, 1);

            do
            {
                if(joueur == 0)
                {

                } else
                {

                }
            } while (!fini);
            
            

        }

        static void modeDefensif(ref string[,] plateau)
        {
            Console.WriteLine("\n=== MODE DEFENSIF ===\n");


            bool fini = false;
            int debut = 1;

            Random commence = new Random();
            int joueur = commence.Next(0, 1);


            int positionX = 0;
            int positionY = 0;

            string test = "";

            do
            {
                if (joueur == 0)
                {
                    if (debut == 1)
                    {
                        Random x = new Random();
                        Random y = new Random();
                        positionX = x.Next(0, 3);
                        positionY = y.Next(0, 3);

                        plateau[positionX, positionY] = "X";

                        debut = 0;
                    } else
                    {
                        // LIGNE HORIZONTALE 1
                        if(plateau[0,0] == "O" && plateau[0,1] == "O" && plateau[0,2] == "_")
                        {
                            plateau[0, 2] = "X";
                        } else if(plateau[0, 1] == "O" && plateau[0, 2] == "O" && plateau[0, 0] == "_")
                        {
                            plateau[0, 0] = "X";
                        }
                        else if (plateau[0, 0] == "O" && plateau[0, 2] == "O" && plateau[0, 1] == "_")
                        {
                            plateau[0, 1] = "X";
                        }
                        // LIGNE HORIZONTALE 2
                        else if (plateau[1, 0] == "O" && plateau[1, 1] == "O" && plateau[1, 2] == "_")
                        {
                            plateau[1, 2] = "X";
                        }
                        else if (plateau[1, 1] == "O" && plateau[1, 2] == "O" && plateau[1, 0] == "_")
                        {
                            plateau[1, 0] = "X";
                        }
                        else if (plateau[1, 0] == "O" && plateau[1, 2] == "O" && plateau[1, 1] == "_")
                        {
                            plateau[1, 1] = "X";
                        }
                        // LIGNE HORIZONTALE 3
                        else if (plateau[2, 0] == "O" && plateau[2, 1] == "O" && plateau[2, 2] == "_")
                        {
                            plateau[2, 2] = "X";
                        }
                        else if (plateau[2, 1] == "O" && plateau[2, 2] == "O" && plateau[2, 0] == "_")
                        {
                            plateau[2, 0] = "X";
                        }
                        else if (plateau[2, 0] == "O" && plateau[2, 2] == "O" && plateau[2, 1] == "_")
                        {
                            plateau[2, 1] = "X";
                        }
                        // LIGNE VERTICALE 1
                        else if (plateau[0, 0] == "O" && plateau[1, 0] == "O" && plateau[2, 0] == "_")
                        {
                            plateau[2, 0] = "X";
                        }
                        else if (plateau[1, 0] == "O" && plateau[2, 0] == "O" && plateau[0, 0] == "_")
                        {
                            plateau[0, 0] = "X";
                        }
                        else if (plateau[0, 0] == "O" && plateau[2, 0] == "O" && plateau[1, 0] == "_")
                        {
                            plateau[1, 0] = "X";
                        }
                        // LIGNE VERTICALE 2
                        else if (plateau[0, 1] == "O" && plateau[1, 1] == "O" && plateau[2, 1] == "_")
                        {
                            plateau[2, 1] = "X";
                        }
                        else if (plateau[1, 1] == "O" && plateau[2, 1] == "O" && plateau[0, 1] == "_")
                        {
                            plateau[0, 1] = "X";
                        }
                        else if (plateau[0, 1] == "O" && plateau[2, 1] == "O" && plateau[1, 1] == "_")
                        {
                            plateau[1, 1] = "X";
                        }
                        // LIGNE VERTICALE 3
                        else if (plateau[0, 2] == "O" && plateau[1, 2] == "O" && plateau[2, 2] == "_")
                        {
                            plateau[2, 2] = "X";
                        }
                        else if (plateau[1, 2] == "O" && plateau[2, 2] == "O" && plateau[0, 2] == "_")
                        {
                            plateau[0, 2] = "X";
                        }
                        else if (plateau[0, 2] == "O" && plateau[2, 2] == "O" && plateau[1, 2] == "_")
                        {
                            plateau[1, 2] = "X";
                        }
                        // DIAGONALE 1
                        else if (plateau[0, 0] == "O" && plateau[1, 1] == "O" && plateau[2, 2] == "_")
                        {
                            plateau[2, 2] = "X";
                        }
                        else if (plateau[1, 1] == "O" && plateau[2, 2] == "O" && plateau[0, 0] == "_")
                        {
                            plateau[0, 0] = "X";
                        }
                        else if (plateau[0, 0] == "O" && plateau[2, 2] == "O" && plateau[1, 1] == "_")
                        {
                            plateau[1, 1] = "X";
                        }
                        // DIAGONALE 2
                        else if (plateau[2, 0] == "O" && plateau[1, 1] == "O" && plateau[0, 2] == "_")
                        {
                            plateau[0, 2] = "X";
                        }
                        else if (plateau[0, 2] == "O" && plateau[2, 2] == "O" && plateau[1, 1] == "_")
                        {
                            plateau[1, 1] = "X";
                        }
                        else if (plateau[1, 1] == "O" && plateau[0, 2] == "O" && plateau[2, 0] == "_")
                        {
                            plateau[2, 0] = "X";
                        }
                        else
                        {
                           

                            bool bon = false;
                            do
                            {
                                Random x = new Random();
                                Random y = new Random();
                                positionX = x.Next(0, 3);
                                positionY = y.Next(0, 3);
                                if (plateau[positionX, positionY] == "_")
                                {
                                    plateau[positionX, positionY] = "X";
                                    bon = true;
                                }      
                                    
                            } while (!bon);
                            
                            
                        }
                    }

                        Console.WriteLine("\n\nL'ordinateur joue... ");
                        affichePlateau(plateau);
                        Console.WriteLine("\n\nL'ordinateur a joue ! C'est a votre tour...\n");
                        joueur = 1;
                        verifGagne(ref plateau, ref fini);

                }
                else
                {
                    Console.WriteLine("Choisissez la position X : ");
                   
                 
                    
                    
                        positionX = int.Parse(Console.ReadLine());
                        Console.WriteLine("Choisissez la position Y : ");
                        positionY = int.Parse(Console.ReadLine());
                        
                        

                        if (plateau[positionX, positionY] == "_")
                        {
                            plateau[positionX, positionY] = "O";
                            affichePlateau(plateau);
                            joueur = 0;
                            verifGagne(ref plateau, ref fini);

                        }
                        else
                        {
                            Console.WriteLine("Cette case est deja prise !");
                        }
                            
                   
                }
            } while (!fini);
        }

        static void verifGagne(ref string[,] plateau, ref bool fini)
        {
            int compteurO = 0;
            int compteurX = 0;
            int compteurG = 0;

            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (plateau[i, j] == "O")
                    {
                        compteurO++;
                    }
                    if (plateau[i, j] == "X")
                    {
                        compteurX++;
                    }
                    if(plateau[i,j] != "_")
                    {
                        compteurG++;
                    }
                }
                if(compteurO == 3)
                {
                    Console.WriteLine("Vous avez gagne !");
                    fini = true;
                    break;
                } else if(compteurX == 3)
                {
                    Console.WriteLine("Vous avez perdu !");
                    fini = true;
                    break;
                } else if(compteurG == 9)
                {
                    Console.WriteLine("Match nul !");
                    fini = true;
                    break;
                }
                compteurO = 0;
                compteurX = 0;
            }

            if(!fini)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (plateau[j, i] == "O")
                        {
                            compteurO++;
                        }
                        if (plateau[j, i] == "X")
                        {
                            compteurX++;
                        }
                    }
                    if (compteurO == 3)
                    {
                        Console.WriteLine("Vous avez gagne !");
                        fini = true;
                        break;
                    }
                    else if (compteurX == 3)
                    {
                        Console.WriteLine("Vous avez perdu !");
                        fini = true;
                        break;
                    }
                    compteurO = 0;
                    compteurX = 0;
                }
            }

            if(!fini)
            {
                for(int i = 0; i < 3; i++)
                {
                    if (plateau[i, i] == "O")
                    {
                        compteurO++;
                    }
                    if (plateau[i, i] == "X")
                    {
                        compteurX++;
                    }
                }
                if (compteurO == 3)
                {
                    Console.WriteLine("Vous avez gagne !");
                    fini = true;
                }
                else if (compteurX == 3)
                {
                    Console.WriteLine("Vous avez perdu !");
                    fini = true;
                }
                compteurO = 0;
                compteurX = 0;
            }

            if (!fini)
            {
                int k = 2;
                for (int i = 0; i < 3; i++)
                {
                    
                    if (plateau[i, k] == "O")
                    {
                        compteurO++;
                    }
                    if (plateau[i, k] == "X")
                    {
                        compteurX++;
                    }
                    k--;
                }
                if (compteurO == 3)
                {
                    Console.WriteLine("Vous avez gagne !");
                    fini = true;
                }
                else if (compteurX == 3)
                {
                    Console.WriteLine("Vous avez perdu !");
                    fini = true;
                }
            }
        }

        static void verifCoups(string[,] plateau, string joueur)
        {
            string opposant;
            switch(joueur)
            {
                case "X":
                    opposant = "O";
                    break;
                case "O":
                    opposant = "X";
                    break;
            }
        }
    }
}
