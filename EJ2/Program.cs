using System;

namespace EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNumero = 0;
            Console.WriteLine("INTRODUZCA NÚMERO:");
            nNumero = int.Parse(Console.ReadLine());

            switch (nNumero)
            {            
                case 1:
                    Console.Clear();
                    Console.WriteLine("UNO");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("DOS");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("TRES");
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("CUATRO");
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("CINCO");
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("SEIS");
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("SIETE");
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("OCHO");
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("NUEVE");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("OTROS");
                    break;
            }
        }
    }
}
