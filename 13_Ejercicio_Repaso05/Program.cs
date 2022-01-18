/*
 * Crear un array de 11 ints. Pedir al usuario que introduzca valores entre 0 y 10. Cada vez que introduzca un dígito, añadir uno al valor en esa posición del array. 
 * Si por ejemplo introduce un 3, sumar uno a la posición 3. Mostrar en pantalla los valores. Si introduce un número mayor que 10, decir que ese número es incorrecto. 
 * Si introduce un número negativo, mostrar en pantalla el número de cada posición y el valor que contiene. Por ejemplo, si introduce 7, 7, 7, 5, 6, 5, 9, 9, 10, -1 mostrar:
 * 0	
 * 1	0
 * 2	0
 * 3	0
 * 4	0
 * 5	2
 * 6	1
 * 7	3
 * 9	2
 * 10	1
 */
using System;

namespace _13_Ejercicio_Repaso05
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrays = {10};

            int variable0 = 0;
            int variable1 = 0;
            int variable2 = 0;
            int variable3 = 0;
            int variable4 = 0;
            int variable5 = 0;
            int variable6 = 0;
            int variable7 = 0;
            int variable8 = 0;
            int variable9 = 0;
            int variable10 = 0;


            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Introduce un valor entre 0 y 10");

                string respuestausuario = Console.ReadLine();

                int respuesta = Convert.ToInt32(respuestausuario);

                if (respuesta == 0)
                {
                    variable0 += 1;
                }
                else if (respuesta == 1)
                {
                    variable1 += 1;
                }
                else if (respuesta == 2)
                {
                    variable2 += 1;
                }
                else if (respuesta == 3)
                {
                    variable3 += 1;
                }
                else if (respuesta == 4)
                {
                    variable4 += 1;
                }
                else if (respuesta == 5)
                {
                    variable5 += 1;
                }
                else if (respuesta == 6)
                {
                    variable6 += 1;
                }
                else if (respuesta == 7)
                {
                    variable7 += 1;
                }
                else if (respuesta == 8)
                {
                    variable8 += 1;
                }
                else if (respuesta == 9)
                {
                    variable9 += 1;
                }
                else if (respuesta == 10)
                {
                    variable10 += 1;
                }

                else
                {
                    Console.WriteLine("Introduce un número válido");
                }

              

            }

            Console.WriteLine("0" + "       " + variable0);
            Console.WriteLine("1" + "       " + variable1);
            Console.WriteLine("2" + "       " + variable2);
            Console.WriteLine("3" + "       " + variable3);
            Console.WriteLine("4" + "       " + variable4);
            Console.WriteLine("5" + "       " + variable5);
            Console.WriteLine("6" + "       " + variable6);
            Console.WriteLine("7" + "       " + variable7);
            Console.WriteLine("8" + "       " + variable8);
            Console.WriteLine("9" + "       " + variable9);
            Console.WriteLine("10" + "      " + variable10);

            //Introduce aquí tu código
        }
    }
}
