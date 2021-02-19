using System;

namespace LesBouclesExo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Créer une variable result. Demander à l’utilisateur un nombre à additionner puis s’il veut ajouter un nombre. 
            //Tant que l’utilisateur ne répond pas non, redemander un nombre et l’ajouter au résultat.
            //Afficher le résultat dans une phrase.

            int result;
            int number1;
            string demander;

            Console.WriteLine("Entrez un premier nombre : ");
            result = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insérer un second nombre qui va s'additionner au premier ? \n oui OU non");
            demander = Console.ReadLine();

            while (demander == "oui")

            {
                Console.WriteLine("Entrez un nombre qui s'additionne avec le précédent : ");
                number1 = Convert.ToInt32(Console.ReadLine());
                result = result + number1;
                //Console.WriteLine($"Le résultat est {result}"); //résultat au cour de l'exercie
                Console.WriteLine("Voulez-vous continuer ?\n oui OU non");
                demander = Console.ReadLine();
            }
            Console.WriteLine($"Le résultat est {result}"); //résultat seulement a la fin de l'exercice
        }
    }
}
