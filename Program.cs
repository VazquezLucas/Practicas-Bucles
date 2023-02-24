/*Bucle WHILE. Sintaxis
 * while(Condicion a evaluar)
 * {
 * codigo a repetir
 * }
 */
using System;

namespace PracticasBucles
{
    class program
    {
        static void Main(string[] args)
        {

            //Bucle WHILE

            Console.WriteLine("¿Deseas entrar en el bucle while?");

            string respuesta= Console.ReadLine();

            while (respuesta != "no")
            {

                Console.WriteLine("Estas ejecutando el interior del bucle while");

                Console.WriteLine("Introduce tu nombre, por favor");

                string nombre = Console.ReadLine();

                Console.WriteLine($"Saldrás del bucle {nombre} cuando respondas no a la pregunta");

                Console.WriteLine("¿Deseas repetir otra vez?");

                respuesta= Console.ReadLine();

            }

            Console.WriteLine("Has salido del bucle");

            //Ejercicio de bucle while

            Random numero=new Random();

            int numeroAleatorio=numero.Next(0,100);

            Console.WriteLine(numeroAleatorio);

        }
    }
}