using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double an, ms, ds, tid;
            Console.WriteLine("Entre com quanto anos voce tem : ");
            an = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre com quantos meses voce tem");
            ms = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre com quantos dias voce tem");
            ds = Convert.ToDouble(Console.ReadLine());
            tid = (an * 365) + (ms * 30) + ds;
            Console.WriteLine("A sua idade em dias é : " + tid);
            Console.ReadKey();
        }
    }
}
