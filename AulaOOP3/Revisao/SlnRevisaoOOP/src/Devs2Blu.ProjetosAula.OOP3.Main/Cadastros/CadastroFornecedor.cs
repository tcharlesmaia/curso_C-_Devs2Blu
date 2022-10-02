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
    internal class CadastroFornecedor: IMenuCadastro
    {
        public CadastroFornecedor() { }
        public Int32 MenuCadastro()
        {
            Int32 opcao;

            Console.Clear();
            Console.WriteLine("----- Cadastro de Fornecedor -----");
            Console.WriteLine("----- 1- Lista de Fornecedores -----");
            Console.WriteLine("----- 2- Cadastro de Fornecedor -----");
            Console.WriteLine("----- 3- Alterar Fornecedor -----");
            Console.WriteLine("---------------------");
            Console.WriteLine("----- 0- Sair -----");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;

        }

        public void Listar()
        {
            Console.Clear();

            foreach (var fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Rececionista: {fornecedor.Codigo}");
                Console.WriteLine($"Nome: {fornecedor.Nome}");
                Console.WriteLine($"Setor: {fornecedor.TipoFornecedor}");
                Console.WriteLine($"CGC: {fornecedor.CGCCPF}");
                Console.WriteLine("-----------------------------------------\n");
            }
            Console.ReadLine();
        }
        private void CadastrarFornecedor(Fornecedor novoFornecedor)
        {
            Program.Mock.ListaFornecedores.Add(novoFornecedor);
        }
        private void CadastrarRececionista(Recepcionista novoRececionista)
        {
            Program.Mock.ListaRecepcionistas.Add(novoRececionista);
        }

        public void Cadastrar()
        {
            Console.Clear();
            Fornecedor fornecedor = new Fornecedor();
            Console.WriteLine("Informe o Nome do Fornecedor");
            fornecedor.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do Recepcionista");
            fornecedor.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o setor do Rececionista");
            fornecedor.TipoFornecedor = Console.ReadLine();

            Random rd = new Random();
            fornecedor.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            fornecedor.CodigoFornecedor = Int32.Parse($"{fornecedor.Codigo}{rd.Next(100, 999)}");

            CadastrarFornecedor(fornecedor);
        }

        public void Alterar()
        {
            Console.Clear();
            Fornecedor fornecedor;
            int codigoFornecedor;

            Console.WriteLine("Informe o Fornecedor que Deseja Alterar:\n");
            ListarFornecedorByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoFornecedor);

            fornecedor = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == codigoFornecedor);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Paciente: {fornecedor.Codigo}/{fornecedor.CodigoFornecedor} | Nome: {fornecedor.Nome} | CNJ: {fornecedor.CGCCPF} | Categoria fornecimento: {fornecedor.TipoFornecedor}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CNJ | 03 Categoria Fornecimento | 00 - SAIR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        fornecedor.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF:");
                        fornecedor.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo Convênio:");
                        fornecedor.TipoFornecedor = Console.ReadLine();
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

            AlterarFornecedor(fornecedor);
        }
        private void AlterarFornecedor(Fornecedor fornecedor)
        {
            var pact = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == fornecedor.CodigoFornecedor);
            int index = Program.Mock.ListaFornecedores.IndexOf(pact);
            Program.Mock.ListaFornecedores[index] = fornecedor;
        }

        public void Excluir()
        {
            Fornecedor fornecedor = new Fornecedor();
            ExcluirFornecedor(fornecedor);
        }
        private void ExcluirFornecedor(Fornecedor fornecedor)
        {
            Program.Mock.ListaFornecedores.Remove(fornecedor);
        }
        private void ListarFornecedorByCodeAndName()
        {
            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.Write($"| {fornecedor.CodigoFornecedor} - {fornecedor.Nome} ");
            }
            Console.WriteLine("\n");
        }
        
    }
}
