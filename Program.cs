using System;

namespace LesBouclesExo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*Créer une variable result. Demander à l’utilisateur un nombre à additionner puis s’il veut ajouter un nombre. 
            Tant que l’utilisateur ne répond pas non, redemander un nombre et l’ajouter au résultat.
            Afficher le résultat dans une phrase.*/

            Console.WriteLine("Pouvez vous renseigner le montant de number 1 ?");

            int number1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(number1 +33);

            Console.WriteLine("Pouvez vous renseigner le montant de number 2 ?");
            int number2 = Convert.ToInt32(Console.ReadLine());
            number2++;
            //  Console.WriteLine(number2);

            float sum = number1 + 33;
            float division;
            division = sum / number2;

            Console.WriteLine($"la valeur de la division du premier nombre par le deuxième est de {division}");












            /*int result;
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
            Console.WriteLine($"Le résultat est {result}"); //résultat seulement a la fin de l'exercice*/
        }
    }
}
