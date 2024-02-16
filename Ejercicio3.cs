using System;

namespace Ejercicio3
{
    internal class Ejercicio3
    {
        static void Main(string[] args)
        {
            int n = 0;
            string texto = "El número ingresado es ";
            Console.WriteLine("Ingrese un numero entero: ");
            n = int.Parse(Console.ReadLine());
            texto = n>0 ? texto + "positivo" : (n<0 ? texto + "negativo": texto + "cero");
            Console.WriteLine(texto);
        }
    }
}