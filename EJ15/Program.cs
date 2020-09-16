using System;

namespace EJ15
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONSTANTES
            const int limInf = 300, limSup = 700;

            //ARREGLO DE 50 NÚMEROS ENTEROS
            int[] array1 = new int[50];

            //VARIABLE RANDOM
            Random aleatorio = new Random();

            //BUCLE FOR PARA INICIALIZAR EL ARREGLO CON NÚMEROS ENTEROS ALEATORIOS DE 1 A 1000
            for (int i = 0; i < 50; i++)
            {
                array1[i] = aleatorio.Next(0, 1000) + 1;
            }

            //CREAR UN COMPARADOR QUE ORDENA DE MANERA ASCENDENTE
            Comparison<int> comparador = new Comparison<int>((numero1, numero2) => numero1.CompareTo(numero2));

            //LLAMAR A ARRAY.SORT PASANDO EL ARREGLO A ORDENAR Y EL COMPARADOR
            Array.Sort<int>(array1, comparador);

            //IMPRIMO POR PANTALLA LOS VALORES DEL ARREGLO ORDENADOS ASCENDENTEMENTE COMPRENDIDOS ENTRE 300 Y 700
            Console.WriteLine("VALORES DEL ARREGLO ORDENADO EN FORMA ASCENDENTE COMPRENDIDOS ENTRE " + limInf + " Y " + limSup);

            for (int i = 0; i < 50; i++)
            {
                if ((array1[i] >= limInf) && (array1[i] <= limSup))
                Console.WriteLine(array1[i] + " ");
            }
        }
    }
}