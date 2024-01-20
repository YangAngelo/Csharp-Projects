using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvGilmas5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nm,prm_nm, ultimo_nm, nmEmail;
            int index_nm, index2_nm;
            Console.Write("Digite um nome: ");
            nm = Console.ReadLine();
            index_nm = nm.IndexOf(' ');
            index2_nm = nm.LastIndexOf(' ');
            prm_nm = nm.Substring(0, index_nm);
            ultimo_nm = nm.Substring(index2_nm);
            nmEmail = prm_nm + ultimo_nm;
            nmEmail = nmEmail.Replace(' ', '.');
            nmEmail = nmEmail.ToLower();

            Console.WriteLine("Nome digitado: " + nm);
            Console.WriteLine("Seu email é " + nmEmail +"@fatec.sp.gov.br");

            Console.ReadKey();
        }
    }
}
