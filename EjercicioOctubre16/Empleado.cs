using System;

namespace EjercicioOctubre16 {
    public class Empleado : Persona{
        public double SalarioDiario {get;set;}
        public int DiasTrabajados {get;set;}

        public double CalcularQuincena()
        {
            double quincena = SalarioDiario * DiasTrabajados;

            return quincena;
        }
    }
}