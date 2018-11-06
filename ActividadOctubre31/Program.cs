using System;

namespace ActividadOctubre31
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura f1 = new Cuadrado();
            f1.Base = 5;
            f1.Altura = 5;

            Console.WriteLine("Area f1: " + f1.CalcularArea());

            Figura f2 = new Rectangulo();
            f2.Base = 3;
            f2.Altura = 4;

            Console.WriteLine("Area f2: " + f2.CalcularArea());

            Figura f3 = new Triangulo();
            f3.Base = 4;
            f3.Altura = 3;

            Console.WriteLine("Area f3: "+ f3.CalcularArea());

            Console.ReadKey();
        }
    }
}
