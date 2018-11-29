 namespace Algoritmos{

    public class Algoritmos {

        public int SumaArreglo(int[] arreglo)
        {
            int suma = 0;

            for(int i = 0; i < arreglo.Length; i++)
            {
                suma += arreglo[i];
            }

            return suma;

        }

        public int CalcularMaximo(int[] arreglo)
        {

            int maximo = 0;

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] > maximo)
                {
                    maximo = arreglo[i];
                }

            }

            return maximo;
        }

    }

}