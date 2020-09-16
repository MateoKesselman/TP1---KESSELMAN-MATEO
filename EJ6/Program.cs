using System;

namespace EJ6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumaTotal = 0, nCont = 0;

            for (int value = 1; value <= 100; value++)
            {
                if ((value % 2) != 0) //si es número impar
                {
                    nCont = (nCont+1);
                    sumaTotal = sumaTotal + value;
                }       
           }
            Console.WriteLine("LA SUMA DE LOS NÚMEROS IMPARES ENTRE 1 Y 100 ES: " + sumaTotal);
            Console.WriteLine("EL PROMEDIO DE LOS NÚMEROS IMPARES ENTRE 1 Y 100 ES: " + (float)sumaTotal / (float)nCont);

        }
    }
}

