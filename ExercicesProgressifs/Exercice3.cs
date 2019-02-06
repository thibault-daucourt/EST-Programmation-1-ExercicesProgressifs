using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicesProgressifs
{
    class Exercice3
    {
        public static void Run()
        {
            int unEntier = 123124124;

            Console.WriteLine("int : {0} valeur min = {1} valeur max = {2}",
                unEntier, int.MinValue, int.MaxValue);

            byte unByte = 234;

            Console.WriteLine("byte : {0} valeur min = {1} valeur max = {2}",
                unByte, byte.MinValue, byte.MaxValue);

            float unFloat = 1.33F;

            Console.WriteLine("float : {0} valeur min = {1} valeur max = {2}",
                unFloat, float.MinValue, float.MaxValue);

            bool unBool = true;

            Console.WriteLine("bool : {0} valeur possible : {1}, {2}",
                unBool, bool.TrueString, bool.FalseString);
        }
        
    }
}
