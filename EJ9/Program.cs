using System;
using System.Diagnostics.CodeAnalysis;

namespace EJ9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 35, valorFin = 1977, suma = 0;     
            
            while (n <= valorFin)
            {
                bool esPrimo = true;

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }

                }

                if (esPrimo)
                {
                    suma = suma + n;
                }

                n++;
            }
            Console.WriteLine("LA SUMA DE LOS NÚMEROS PRIMOS COMPRENDIDOS ENTRE 35 Y 1977 ES: " + suma);


        }
    }
}
