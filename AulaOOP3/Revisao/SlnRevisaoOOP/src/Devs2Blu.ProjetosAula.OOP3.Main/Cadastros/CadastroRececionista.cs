using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    internal class CadastroRececionista : IMenuCadastro
    {
        public CadastroRececionista() { }
        public Int32 MenuCadastro()
        {
            Int32 opcao;

            Console.Clear();
            Console.WriteLine("----- Cadastro de Rececionista -----");
            Console.WriteLine("----- 1- Lista de Rececionoistas -----");
            Console.WriteLine("----- 2- Cadastro de Rececionista -----");
            Console.WriteLine("----- 3- Alterar Rececionista -----");
            Console.WriteLine("----- 4- Excluir Rececionista -----");
            Console.WriteLine("---------------------");
            Console.WriteLine("----- 0- Sair -----");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;

        }

        public void Listar()
        {
            Console.Clear();

            foreach (var rececionista in Program.Mock.ListaRecepcionistas)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Rececionista: {rececionista.Codigo}");
                Console.WriteLine($"Nome: {rececionista.Nome}");
                Console.WriteLine($"Setor: {rececionista.Setor}");
                Console.WriteLine($"CGC: {rececionista.CGCCPF}");
                Console.WriteLine("-----------------------------------------\n");
            }
            Console.ReadLine();
        }
        private void CadastrarRececionista(Recepcionista novoRececionista)
        {
            Program.Mock.ListaRecepcionistas.Add(novoRececionista);
        }

        public void Cadastrar()
        {
            Console.Clear();
            Recepcionista rececionista = new Recepcionista();
            Console.WriteLine("Informe o Nome do Recepcionista");
            rececionista.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do Recepcionista");
            rececionista.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o setor do Rececionista");
            rececionista.Setor = Console.ReadLine();

            Random rd = new Random();
            rececionista.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            rececionista.CodigoRecepcionista = Int32.Parse($"{rececionista.Codigo}{rd.Next(100, 999)}");

            CadastrarRececionista(rececionista);
        }

        public void Alterar()
        {
            Console.Clear();
            Recepcionista rececionista;
            int codigoRececionista;

            Console.WriteLine("Informe o Rececionista que Deseja Alterar:\n");
            ListarRececionistaByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoRececionista);

            rececionista = Program.Mock.ListaRecepcionistas.Find(p => p.CodigoRecepcionista == codigoRececionista);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Paciente: {rececionista.Codigo}/{rececionista.CodigoRecepcionista} | Nome: {rececionista.Nome} | CPF: {rececionista.CGCCPF} | Setor: {rececionista.Setor}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 Setor | 00 - SAIR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        rececionista.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF:");
                        rececionista.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo Convênio:");
                        rececionista.Setor = Console.ReadLine();
                        break;
                    default:
                        alterar = false;
                        break;
                }

                if (alterar)
                {
                    Console.Clear();
                    Console.WriteLine("Dado Alterado com Sucesso!");
                }
            } while (alterar);

            AlterarRececionist(rececionista);
        }

        public void Excluir()
        {
            Recepcionista rececionista = new Recepcionista();
            Console.Clear();
            int codigoRececionista;

            Console.WriteLine("Informe o Rececionista que Deseja Excluir:\n");
            ListarRececionistaByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoRececionista);

            rececionista = Program.Mock.ListaRecepcionistas.Find(p => p.CodigoRecepcionista == codigoRececionista);

            Console.WriteLine("Rececionista excluído com Sucesso!");
            Console.ReadLine();
            ExcluirRececionista(rececionista);
            
        }
        private void ExcluirRececionista(Recepcionista recepcionista)
        {
            
            Program.Mock.ListaRecepcionistas.Remove(recepcionista);
        }
        private void ListarRececionistaByCodeAndName()
        {
            foreach (Recepcionista rececionis in Program.Mock.ListaRecepcionistas)
            {
                Console.Write($"| {rececionis.CodigoRecepcionista} - {rececionis.Nome} ");
            }
            Console.WriteLine("\n");
        }
        #region FACADE

        private void AlterarRececionist(Recepcionista rececionista)
        {
            var pact = Program.Mock.ListaRecepcionistas.Find(p => p.CodigoRecepcionista == rececionista.CodigoRecepcionista);
            int index = Program.Mock.ListaRecepcionistas.IndexOf(pact);
            Program.Mock.ListaRecepcionistas[index] = rececionista;
        }
        
        #endregion
    }
}
