using System;

namespace EJ11
{
    class Program
    {
        static void Main(string[] args)
        {
            double nRadio, nRadioCuadrado;
            Console.WriteLine("INGRESE RADIO DEL CÍRCULO:");
            nRadio = int.Parse(Console.ReadLine());
            nRadioCuadrado = Math.Pow(nRadio,2);
            Console.Clear();
            Console.WriteLine("ÁREA: " + (Math.Round((Math.PI * nRadioCuadrado),5)));
            Console.WriteLine("PERÍMETRO DE LA CIRCUNSFERENCIA: " + (Math.Round(((Math.PI * 2) * nRadio),5)));      
        }
    }
}