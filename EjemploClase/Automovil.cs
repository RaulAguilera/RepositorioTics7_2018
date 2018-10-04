using System;

//Espacio de nombres
namespace EjemploClase
{

    //Declaracion de la clase
    //Modificador de acceso (public, private, internal, protected..)- palabra reservada class - nombre de la clase
    public class Automovil
    {
        //Atributos
        //Modificador de acceso, tipo de dato, nombre del atributo, encapsulacion
        public int VelocidadActual { get; set; }
        public string Marca { get; set; }

        public int KilometrajeActual {get;set;}

        public int KilometrajeServicio {get;set;}

        //Métodos
        //Modificador de acceso, tipo de dato de retorno, nombre del metodo, parametros, cuerpo del metodo
        public void AumentarVelocidad()
        {
            VelocidadActual = VelocidadActual + 10;
        }

        public bool NecesitaServicio()
        {
            return KilometrajeActual > KilometrajeServicio;
        }

    }

}