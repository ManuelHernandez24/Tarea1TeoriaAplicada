using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            float perimetro, lado;
            Console.Write("Ingrese la longitud de un lado: ");
            lado = float.Parse(Console.ReadLine());
            perimetro = lado * 6;
            Console.WriteLine($"El perimetro es: {perimetro}" );
        }
    }
}
