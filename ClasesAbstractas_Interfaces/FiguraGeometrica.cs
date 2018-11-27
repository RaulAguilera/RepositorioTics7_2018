namespace ClasesAbstractas_Interfaces {

public abstract class FiguraGeometrica{
    //Una clase abstracta nos permite crear una combinacion de metodos con definicion y metodos
    //abstractos, los métodos abstractos deberán ser "sobreescritos" en las clases derivadas
    //Es importante tener en cuenta que NO es posible crear una instancia de una clase abstracta.

public double Base {get;set;}
public double Altura {get;set;}

public double CalcularPerimetro()
{
    return Base * 2 + Altura * 2 ;
}

public abstract double CalcularArea();

}
}