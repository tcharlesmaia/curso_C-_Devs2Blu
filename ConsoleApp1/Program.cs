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
            string a;
            a = Console.ReadLine();
            Console.WriteLine($"***{a}***");
            if (a.Equals(""))
            {
                Console.WriteLine("4564");
            }
        }
        static void exerc1()
        {
            int a, b;
            Console.WriteLine("digite um número e na sequencia digite outro número");
            if ((a = int.Parse(Console.ReadLine())) > (b = int.Parse(Console.ReadLine())))
            {
                Console.WriteLine($"o maior número digitado foi: {a}");
            }
            else
            {
                Console.WriteLine($"o maior número digitado foi: {b}");
            }

        }
        static void exemplo()
        {
            string nomeUser, txt_saida;
            int n_idade, n_nota;
            Console.WriteLine("|************ Desv2Blu**********");
            Console.WriteLine("Digite o nome do candidato \n");
            nomeUser = Console.ReadLine();
            Console.WriteLine("Digite a idade do candidato");
            n_idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do candidato");
            n_nota = int.Parse(Console.ReadLine());

            if (n_idade.Equals(""))
            {
                Console.WriteLine("Idade inválida");
                return;
            }
            if (n_nota.Equals(""))
            {
                Console.WriteLine("Idade inválida");
                return;
            }
            txt_saida = $"Candidato: {nomeUser}\n";
            txt_saida += $"Idade: {n_idade}\n";

            if (n_idade < 18)
            {
                txt_saida += "Menor de idade";
            }
            else
            {
                txt_saida += "Maior de idade";
            }
            if (n_nota < 6)
            {
                txt_saida += @"
********
Reprovado
*********";
            }
            else
            {
                txt_saida += @"
********
Aprovado
********";
            }
            Console.WriteLine(txt_saida);

        }
    }
}
