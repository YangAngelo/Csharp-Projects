using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvGilmas1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r,ar,pr,d;
            Console.Write("Digite o valor do raio do seu circulo: ");
            r = Convert.ToDouble(Console.ReadLine());
            ar = Math.PI * Math.Pow(r, 2);
            d = raio * 2;
            pr = 2 * Math.PI * r;

            Console.WriteLine("Um circulo com raio de " + r + " possui os seguintes dados: ");
            Console.WriteLine("Area: " + ar);
            Console.WriteLine("Diametro:  " + d);
            Console.WriteLine("Perimetro:  " + pr);
            Console.ReadKey();
        }
    }
}
