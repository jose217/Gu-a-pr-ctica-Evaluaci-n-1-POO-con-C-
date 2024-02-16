using System;
using System.Runtime.CompilerServices;

namespace Ejercicio1
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese el primer numero");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo numero");
                double num2 = Convert.ToDouble(Console.ReadLine());
                double resultado = Math.Max(num1, num2);


                Console.WriteLine("El numero mayor de {0} y {1} es: {2}", num1, num2, resultado);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error, debe de ingresar un numero");
            }

            Console.WriteLine("Ingrese un numero para obtener la raiz cubica");
            double numero = Convert.ToDouble(Console.ReadLine());
            double raizcubica = Math.Pow(numero, 3);

            Console.WriteLine("La raiz cubica de {0} es: {1}", numero, raizcubica);


        }
    }
}