using System;

namespace EJ12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, nResultado = 0;

            Console.WriteLine("INGRESE NÚMERO DEL CUAL DESEA CALCULAR FACTORIAL: ");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.Clear();
                nResultado = num;
                for (int i = 1;i < num; i++)
                {
                    nResultado = (nResultado * i);
                }
                Console.WriteLine("EL FACTORIAL DE " + num + " ES " + nResultado);
            }
            else if (num == 0)
            {
                Console.Clear();
                Console.WriteLine("EL FACTORIAL DE 0 ES 1");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("NO SE PUEDE CALCULAR EL FACTORIAL DE UN NÚMERO NEGATIVO");
            }
        }
    }
}