using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExercicesProgressifs
{
    class Exercice8
    {
        public static void Run()
        {
            // affichage de la description de base du Programm
            Console.WriteLine("Demande un nombre à l'utilisateur.");
            Console.WriteLine("Affiche la valeur de la somme factorielle de ce nombre");
            Console.WriteLine("le nombre doit être supérieur à 1");

            // Saisie utilisateur
            Console.Write("\n Introduisez un caractère : ");
            int userInput = int.Parse(Console.ReadLine());

            if(userInput > 1)
            {
                // affichage du résult
                Console.Write("\n La somme des nombre de 1 à {0} = {1}\n", userInput, factorial_Sum_Recursion(userInput));
            }
            
            
        }

        /// <summary>
        /// Calcule la somme factorielle d'un nombre de manière récursive
        /// </summary>
        /// <param name="number"> nombre dont on doit calculer la somme factorielle</param>
        /// <returns>le resultat de la somme factorielle</returns>
        public static double factorial_Sum_Recursion(int number)
        {
            if (number == 1)
                return 1;
            else
                return number + factorial_Sum_Recursion(number-1);
        }

        public static double factorial_Recursion(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * factorial_Recursion(number - 1);
        }
    }
}