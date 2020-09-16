using System;

namespace EJ8
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong a, b, nAux;
            const int nLimite = 50;

            Console.WriteLine("LOS PRIMEROS 50 ELEMENTOS DE LA SERIE DE FIBONACCI SON:");
    
            a = 0;
            b = 1;
            for (int i = 0; i < nLimite; i++)
            {
                Console.WriteLine(a);
                nAux = a;
                a = b;
                b = nAux + a;
            }
            Console.ReadKey();
        }
    }
}
