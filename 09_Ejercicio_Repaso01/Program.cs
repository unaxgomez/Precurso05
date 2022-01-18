/*
 * Crear un array de 3 strings. Pedir al usuario 3 veces que escriba un string. Guardar cada uno de esos strings en la posición 0 , 1 y 2. 
 * Mostrar en pantalla en el orden: primero posición 1, después posición 2 y por último posición 0.
 * Pista: 
 * Puedes utilizar un bucle para ir pedir una palabra al usuario e introducirlo en cada una de las posiciones del array.
 */
using System;

namespace _09_Ejercicio_Repaso01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe una fruta");
            string fruta0 = Console.ReadLine();

            Console.WriteLine("Escribe otra fruta");
            string fruta1 = Console.ReadLine();

            Console.WriteLine("Escribe otra fruta");
            string fruta2 = Console.ReadLine();

            string[] frutas = {fruta0, fruta1, fruta2};

            string frutaA = frutas[0];
            string frutaB = frutas[1];
            string frutaC = frutas[2];

            Console.WriteLine(frutas [1] + " " + frutas [2] + " " + frutas[0]);


            //Introduce aquí tu código
        }
    }
}
