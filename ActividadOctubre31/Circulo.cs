using System;

namespace ActividadOctubre31 {
public class Circulo {

    public double Radio {get;set;}

    public override double CalcularArea()
    {
        double area = Math.PI + (Radio * Radio);    

        return area;

    }

}


}