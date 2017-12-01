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
            bool tourFini = false;

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
            
            

        }

        static void modeDefensif(ref string[,] plateau)
        {
            Console.WriteLine("\n=== MODE DEFENSIF ===\n");
        }

        static void verifGagne(ref string[,] plateau, ref bool fini)
        {
            int compteurO = 0;
            int compteurX = 0;

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
    }
}
