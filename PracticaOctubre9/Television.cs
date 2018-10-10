using System;

namespace PracticaOctubre9 {
    public class Television {
        public int CanalActual {get;set;}
        public bool Encendida {get;set;}

        //Cambiar canal (no retorna valor, recibirá un parámetro nuevo canal y asignará el valor recibido 
        //al atributo canal actual)
        public void CambiarCanal(int nuevoCanal)
        {
            CanalActual = nuevoCanal;
        }

        //Boton power (no retorna valor, no recibe parámetros. Si atributl encendida tiene valor false cambiar 
        //a true y viceversa)
        public void BotonPower(){
            if(Encendida)
            {
                Encendida = false;
            }
            else{
                Encendida = true;
            }
        }

    }
}