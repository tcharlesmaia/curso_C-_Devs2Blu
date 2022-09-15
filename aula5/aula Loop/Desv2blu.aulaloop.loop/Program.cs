using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Desv2blu.aulaloop.loop
{
    internal class Program
    {
        static void Main(string[] args)
        { int senha = 0;
            do
            {
                
                Console.WriteLine("Digite 1 para exercício de pares \nDigite 2 para exercício de ímpares \nDigite 3 para valores até o valor aleatório \nDigite 4 para exercício da nota ou 0 para sair");
                
                senha = int.Parse(Console.ReadLine());

                switch (senha)
                {
                    case 1:
                        par_();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        impar();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        impar_par();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.ReadLine();
                        Console.Clear();
                        Media_alunos();
                        break;

                }
            } while (senha != 0);
            
        }

        static void impar()
        {
            int a;
            a = 1;
            while (a < 100)
            {
                if (a - ((a / 2) * 2) != 0)
                {
                    Console.WriteLine(a);
                }

                a = a + 1;

            }
        }
        static void par_()
        {
            int a;
            a = 1;
            while (a < 100)
            {
                if (a - ((a / 2) * 2) == 0)
                {
                    Console.WriteLine(a);
                }

                a = a + 1;

            }
        }
        static void impar_par()
        {
            int a;
            int b;
            b = 1;
            Random numero = new Random();
            a = numero.Next(0, 100);
            do           
            {
                /*if (a - ((a / 2) * 2) != 0)
                {
                    Console.WriteLine(a);
                }*/
                Console.WriteLine(b);

                b = b + 1;

            } while (b < a);
        }
        static void Media_alunos()
        {
            Console.WriteLine("*************************** Média das notas dos alunos ***********************");
            Console.WriteLine("Digite quantos alunos tem na turma: ");
            int alunos=int.Parse(Console.ReadLine());

            int aluno = 1;
            int nota = 0;
            do
            {
               Console.WriteLine($"Digite a nota do aluno: {aluno}");
                
               nota += int.Parse(Console.ReadLine());

                aluno = aluno + 1;
            } while (aluno != alunos+1);
            Console.WriteLine($"A média das notas da turma ficou em: {nota/alunos}");

        }
    }

}
