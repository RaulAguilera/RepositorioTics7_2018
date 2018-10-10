using System;

namespace PracticaOctubre9
{
    class Program
    {
        static void Main(string[] args)
        {
            Television tv1 = new Television();

            Console.WriteLine("Encendida? " + tv1.Encendida);
            Console.WriteLine("Canal Actual: " + tv1.CanalActual);

            tv1.CambiarCanal(15);
            tv1.BotonPower();

            Console.WriteLine("Encendida? " + tv1.Encendida);
            Console.WriteLine("Canal Actual: " + tv1.CanalActual);

            tv1.CambiarCanal(26);
            tv1.BotonPower();

            Console.WriteLine("Encendida? " + tv1.Encendida);
            Console.WriteLine("Canal Actual: " + tv1.CanalActual);

            Console.ReadKey();
        }
    }
}
