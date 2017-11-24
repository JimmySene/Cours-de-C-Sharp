using System;

namespace TP_4___Morpion
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] plateau = new string[3,3];

            remplirPlateau(ref plateau);
            affichePlateau(plateau);

            Console.ReadKey();

        }

        static void remplirPlateau(ref string[,] plateau)
        {
            int x = 0, y = 0, nextX = 0, nextY = 0;
            for(int i = 0; i < 9; i++)
            {
                plateau[x, y] = null;
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
    }
}
