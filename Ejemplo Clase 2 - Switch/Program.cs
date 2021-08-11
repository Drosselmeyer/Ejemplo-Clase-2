using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Clase_2___Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos la variable del menu
            char menu = 'z';
            //Declaramos la string para el menu
            string mensajeMenu = "";
            string mensajeSalida = "";

            //Creamos el menu para imprimirlo
            mensajeMenu = "Bienvenidos, este es el menu del banco\n" +
                          "a. Revisar cuenta de ahorros\n" +
                          "b. Depositar dinero a la cuenta\n" +
                          "c. Retirar dinero de la cuenta\n\n" +
                          "Ingrese la opcion que desea realizar";
            Console.WriteLine(mensajeMenu);

            //Leemos la opcion solicitada
            menu = char.Parse(Console.ReadLine());

            //Menu, hecho con if else
            /*
            if (menu == 'a')
            {
                mensajeSalida = "Su cuenta tiene $1200";
            }
            else if (menu == 'b')
            {
                mensajeSalida = "Usted a depositado $400";
            }
            else if (menu == 'c')
            {
                mensajeSalida = "Usted a retirado $200";
            }
            else
            {
                mensajeSalida = "Opción no valida, gracias por usar el sistema";
            }
            */
            //Menu resuelto con Switch
            switch (menu)
            {
                case 'a':
                    mensajeSalida = "Su cuenta tiene $1600";
                    break;
                case 'b':
                    mensajeSalida = "Usted a depositado $560";
                    break;
                case 'c':
                    mensajeSalida = "Usted a retirado $2300";
                    break;
                default:
                    mensajeSalida = "Opción no valida";
                    break;
            }

            Console.WriteLine(mensajeSalida);
            Console.ReadKey();
        }
    }
}
