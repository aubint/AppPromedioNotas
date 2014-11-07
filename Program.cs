using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPromedioNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3,promedio;
            Console.WriteLine("PROMEDIO DE NOTAS!!");

            Console.WriteLine("Ingrese nota 1: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nota 2: ");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nota 3: ");
            nota3 = float.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio >= 3.0)
            {
                Console.WriteLine("PROMOCIONADO!!");
            }
            else
            {
                Console.WriteLine("PERDIO!!");
            }
            Console.ReadKey();
        }
    }
}
