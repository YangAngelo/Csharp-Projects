using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Aula01_09_23
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Entre com o numero que voce quer verificar");
            double num1= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("O antecessor do seu numero é : " + (num1 - 1));
            Console.ReadKey();
        }
    }
}
