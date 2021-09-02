using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pa_calculando_area_trapezio
{
    class Program
    {
        static void Main(string[] args)
        {
            double basemaior, basemenor, h, total;

            Console.WriteLine("Qual o tamanho da base maior em centímetros?: ");
            basemaior = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o tamanho da base menor em centímetros: ");
            basemenor = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual altura em centímetros: ");
            h = double.Parse(Console.ReadLine());


            total = ((basemaior + basemenor) * h) / 2;

            Console.WriteLine("A área do trapézio é de " + Math.Round(total, 2) + "cm² !");

            Console.ReadKey();
        }
    }
}
