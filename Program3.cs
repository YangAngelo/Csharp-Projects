using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu ano de nascimento : ");
            Int32 num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com o ano atual : ");
            Int32 num2 = Convert.ToInt32(Console.ReadLine());
            Int32 idd = (num2 - num1 );
            Console.WriteLine("A sua idade é : " + idd);
            Console.ReadKey();
            }
    }
}
