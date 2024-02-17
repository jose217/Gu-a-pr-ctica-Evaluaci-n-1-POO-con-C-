using System;

namespace Ejercicio3
{
    internal class Ejercicio3
    {
        static void Main(string[] args)
        {	
			int num;
			string result;
			Console.Write("Ingrese un número entero:");
			num = int.Parse(Console.ReadLine());

			result = (num > 0 ? "El número es positivo." :
                           num < 0 ? "El número es negativo." :
                           "El número ingresado es 0.");

			Console.WriteLine(result);
        }
    }
}