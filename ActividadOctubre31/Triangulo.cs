namespace ActividadOctubre31 {
    public class Triangulo : Figura {

        //Uitilizamos la palabra override para sobreescribir el comportamiento de un método virtual
        //de la clase base o superclase

        public override double CalcularArea()
        {
            double area = (Base * Altura)/2;

            return area;
        }
    }

}