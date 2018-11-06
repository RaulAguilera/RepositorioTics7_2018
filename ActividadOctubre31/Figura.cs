namespace ActividadOctubre31 {
    public class Figura {

        public double Base {get;set;}
        public double Altura {get;set;}

        //Se indica que el metodo es virtual para permitir su sobreescritura en una subclase
        public virtual double CalcularArea()
        {
            double area = Base * Altura;
            return area;
        }
    }
}