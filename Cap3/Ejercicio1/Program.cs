using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean par;
            int numero;
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            par = numero % 2 == 0 ? true : false;
            Console.Write("El numero es ");
            Console.Write(par == true ? "par" : "impar.");

        }
    }
}
