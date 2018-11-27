using System;

namespace Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            Algoritmos a = new Algoritmos();

            int[] arreglo = new int[]{5,7,2,4,9,10};

            int suma = a.SumaArreglo(arreglo);

            Console.WriteLine("La suma es: " + suma);

            Console.ReadKey();

        }
    }
}
