using System;

namespace EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNumero = 0;
            Console.WriteLine("INTRODUZCA NÚMERO:");
            nNumero = int.Parse(Console.ReadLine());
            
            if (nNumero == 1)
            {
                Console.Clear();
                Console.WriteLine("UNO");
            }
            else if (nNumero == 2)
            {
                Console.Clear();
                Console.WriteLine("DOS");
            }
            else if (nNumero == 3)
            {
                Console.Clear();
                Console.WriteLine("TRES");
            }
            else if (nNumero == 4)
            {
                Console.Clear();
                Console.WriteLine("CUATRO");
            }
            else if (nNumero == 5)
            {
                Console.Clear();
                Console.WriteLine("CINCO");
            }
            else if (nNumero == 6)
            {
                Console.Clear();
                Console.WriteLine("SEIS");
            }
            else if (nNumero == 7)
            {
                Console.Clear();
                Console.WriteLine("SIETE");
            }
            else if (nNumero == 8)
            {
                Console.Clear();
                Console.WriteLine("OCHO");
            }
            else if (nNumero == 9)
            {
                Console.Clear();
                Console.WriteLine("NUEVE");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("OTROS");
            }
        }
    }
}

           