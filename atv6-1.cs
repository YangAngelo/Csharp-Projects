using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv2_aula01_09_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bs, al, ar;
            Console.WriteLine("Entre com a base a base do retangulo");
            bs = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre com a altura do retangulo");
            al = Convert.ToDouble(Console.ReadLine());
            ar = bs * al;
            Console.WriteLine("A area do seu retangulo é : " + ar);
            Console.ReadKey();

        }
    }
}
