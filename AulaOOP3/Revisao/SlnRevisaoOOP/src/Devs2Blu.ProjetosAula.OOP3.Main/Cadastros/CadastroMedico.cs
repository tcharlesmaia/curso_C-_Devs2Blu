using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroMedico : IMenuCadastro
    {
        public Int32 MenuCadastro()
        {
            Int32 opcao;

            Console.Clear();
            Console.WriteLine("----- Cadastro de Medicos -----");
            Console.WriteLine("----- 1- Lista de Medicos -----");
            Console.WriteLine("----- 2- Cadastro de Medicos -----");
            Console.WriteLine("----- 3- Alterar Medicos -----");
            Console.WriteLine("----- 4- Excluir Medicos -----"); 
            Console.WriteLine("---------------------");
            Console.WriteLine("----- 0- Sair -----");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;

        }

        public void Listar()
        {
            Console.Clear();

            foreach (var medico in Program.Mock.ListaMedicos)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Medico: {medico.CodigoMedico}");
                Console.WriteLine($"Nome: {medico.Nome}");
                Console.WriteLine($"Especialidade: {medico.Especialidade}");
                Console.WriteLine($"CRM: {medico.CRM}");
                Console.WriteLine("-----------------------------------------\n");
            }
            Console.ReadLine();
        }
        private void ExcluirMedico(Medico medico)
        {
            Program.Mock.ListaMedicos.Remove(medico);
        }
        private void ListarMedicosByCodeAndName()
        {
            foreach (Medico medico in Program.Mock.ListaMedicos)
            {
                Console.Write($"| {medico.CodigoMedico} - {medico.Nome} ");
            }
            Console.WriteLine("\n");
        }
        public void Cadastrar()
        {
            Console.Clear();
            Medico medico = new Medico();
            Console.WriteLine("Informe o Nome do Médico");
            medico.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do Médico");
            medico.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o Convênio do Paciente");
            medico.Especialidade = Console.ReadLine();

            Random rd = new Random();
            medico.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            medico.CodigoMedico = Int32.Parse($"{medico.Codigo}{rd.Next(100, 999)}");

            CadastrarMedico(medico);
        }
        private void CadastrarMedico(Medico novoMedico)
        {
            Program.Mock.ListaMedicos.Add(novoMedico);
        }

        public void Alterar()
        {
            Console.Clear();
            Medico medico;
            int codigoMedico;

            Console.WriteLine("Informe o Médico que Deseja Alterar:\n");
            ListarMedicosByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoMedico);

            medico = Program.Mock.ListaMedicos.Find(p => p.CodigoMedico == codigoMedico);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Médico: {medico.Codigo}/{medico.CodigoMedico} | Nome: {medico.Nome} | CPF: {medico.CGCCPF} | Convênio: {medico.Especialidade}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 Esecialidade | 00 - SAIR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        medico.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF:");
                        medico.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe uma especialidade:");
                        medico.Especialidade = Console.ReadLine();
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

            AlterarMedico(medico);
        }
        private void AlterarMedico(Medico medico)
        {
            var pact = Program.Mock.ListaMedicos.Find(p => p.CodigoMedico == medico.CodigoMedico);
            int index = Program.Mock.ListaMedicos.IndexOf(pact);
            Program.Mock.ListaMedicos[index] = medico;
        }

        public void Excluir()
        {
            Medico medico = new Medico();
            Console.Clear();
            int codigoMedico;

            Console.WriteLine("Informe o Médico que Deseja Excluir:\n");
            ListarMedicosByCodeAndName();
            Int32.TryParse(Console.ReadLine(), out codigoMedico);

            medico = Program.Mock.ListaMedicos.Find(p => p.CodigoMedico == codigoMedico);

            Console.WriteLine("Médico excluído com Sucesso!");
            Console.ReadLine();
            ExcluirMedico(medico);
        }
    }
}
