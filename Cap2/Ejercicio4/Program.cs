using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            float cent, fare;
            Console.WriteLine("Ingrese la cantidad en grados centigrados: ");
            cent = float.Parse(Console.ReadLine());
            fare = (cent * 9 / 5) + 32;
            Console.WriteLine($"Es igual a: {fare} grados fahrenheit");
        }
    }
}
