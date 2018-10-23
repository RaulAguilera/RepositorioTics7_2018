using System;

namespace EjercicioOctubre16
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();

            p1.Nombre = "Juanito";
            p1.Apellido = "Perez";
            p1.FechaNacimiento = new DateTime(1990, 1, 1);

            int edad = p1.CalcularEdad();

            Console.WriteLine("Nombre: " + p1.Nombre);
            Console.WriteLine("Apellido: " + p1.Apellido);
            Console.WriteLine("Edad: " + edad);


            Empleado e1 = new Empleado();
            e1.Nombre = "Empleado1";
            e1.Apellido = "Empleado1";
            e1.FechaNacimiento = new DateTime(2000,9,15);

            int edadE1 = e1.CalcularEdad();

            e1.SalarioDiario = 200.0;
            e1.DiasTrabajados = 5;

            double quincena = e1.CalcularQuincena();

            Console.WriteLine("Nombre: " + e1.Nombre);
            Console.WriteLine("Apellido: " + e1.Apellido);
            Console.WriteLine("Edad: " + edadE1);
            Console.WriteLine("Quincena: " + quincena);

            Console.ReadKey();
        }
    }
}
