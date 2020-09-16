using System;
using System.Linq;

namespace EJ13
{
    class Program
    {
        static void Main(string[] args)
        {
            //ASIGNO PARÁMETROS A VARIABLES PARA PODER MANIPULARLAS
            string cad1 = args[0], cad2 = args[1], cad3 = args[2], cad4 = args[3], cad5 = args[4];

            //CREO VARIABLES PARA PODER INVERTIR LAS CADENAS
            string cad1Invert = "", cad2Invert = "", cad3Invert = "", cad4Invert = "", cad5Invert = "";

            //INVIERTO CADENAS          

                //RECORRER LETRA POR LETRA  
                foreach (char letra in cad1)
                {
                    //ANTEPONER LA LETRA A LA CADENA INVERTIDA
                    cad1Invert = letra + cad1Invert;
                }

                foreach (char letra in cad2)
                {
                    cad2Invert = letra + cad2Invert;
                }

                foreach (char letra in cad3)
                {
                    cad3Invert = letra + cad3Invert;
                }

                foreach (char letra in cad4)
                {
                    cad4Invert = letra + cad4Invert;
                }

                foreach (char letra in cad5)
                {
                    cad5Invert = letra + cad5Invert;
                }

            //ARMO ARREGLO DE CADENAS INVERTIDAS
            string[] arrayInvertido = { cad1Invert, cad2Invert, cad3Invert, cad4Invert, cad5Invert };

            //CREO UN COMPARADOR QUE ORDENA DE MANERA DESCENDENTE
            Comparison<string> comparador = new Comparison<string>((cadena1, cadena2) => cadena2.CompareTo(cadena1));

            //LLAMO A ARRAY.SORT PASANDOLE EL ARREGLO A ORDENAR DESCENDENTEMENTE Y EL COMPARADOR
            Array.Sort<string>(arrayInvertido, comparador);

            Console.WriteLine("CADENAS INVERTIDAS ORDENADAS DESCENDENTEMENTE:");
            //IMPRIMO POR PANTALLA LAS CADENAS INVERTIDAS ORDENADAS DESCENDENTEMENTE
            foreach (string cad in arrayInvertido)
            {
                Console.Write(cad + " ");
            }
        }
    }
}
