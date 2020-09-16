using System;
using System.Linq;

namespace EJ16
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARACIÓN DE VARIABLES Y ASIGNACIÓN DE LAS CADENAS QUE SE INGRESAN POR TECLADO
              Console.WriteLine("INGRESE PRIMER CADENA:");
              string cadena1 = Console.ReadLine();
              Console.WriteLine("INGRESE SEGUNDA CADENA:");
              string cadena2 = Console.ReadLine();

            //PASO A MAYÚSCULA LAS CADENAS
            string cad1 = cadena1.ToUpper();
            string cad2 = cadena2.ToUpper();

            //PARA ORDENAR ALFABÉTICAMENTE LAS CADENAS

            //CONVIERTO LAS CADENAS EN ARREGLOS DE CARACTERES
            char[] cad1Array = cad1.ToArray();
                char[] cad2Array = cad2.ToArray();

                //ORDENO LOS ARREGLOS
                Array.Sort(cad1Array);
                Array.Sort(cad2Array);

                //CONVIERTO LOS ARREGLOS DE CARACTERES EN CADENAS NUEVAMENTE PERO ESTA VEZ YA ORDENADAS ALFABETICAMETE
                string cad1Ord = new string(cad1Array);
                string cad2Ord = new string(cad2Array);

            //SI LAS CADENAS ORDENAS ALFABETICAMENTE SON IGUALES QUIERE DECIR QUE LAS CADENAS INGRESADAS POR TECLADO SON ANAGRAMAS
            if (cad2Ord == cad1Ord)
            {
                Console.Clear();
                Console.WriteLine(cad1 + " Y " + cad2 + " SON ANAGRAMAS");
            }
            else
            {
                Console.Clear();
                Console.WriteLine(cad1 + " Y " + cad2 + " NO SON ANAGRAMAS");
            }


        }
    }
}

/* 16.Desarrolle una aplicación que permita ingresar dos cadenas de
    caracteres por teclado, determine si son anagramas y escriba
    el resultado de dicha comprobación por consola.*/