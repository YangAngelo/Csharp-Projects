using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvGilmas4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome,nomeEmail;
            Console.Write("Digite um nome: ");
            nome = Console.ReadLine();
            nomeEmail = nome.Replace(' ', '.');
            nomeEmail = nomeEmail.ToLower();


            Console.WriteLine("Nome digitado: {0}", nome);
            Console.WriteLine("Seu email é {0}@fatec.sp.gov.br", nomeEmail);

            Console.ReadKey();
        }
    }
}
