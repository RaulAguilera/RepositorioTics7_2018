namespace ClasesAbstractas_Interfaces
{
    public class Cuadrado : IFiguraGeometrica{

        public double Lado {get;set;}

        public double CalcularPerimetro()
        {
            return Lado * 4;
        }

        public double CalcularArea()
        {
            return Lado * Lado;
        }

    }
}