using System;

namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] monTab = new int[10, 10];

            remplirTab(ref monTab);
            afficheTab(monTab);
            Console.WriteLine(" ");
            triTab(ref monTab);
            afficheTab(monTab);
            Console.Write(' ');
            Console.ReadKey();
           
        }

        static void remplirTab(ref int[,] tab)
        {
            Random aleatoire = new Random();
            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tab[i, j] = aleatoire.Next(1, 50);
                }
            }
        }

        static void triTab(ref int[,] tab)
        {
            int temp = 0;
            int i = 0, j = 0;
            int k, l;
            int nextI = 0, nextJ = 0;
          
            for (int x = 0; x < 100; x++)
            {
                k = i;
                l = j;

               for(int y = x; y < 100 ; y++)
                {  
                    caseSuivante(k, l, ref nextI, ref nextJ);
                    
                    
                   if(tab[nextI,nextJ] < tab[i,j])
                    {
                        swap(ref tab, i, j, nextI, nextJ); 
                        
                    }

                    k = nextI;
                    l = nextJ;

                }
                
                nextI = i;
                nextJ = j;

                caseSuivante(i, j, ref nextI, ref nextJ);
                i = nextI;
                j = nextJ;

            }

        }

        static void caseSuivante(int x, int y, ref int nextX, ref int nextY)
        {
            if (x == 9 && y == 9)
            {
                nextX = 9;
                nextY = 9;
            }
            else if (y == 9)
            {
                nextX = x + 1;
                nextY = 0;
            }
            else
            {
                nextY = y + 1;
                nextX = x;
            }
        }

        static void afficheTab(int[,] tab)
        {
            int i = 0;
            int j = 0;
            int nextI = 0, nextJ = 0;
            for(int nb = 0; nb < 100; nb++)
            {
                if(nb % 10 == 0)
                {
                    Console.WriteLine(" ");
                }

                Console.Write(tab[nextI, nextJ] + " ");
                caseSuivante(i, j, ref nextI, ref nextJ);
                i = nextI;
                j = nextJ;
            }
        }

        static void swap(ref int[,] tab, int i, int j, int nextI, int nextJ)
        {
            int temp = 0;

            temp = tab[nextI, nextJ];
            tab[nextI, nextJ] = tab[i, j];
            tab[i, j] = temp;
        }
    }
}
