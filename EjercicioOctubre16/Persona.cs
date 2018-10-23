using System;

namespace EjercicioOctubre16 {
    public class Persona {
        public string Nombre {get;set;}
        public string Apellido {get;set;}
        public DateTime FechaNacimiento {get;set;}

        public int CalcularEdad(){
            DateTime fechaActual = DateTime.Now;
            int anioActual = fechaActual.Year;
            int anioNacimiento = FechaNacimiento.Year;

            int edad = anioActual - anioNacimiento;
            
            return edad;
        }

    }
}