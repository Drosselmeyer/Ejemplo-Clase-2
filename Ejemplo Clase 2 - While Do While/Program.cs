using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Clase_2___While_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable para solicitar numero
            int numero = 0;
            //Variable para bandera
            int i = 1;

            //Solicitamos el numero al usuario
            Console.WriteLine("Ingrese el numero mayor que desea ver en pantalla");

            //Leemos la informacion y la guardamos
            numero = int.Parse(Console.ReadLine());

            //Ciclo While
            Console.WriteLine("Ejecucion con while");
            while (i <= numero)
            {
                Console.WriteLine(i);
                i++;
            }

            i = 1;
            //Ciclo Do-While
            Console.WriteLine("Ejecucion con do while");
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= numero);

            Console.WriteLine("Ejecucion finalizada");
            Console.ReadKey();
        }
    }
}
