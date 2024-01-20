using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvGilmas2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, dlt,xn1,xn2;
            Console.Write("Digite o valor a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor c: ");
            c = Convert.ToDouble(Console.ReadLine());
            dlt = Math.Pow(b,2) - 4 * a * c;
            xn1 = (-b + Math.Sqrt(dlt)) / (2 * a);
            xn2 = (-b - Math.Sqrt(dlt)) / (2 * a);
            Console.WriteLine("Valor de dlt é: " + dlt);
            Console.WriteLine("O valor de x sendo raiz de delta positiva: " + xn1);
            Console.WriteLine("O valor de x sendo raiz de delta negativa: " + xn2);
            Console.ReadKey();
        }
    }
}
