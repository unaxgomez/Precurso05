/*
 * Crear un array de 3 ints. Asignar un valor a cada uno de las 3 posiciones. Mostrar los 3 valores en pantalla.
 */
using System;

namespace _04_Ejercicio_Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cosas = new int[3];

            int caramelo0 = cosas[0];
            int caramelo1 = cosas[1];
            int caramelo2 = cosas[2];

            cosas[0] = 3;
            cosas[1] = 5;
            cosas[2] = 7;

            Console.WriteLine(cosas[0]);
            Console.WriteLine(cosas[1]);
            Console.WriteLine(cosas[2]);

            //Introduce aquí tu código
        }
    }
}
