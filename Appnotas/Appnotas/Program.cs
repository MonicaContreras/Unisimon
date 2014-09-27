using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appnotas
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, promedio;
            Console.WriteLine("programa promedio 3 notas");
            Console.WriteLine("Digite nota 1:");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota 2:");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota 3:");
            nota3 = float.Parse(Console.ReadLine());
            promedio = (nota1 + nota2 + nota3) / 3;
            if (promedio >= 3.5)
            {
                Console.WriteLine("ES PROMOCIONADO DEL DIPLOMADO:");
            }
            else
            {
                Console.WriteLine("NO ES PROMOCIONADO DEL DIPLOMADO:");
            }
            Console.ReadKey();
                    }
    }
}
