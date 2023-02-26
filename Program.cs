/*Bucle WHILE. Sintaxis
 * while(Condicion a evaluar)
 * {
 * codigo a repetir
 * }
 */

/*Bucle Do-While. sintaxis
*do{
*codigo
*}while(Condicion)
*/

using System;

namespace PracticasBucles
{
    class program
    {
        static void Main(string[] args)
        {
            /*
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

            int aleatorio=numero.Next(0,100);

            int minumero = 101;

            int intentos = 0;

            Console.WriteLine("Introduce un numero entre el 0 y 100");

            while(aleatorio!= minumero)
            {

                intentos++;

                minumero=int.Parse(Console.ReadLine());

                if (minumero > aleatorio) Console.WriteLine("El numero es mas bajo");

                if (minumero < aleatorio) Console.WriteLine("El numero es mas alto");

            }

            Console.WriteLine($"Correcto! Has necesitado {intentos} intentos");

            //Bucle do-while

            int z = 10;


            do
            {
                Console.WriteLine("Impresión " + z);

                z++;
            } while (z < 15);

            */

            //Ejercicio de while pero con do-while

            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);

            int minumero;

            int intentos = 0;

            Console.WriteLine("Introduce un numero entre el 0 y 100");


            do{
                intentos++;

                minumero = int.Parse(Console.ReadLine());

                if (minumero > aleatorio) Console.WriteLine("El numero es mas bajo");

                if (minumero < aleatorio) Console.WriteLine("El numero es mas alto");

            } while (aleatorio != minumero);

            Console.WriteLine($"Correcto! Has necesitado {intentos} intentos");

        }
    }
}