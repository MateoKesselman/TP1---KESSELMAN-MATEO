using System;

namespace EJ5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int limInf = 5;
            const int limSup = 100;
            int nCont = 0, sumaTotal = 0, value = limInf;

            do
            {
                nCont = nCont + 1;
                sumaTotal = sumaTotal + value;
                value++;
            } while (value <= limSup);
            Console.WriteLine("LA SUMA DE LOS NÚMEROS ENTRE " + limInf + " Y " + limSup + " ES: " + sumaTotal);
            Console.WriteLine("EL PROMEDIO DE LOS NÚMEROS ENTRE " + limInf + " Y " + limSup + " ES: " + (float)sumaTotal / (float)nCont);
        }
    }
}
