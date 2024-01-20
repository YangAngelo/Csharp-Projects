using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvGilmas3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nm, primeiro_nm, sobr_nm,subString,subApO;
            int index;
            Console.Write("Digite seu nm: ");
            nm = Console.ReadLine();
            index = nm.IndexOf(' ');
            primeiro_nm = nm.Substring(0, index);
            sobr_nm = nm.Substring(index);
            subString = nm.Substring(5, 10);
            subApO = nm.Replace('a', 'o');
            Console.WriteLine("Seu nome é: " + nm);
            Console.WriteLine("Seu primeiro nome é: " + primeiro_nm);
            Console.WriteLine("Seu sobrenome é: " + sobr_nm);
            Console.WriteLine("Os caracteres de 5 a 10 do seu nome são: " + subString);
            Console.WriteLine("Seu nome substituindo as letras a pela letra o: " + subApO);
            Console.ReadKey();
        }
    }
}
