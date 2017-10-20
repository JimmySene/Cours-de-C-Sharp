using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        { 

            int[] monTab  = new int[10];

            remplirTab(ref monTab);
            triTab(ref monTab);
            afficherTab(ref monTab);
          

            Console.WriteLine("La valeur min vaut " + donnerMin(monTab));
            Console.WriteLine("La valeur max vaut " + donnerMax(monTab));

            Console.ReadKey(); 

        }

        static void afficherTab(ref int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }
        static int donnerMin(int[] tab)
        {
            int min = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] < min)
                {
                    min = tab[i];
                }
            }
            return min;
        }
       static int donnerMax(int[] tab)
        {
            int max = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > max)
                {
                    max = tab[i];
                }
            }
            return max;
        }

        static void remplirTab(ref int[] tab)
        {

            Random aleatoire = new Random();

            for (int i = 0; i < 10; i++)
            {

                tab[i] = aleatoire.Next(0, 100);

            }
        }

        static void triTab(ref int[] tab)
        {

            int temp = 0;

            for(int i = 0; i < tab.Length; i++)
            {
                for(int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[j] < tab[i])
                    {
                        temp = tab[i];
                        tab[i] = tab[j];
                        tab[j] = temp;
                    }
                }  
            }
        }

    }
}
