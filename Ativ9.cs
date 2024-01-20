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
            double n1, n2, n3,media;
            Console.Write("Digite o valor da nota 1: ");
            n1 = Conver.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor da nota 2: ");
            n2 = Conver.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor da nota 3: ");
            n3 = Conver.ToDouble(Console.ReadLine());
            media = (n1 * 2 + n2 * 3 + n3 * 5) / 10;
            Console.Write("Sua media é: " + media);     
            Console.ReadKey();

        }
    }
}
