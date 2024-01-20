using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*2 – Crie um programa que permita ao usuário entrar com dois números. Executar as quatro operações com esses dois números (Soma, Subtração, multiplicação, divisão).
 * Não se esquecer de mostrar as respostas na tela.
    namespace atv2*/

    namespace calculos
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Digita o 1o numero: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digita o 2o numero: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                double soma = (num1 + num2);
                double sub = (num1 - num2);
                double mult = (num1 * num2);
                double div = (num1 / num2);
                Console.WriteLine("A soma é igual a :" + soma);
                Console.WriteLine("A subtração é igual a :" + sub);
                Console.WriteLine("A multiplicação é igual a :" + mult);
                Console.WriteLine("A divisão é igual a :" + div);
                Console.ReadKey();         

            }
        }
    }
