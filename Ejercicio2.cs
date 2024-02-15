using System;

namespace Ejercicio2{
	internal class Ejercicio2 {
		static void Main(string[] args)
		{
			int intentos = 0;
			string usuario = null;
			string pass = null;

			while (intentos < 3)
			{
				Console.WriteLine("Ingrese el usuario");
				usuario = Console.ReadLine();

				Console.WriteLine("Ingrese la contraseña");
				pass = Console.ReadLine();

				if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(pass))
				{
					if (usuario.Equals("PROGRA1") && pass.Equals("K0m1d4"))
					{
						Console.WriteLine("WELCOME");
						intentos = 4;
					}
					else 
					{
						Console.WriteLine("ERROR CREDENCIALES INVALIDAS. \n");
						intentos++;
					}
				} 
				else
				{
					Console.WriteLine("Los valores no deben quedar vacios");
				}
			}
		}
	}
}