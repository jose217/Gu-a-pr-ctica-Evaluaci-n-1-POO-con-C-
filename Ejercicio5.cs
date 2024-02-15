using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio5
{
    class ejercicio5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese dos numeros reales");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la clave de la operacion que desea");
            Console.WriteLine("Clave + \nClave - \nClave * \nClave / \nClave R \nClave E");
            string clave = Console.ReadLine();
            switch (clave)
            {
                case "+":
                    double suma = num1 + num2;
                    Console.WriteLine("La suma de {0} mas {1} es {2}", num1, num2, suma);
                    break;
                case "-":
                    double resta = num1 - num2;
                    Console.WriteLine("La resta de {0} menos {1} es {2} ", num1, num2, resta);
                    break;
                case "*":
                    double producto = num1 * num2;
                    Console.WriteLine("La multiplicacion de {0} por {1} es {2}", num1, num2, producto);
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        double division = num1 / num2;
                        Console.WriteLine("La division de {0} entre {1} es {2}", num1, num2, division);
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre cero");
                    }
                    break;
                case "R":
                    double raiz1 = Math.Sqrt(num1);
                    double raiz2 = Math.Sqrt(num2);
                    Console.WriteLine("La raiz cuadrada de {0} es {1} \nLa raiz cuadrada de {2} es {3}", num1, raiz1, num2, raiz2);
                    break;
                case "E":
                    double elevacion = Math.Pow(num1, num2);
                    double decimales = Math.Round(elevacion, 3);
                    Console.WriteLine("{0} elevado a {1} es {2}", num1, num2, decimales);
                    break;
            }
        }
    }
}