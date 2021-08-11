using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Clase_2___For_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion directa
            int[,] numeros = { { 4, 5, 6, 7, 9, 5, 8 }, { 1, 7, 8, 9, 10, 12, 15 } };

            //Ciclo For
            /*
            for (int i =0; i<7; i++)
            {
                Console.WriteLine(numeros[i]+"\n");
            }
            */

            //Doble Ciclo For
            Console.WriteLine("Doble ciclo for");
            for (int i =0; i<2; i++)
            {
                for(int j =0; j<7; j++)
                {
                    Console.WriteLine(numeros[i,j] + "\n");
                }
            }



            //Ciclo Foreach
            Console.WriteLine("Foreach");
            foreach (int n in numeros)
            {
                Console.WriteLine(n+ "\n");
            }

            Console.WriteLine("Ejecucion finalizada");
            Console.ReadKey();

        }
    }
}
