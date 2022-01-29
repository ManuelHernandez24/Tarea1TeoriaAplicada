using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float grados, rad;
            Console.WriteLine("Ingrese la cantidad de grados: ");
            grados = float.Parse(Console.ReadLine());
            rad = grados * (3.1416f/180f);
            Console.WriteLine($"Es igual a: {rad} rad");
        }
    }
}
