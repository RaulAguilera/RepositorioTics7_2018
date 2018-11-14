using System;

namespace EjemploNoviembre14_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Saludos s1 = new Saludos();

            s1.Saludar();
            s1.Saludar("Raul");
            s1.Saludar(5);

            Console.ReadKey();
        }
    }
}
