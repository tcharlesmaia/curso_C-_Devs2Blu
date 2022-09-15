using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exrci_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio3();
        }
        static void Exercicio2()
        {
            Console.WriteLine("********************** Exercício concessionária *********************");
            Console.WriteLine("Digite o modelo de automóvel que deseja, Hatch, Sedam");
            string modelo;
            modelo = Console.ReadLine();
            switch (modelo.ToUpper())
            {
                case "HATCH":
                    Console.WriteLine("Você escolheu Hatch");
                    break;
                case "SEDAM":
                    Console.WriteLine("Você escolheu Sedam");
                    break;

                default:
                    Console.WriteLine("Entrada inválida!!!");
                    break;
            }

        }
        static void Exercicio3()
        {
            Console.WriteLine("********************** Game Play 21 *********************");
            Console.WriteLine("Vamos jogar, o objetivo é que você e o computador cheguem o mais próximo de 21 pontos, vamos começar.... Digite qualquer valor entre 0 e 20");
            int num, aa, bb;
            aa = int.Parse(Console.ReadLine());
            Random zxx = new Random();
            bb = zxx.Next(1, 20);
            num = aa + bb;
            Console.WriteLine("***************************************************");
            Console.WriteLine($"O computador escolheu: {bb}");
            switch (num)
            {
                case 21:
                    Console.WriteLine("Você fez 30 pontos!!!");
                    break;
                case 14:
                    Console.WriteLine("Você fez 20 pontos!!!");
                    break;

                case 7:
                    Console.WriteLine("Você fez 10 pontos!!!");
                    break;

                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    Console.WriteLine("Você fez 6 pontos!!!");
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    Console.WriteLine("Você fez 5 pontos!!!");
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Você fez 1 ponto!!!");
                    break;

                default:
                    Console.WriteLine("Você não fez nenhum ponto!!!");
                    break;
            } Console.WriteLine("Escolha um novo número!!!");
                    aa = int.Parse(Console.ReadLine());
                    Random xxx = new Random();
                    bb = xxx.Next(1, 20);
                    num = aa + bb;
                    Console.WriteLine("***************************************************");
                    Console.WriteLine($"O computador escolheu: {bb}");
                    switch (num)
                    {
                        case 21:
                            Console.WriteLine("Você fez 30 pontos!!!");
                            break;
                        case 14:
                            Console.WriteLine("Você fez 20 pontos!!!");
                            break;

                        case 7:
                            Console.WriteLine("Você fez 10 pontos!!!");
                            break;

                        case 15:
                        case 16:
                        case 17:
                        case 18:
                        case 19:
                        case 20:
                            Console.WriteLine("Você fez 6 pontos!!!");
                            break;
                        case 8:
                        case 9:
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                            Console.WriteLine("Você fez 5 pontos!!!");
                            break;
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                            Console.WriteLine("Você fez 1 ponto!!!");
                            break;

                        default:
                            Console.WriteLine("Você não fez nenhum ponto!!!");
                            break;
                    }
        }
    }
}


