/*
 * Haz un programa que realice la media de los valores que contiene un array de 10 int y lo muestre por consola. No es necesario pedir los números al usuario. 
 * Pista:
 * Podemos ir sumando en cada vuelta del bucle cada valor de cada posición del array.
 */
using System;

namespace _12_Ejercicio_Repaso04
{
    class Program
    {
        static void Main(string[] args)
        {

            float[] valor = new float[10];

            Console.WriteLine(valor[0] = 1);
            Console.WriteLine(valor[1] = 2);
            Console.WriteLine(valor[2] = 7);
            Console.WriteLine(valor[3] = 3);
            Console.WriteLine(valor[4] = 6);
            Console.WriteLine(valor[5] = 9);
            Console.WriteLine(valor[6] = 6);
            Console.WriteLine(valor[7] = 3);
            Console.WriteLine(valor[8] = 12);
            Console.WriteLine(valor[9] = 8);


           Console.WriteLine((valor[0] + valor[1] + valor[2] + valor[3] + valor[4] + valor[5] + valor[6] + valor[7] + valor[8] + valor[9]) / 10);

            //Introduce aquí tu código
        }
    }
}
