using System;

namespace EJ14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable para acumular los valores de los números del arreglo
            double suma = 0;

            //Arreglo de 30 números reales de doble presición
            double[] array1 = new double[30];

            //Variables para hallar el número máximo y el número mínimo en el arreglo
            double min = 100, max = 0;

            //Variable random
            Random aleatorio = new Random();

            Console.WriteLine("ELEMENTOS DEL ARREGLO:");

         /* Bucle para:
            Inicializar el arreglo con números aleatorios de 1 a 1000.
            Hallar SUMA (para luego obtener también el PROMEDIO), MINIMO y MÁXIMO de los números del arreglo */

            for (int i = 0; i < 30; i++)
            {
                array1[i] = aleatorio.Next(0, 1000) + 1;
               
                suma = suma + array1[i];


                if (array1[i] < min)
                {
                    min = array1[i];
                }

                if (array1[i] > max)
                {
                    max = array1[i];
                }

                Console.Write(array1[i] + " ");
            }

            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("SUMA DE LOS ELEMENTOS DEL ARREGLO: " + suma);
            Console.WriteLine("PROMEDIO DE LOS ELEMENTOS DEL ARREGLO: " + (Math.Round((suma / 30),3)));
            Console.WriteLine("MÍNIMO ELEMENTO DEL ARREGLO: " + min);
            Console.WriteLine("MÁXIMO ELEMENTO DEL ARREGLO: " + max);

        }
    }
}
