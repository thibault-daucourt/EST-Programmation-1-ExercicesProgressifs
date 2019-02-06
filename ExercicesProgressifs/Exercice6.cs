using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExercicesProgressifs
{
    class Exercice6
    {
        public void Run()
        {
            // affichage de la description de base du Programm
            Console.WriteLine("Demande un  caractère à l'utilisateur.");
            Console.WriteLine("Affiche une phrase en fonction du caractère.");
            Console.WriteLine(" D, B, P, J, # ou autre !");

            // Saisie utilisateur
            Console.Write("Introduisez un caractère :");
            char userInput = char.Parse(Console.ReadLine());

            // identification du message à afficher
            string message;
            switch (userInput)
            {
                case 'D':
                case 'd':message = "D comme début !"; break;
                case 'B':
                case 'b':message = "B comme b.a. ba !"; break;
                case 'P':
                case 'p':message = "P comme programmation !"; break;
                case 'J':
                case 'j':message = "J comme JAVA, ca m’éclate !"; break;
                case '#':message = "# comme C# !"; break;
                default:message = "No comment"; break;
            }

            Console.WriteLine("--> {0}",message);

        }
        
    }
}