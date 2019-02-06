using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicesProgressifs
{
    class Exercice4
    {
        public static void Run()
        {
            double a = 3.4;
            double b = 5.1;

            Console.WriteLine("Valeur a : {0}", a);
            Console.WriteLine("Valeur b : {0}", b);

            Console.WriteLine("\n");

            Console.WriteLine("Valeur népérien : {0}", Math.E);
            Console.WriteLine("Valeur pi : {0}", Math.PI);

            Console.WriteLine("\n");

            Console.WriteLine(" !!! Les angles doivent être donnée en radiant dans les fonctions  !!", Math.E);
            Console.WriteLine("Sinus de 45 degrés : {0}", Math.Sin(45 / 360.0 * 2 * Math.PI));
            Console.WriteLine("Cosinus de 0 degrés : {0}", Math.Cos(0 / 360.0 * 2 * Math.PI));
            Console.WriteLine("Tangeante de 90 degrés : {0}", Math.Tan(90 / 360.0 * 2 * Math.PI));

            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------------------");
        }
    }
}
