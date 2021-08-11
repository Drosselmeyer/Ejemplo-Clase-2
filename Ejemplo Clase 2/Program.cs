using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Clase_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //If sencillo
            //Declaramos el numero a solicitar
            int numero = 0;
            //Declaro la string donde imprimire el mensaje
            string mensaje = "";

            //Solicitamos el numero al usuario
            Console.WriteLine("Ingrese un numero entero");
            numero = int.Parse(Console.ReadLine());

            //Comparamos si el numero es par con el operador modulo y generamos el mensaje
            /*
            if (numero%2 == 0)
            {
                mensaje = "El numero " + numero + " es par";
            }
            else
            {
                mensaje = "El numero " + numero + " no es par";
            }
            */

            //Operador ternario
            mensaje = (numero%2 == 0) ? "El numero " + numero + " es par" : "El numero " + numero + " no es par";

            Console.WriteLine(mensaje);
            Console.ReadKey();
        }
    }
}
