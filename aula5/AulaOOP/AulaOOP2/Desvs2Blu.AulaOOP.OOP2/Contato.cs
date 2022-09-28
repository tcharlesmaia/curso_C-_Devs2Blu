using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desvs2Blu.AulaOOP.OOP2
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Ce_tel { get; set; }
        public string E_mail { get; set; }
        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Contato()
        {

        }
        public Contato(string nome, string email, string cel, string cep, string rua, string numero,string bairro string cidade, string estado) 
        {
            Nome = nome;
            E_mail = email;
            Ce_tel = cel;
            CEP = cep;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

    }
}
