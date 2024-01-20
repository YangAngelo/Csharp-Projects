using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEntre com a primeira nota : ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEntre com a segunda nota : ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEntre com a terceira nota : ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double md = (num3 + num2 +  num1) / 3;
            Console.WriteLine("A media da nota/numeros digitados é : " + md);
            Console.ReadKey();

        }
    }
}
