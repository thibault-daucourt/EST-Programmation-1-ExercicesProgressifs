using System;
using System.Collections.Generic;
using System.Text;

/* Auteur : Thibault Daucourt
 * Programme : Exercice progressif 2 
 * 
 * 
 */
namespace ExercicesProgressifs
{
    class Exercice2
    {
        public static void Run()
        {
            // création du générateur de nombre aléatoire
            Random randomGenerator = new Random();

            // nombre entier non négatif
            int number1 = randomGenerator.Next(0, 2147483647);

            // nombre entier non négatif entre 0 et 10 non compris
            int number2 = randomGenerator.Next(0, 10);

            // nombre entier non négatif entre 5 et 15 non compris
            int number3 = randomGenerator.Next(5, 15);

            // nombre réel entre 0.0 et 1.0
            double number4 = randomGenerator.NextDouble();

            Console.WriteLine("Génère un nombre aléatoire entier : 0 <= nombre < 2147483647");
            Console.WriteLine("Nombre 1  généré = " + number1);

            Console.WriteLine("Génère un nombre aléatoire entier : 0 <= nombre < 10");
            Console.WriteLine("Nombre 2  généré = " + number2);

            Console.WriteLine("Génère un nombre aléatoire entier : 5 <= nombre < 15");
            Console.WriteLine("Nombre 3  généré = " + number3);

            Console.WriteLine("Génère un nombre aléatoire entier : 0 <= nombre < 0.1");
            Console.WriteLine("Nombre 4  généré = " + number4);

            Double sumNumber = number4 + number1 + number2 + number3;

            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Somme des 4 nombres = " + sumNumber);
            Console.WriteLine("\n------------------------------------------------------------------------");
            Console.WriteLine("Fin de l'application");

        }
    }
}
