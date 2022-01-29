using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            float peso, dolar = 57.75f, euro = 66.18f, total;
            char opcion;

            Console.WriteLine("Ingrese que el numero de la opción. Ojo: Sólo el numero.");
            Console.WriteLine("1-Dolar a peso.");
            Console.WriteLine("2-Euro a peso.");
            Console.Write("Opción: ");
            opcion = char.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad:");
            peso = float.Parse(Console.ReadLine());
            if (opcion == '1')
            {
                total = peso * dolar;
            }
            else
            {
                total = peso * euro;
            }
            Console.WriteLine($"La equivalencia es igual a: {total} pesos.");
        }
    }
}
