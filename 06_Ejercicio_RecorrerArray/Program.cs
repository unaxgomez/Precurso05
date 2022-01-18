/*
 * Crear un array de 10 ints. Asignar un valor a cada uno de las 10 posiciones. Mostrar los 10 valores en pantalla.
 */
using System;

namespace _06_Ejercicio_RecorrerArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] casa = new int[10];

            int casa0 = casa[0];
            int casa1 = casa[1];
            int casa2 = casa[2];
            int casa3 = casa[3];
            int casa4 = casa[4];
            int casa5 = casa[5];
            int casa6 = casa[6];
            int casa7 = casa[7];
            int casa8 = casa[8];
            int casa9 = casa[9];

            casa[0] = 4;
            casa[1] = 5;
            casa[2] = 7;
            casa[3] = 12;
            casa[4] = 66;
            casa[5] = 9;
            casa[6] = 8;
            casa[7] = 1;
            casa[8] = 2;
            casa[9] = 3;

            Console.WriteLine(casa[0] + casa[1] + casa[2] + casa[3] + casa[4] + casa[5] + casa[6] + casa[7] + casa[8] + casa[9]);



            //Introduce aquí tu código
        }
    }
}
