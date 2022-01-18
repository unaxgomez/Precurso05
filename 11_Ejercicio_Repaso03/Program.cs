/*
 * Poner los nombres de los meses en un array de 12. Cuando el usuario introduce un número del 1 al 12, mostrar el nombre de ese mes en pantalla.
 */
using System;

namespace _11_Ejercicio_Repaso03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduce un número del 1 al 12");

            string numerousuario = Console.ReadLine();

            int numero = Convert.ToInt32(numerousuario);

            string [] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };


            if (numero > 0)
            {
                Console.WriteLine(meses[numero - 1]);
            }

            else
            {
                Console.WriteLine("Escribe un número válido");
            }


            //Introduce aquí tu código

        }
    }
}
