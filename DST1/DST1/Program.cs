using System;

namespace DST1_SENE_Jimmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbModif = 0;
            string machaine, newChaine = "";
            Console.WriteLine("Quelle est votre saisie ?");
            machaine = Console.ReadLine();
            
            for(int i = 0; i < machaine.Length; i++)
            {
                if(machaine[i].ToString() == "e")
                {
                    nbModif++;
                    newChaine += "o";

                } else if(machaine[i].ToString() == "o")
                {
                    nbModif++;
                    newChaine += "e";
                } else
                {
                    newChaine += machaine[i];
                }
            }
            Console.WriteLine(machaine);
            Console.WriteLine("Saisie apres " + nbModif + " modifications : " + newChaine);
            Console.ReadKey();
        }
    }
}
