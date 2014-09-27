using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNumPositivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;
            int num;
            
            Console.WriteLine("Programa de Numero Positivos");
            Console.WriteLine("Digite un Numero entre 1 y 99");
            numero = Console.ReadLine();
            num = int.Parse(numero);
            if (numero.Length <= 2 && num > 0)
            {
                Console.WriteLine("el numero es positivo");
                if (numero.Length == 2)
                {
                    Console.WriteLine("el numero tiene dos digitos");
                }
                else
                {
                    Console.WriteLine("el numero tiene un digito");
                }
            }
            else
            {
                Console.WriteLine("numero fuera de rango");
            }

            Console.ReadKey();
        }
    }
}
