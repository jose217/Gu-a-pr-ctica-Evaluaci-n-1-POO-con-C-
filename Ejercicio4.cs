using System;

namespace Ejercicio4
{
    internal class Ejercicio4
    {
        static void Main(string[] args)
        {
            /**
             Cree un programa que solicite un rango de años e imprima en pantalla los años
             que son bisiestos dentro de ese rango establecido.
             ¿Cómo saber si un año es bisiesto?
             ➢ Todos los años bisiestos son divisibles entre 4.
             ➢ Aquellos años que son divisibles entre 4, pero no entre 100, son bisiestos.
             ➢ Los años que son divisibles entre 100, pero no entre 400, no son bisiestos.
             ➢ Sin embargo, los años divisibles entre 100 y entre 400 sí que son bisiestos.
             */

            int aniosa = 0;
            int aniosb = 0;

            Console.WriteLine("Digite el año inicial:");
            aniosa = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el año final: ");
            aniosb = int.Parse(Console.ReadLine());

            Console.WriteLine("Años biciestros entre: {0} y {1}", aniosa, aniosb);

            for(int i = aniosa;  i < aniosb; i++) {
                if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0) { 
                    Console.WriteLine(i);
                }
            }
        }
    }
}