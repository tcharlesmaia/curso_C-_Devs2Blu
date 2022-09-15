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
            int a;
            string b, d;
            const int c = 1234;
            Console.WriteLine("************Validação para loging************");
            Console.WriteLine("Digite sua senha de 4 dígitos:");
            b = Console.ReadLine();
            a = int.Parse(b);
            d = (a == c) ? "ACESSO PERMITIDO!" : "ACESSO NEGADO!";
            Console.WriteLine(d);
        }
    }
}
