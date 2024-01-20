using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c,delta;
            Console.Write("Digite o valor a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor c: ");
            c = Convert.ToDouble(Console.ReadLine());
            delta = (b * b) - (4 * a * c);
            Console.Write("Valor de Delta é: " + delta);     
            Console.ReadKey();

        }
    }
}
