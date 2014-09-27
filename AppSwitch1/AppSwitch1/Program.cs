using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSwitch1
{
    class Program
    {
        static void Main(string[] args)
        {
             string numero;
            Console.WriteLine("programa que pasa de caracter a numero");
            Console.WriteLine("escriba un numero del 1 al 5 en numeros");
            numero=Console.ReadLine();
                       
            switch(numero)
            {
                case "1":
                    Console.WriteLine("UNO");
                    break;
                case "2":
                    Console.WriteLine("DOS");
                    break;
                case "3":
                    Console.WriteLine("TRES");
                    break;
                case "4":
                    Console.WriteLine("CUATRO");
                    break;
                case "5":
                    Console.WriteLine("CINCO");
                    break;

                default:
                    Console.WriteLine("numero fuera de rango");
                    break;
            }

            Console.ReadKey();
        }

    }
}

  