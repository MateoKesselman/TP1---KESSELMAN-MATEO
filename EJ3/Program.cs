using System;

namespace EJ3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int limInf = 5;
            const int limSup = 100;
            int nCont = 0;
            int sumaTotal = 0;

            for (int value = limInf; value <= limSup; value++)
            {
                nCont++;
                sumaTotal = sumaTotal + value;               
            }
            Console.WriteLine("LA SUMA DE LOS NÚMEROS ENTRE " + limInf + " Y " + limSup + " ES: "  + sumaTotal);
            Console.WriteLine("EL PROMEDIO DE LOS NÚMEROS ENTRE " + limInf + " Y " + limSup + " ES: " + (float)sumaTotal / (float)nCont);
        }
    }
}
