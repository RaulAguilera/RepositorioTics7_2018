using System;

namespace EjemploNoviembre14_Sobrecarga {

public class Saludos {

    public void Saludar()
    {
        Console.WriteLine("Hola");

    }

    //Sobrecarga del metodo saludar pero que ahora recibe un parámetro del tipo string.
    public void Saludar(string nombre){

        Console.WriteLine("Hola " + nombre);

    }
    //Sobrecarga del metodo saludar pero que recibe un parametro del tipo int
    public void Saludar(int cantidad)
    {
        for(int i = 0; i < cantidad; i++)
        {
            Console.WriteLine("Hola");
        }
    }


}

}