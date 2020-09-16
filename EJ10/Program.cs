using System;

namespace EJ10
{
    class Program
    {
        static void Main(string[] args)
        {
            const int añoIni = 1900, añoFin = 2015;
            int value = añoIni;

            Console.WriteLine("AÑOS BISIESTOS COMPRENDIDOS ENTRE 1900 Y 2015:");
            while (value <= añoFin)
            {
                bool esBisiesto = false;

                if (value % 400 == 0)
                {
                    esBisiesto = true;
                }

                else if ((value % 4 == 0) && (value % 100 != 0))
                {
                    esBisiesto = true;  
                }

                if (esBisiesto)
                {
                    Console.WriteLine(value);
                }

                value++;

            }
        }
    }
}
