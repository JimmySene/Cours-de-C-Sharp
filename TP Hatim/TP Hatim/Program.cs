using System;

namespace TP_Hatim
{
        class Program
        {
            private static int i = 10;


            static void Main(string[] args)
            //ici j'initialise les variables (random étant une variable aléatoire)
            {
                int[] monTab1 = new int[15];
                int[] monTab2 = new int[15];
                int[] monTab3 = new int[15];
            
                bool trouve = false;
                int position = 0;

            for (int i = 0; i < 15; i++)
            {
                monTab3[i] = 0;
            }

                Random Aleatoire = new Random();


            Console.WriteLine("Vos valeurs pour le tableau 1 ?");

                 for (int i = 0; i < 15; i++)

                {
                    //je demande a la console de prendre des valeurs aléatoires 15 fois)

                     monTab1[i] = Aleatoire.Next(0, 8);
                     Console.Write(monTab1[i].ToString() + " ");
             
            }

            Console.WriteLine(" ");

            Console.WriteLine("Vos valeurs pour le tableau 2 ?");

            for (int i = 0; i < 15; i++)
                {

                    monTab2[i] = Aleatoire.Next(0, 8);
                    Console.Write(monTab2[i].ToString() + " ");
            }
              
               
            // la console compare la case 1 tab1 avec toutes les cases du tab2 "si une valeur de la case 1 est identique à une valeur du tab2
            // elle la prend. ainsi de suite case 2 tab1 avec les 5 cases du tab2
            for (int i = 0; i < 15; i++)
            {
                for (int k = 0; k < 15; k++)
                {
                    if (monTab3[k] == monTab1[i])
                    {
                        trouve = true;
                    }
                    else
                    {
                        if(monTab3[k] != 0)
                        position++;
                    }
                }

                for (int j = 0; j < 15; j++)
                {
                  

                }
                

            }
                Console.WriteLine(" ");
                Console.ReadKey();

            }
        }
}
