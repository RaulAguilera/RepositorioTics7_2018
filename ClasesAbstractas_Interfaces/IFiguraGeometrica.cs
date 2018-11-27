namespace ClasesAbstractas_Interfaces
{
    public interface IFiguraGeometrica
    {
        //Una interfaz nos permite definir las firmas de una serie de metodos que deberán ser implementados
        //por las clases que implementen lainterfaz en cuestion.
        double CalcularPerimetro();
        double CalcularArea();
    }
}