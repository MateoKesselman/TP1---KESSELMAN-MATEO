using System;

namespace EJ7
{
    class Program
    {
        static void Main(string[] args)
        {

            double n = 0, nNumerador, nDenominador, nRes, nPiSobreCuatro = 0, nPi, nPorcentaje = 0;
            int a = -1;

            while(n < 100000)
            {
                nNumerador = Math.Pow(a, n);
                nDenominador = ((2 * n) + 1);
                nRes = (nNumerador / nDenominador);
                nPiSobreCuatro = nPiSobreCuatro + nRes;
                n++;
            }

            nPi = (nPiSobreCuatro * 4);
            nPorcentaje = ((nPi * 100) / Math.PI);
            Console.WriteLine("VALOR CALCULADO APROXIMADO DE PI CON LA FORMULA DE LEIBNIZ: " + Math.Round(nPi, 5));
            Console.WriteLine("COMPARACIÓN EN TÉRMINOS PORCENTUALES CON MATH.PI: " + Math.Round(nPorcentaje, 5) + "%");
        }
    }
}