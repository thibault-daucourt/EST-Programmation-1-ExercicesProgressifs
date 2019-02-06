using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicesProgressifs
{
    class Exercice5
    {
        public static void Run()
        {
            int numberRead;
            int multipleRead;

            Console.WriteLine("Introduiser le nombre entier : ");
            numberRead = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduiser le nombre multiple : ");
            multipleRead = int.Parse(Console.ReadLine());

            if (numberRead % multipleRead == 0)
                Console.WriteLine(numberRead + " est un multiple de " + multipleRead);
            else
                Console.WriteLine(numberRead + " n'est pas un multiple de " + multipleRead);
        }
    }
}
