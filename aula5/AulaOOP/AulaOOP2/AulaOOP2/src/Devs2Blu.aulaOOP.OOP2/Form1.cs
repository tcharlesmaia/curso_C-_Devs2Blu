using Desvs2Blu.AulaOOP.OOP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.aulaOOP.OOP2
{
    public partial class Form1 : Form
    {
    public Contato Contato { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Contato = new Contato();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contato.Nome = txt_nome.Text;
            Contato.Ce_tel = txtCel.Text;
            Contato.E_mail = txtEmail.Text;
            Contato.CEP = txtCep.Text;
            Contato.Rua = txtRua.Text;
            Contato.Numero = txtNumero.Text;
            Contato.Bairro = txtBairro.Text;
            Contato.Cidade = txtCidade.Text;
            Contato.Estado = txtEstado.Text;

        }

        #region
        public void LimparForm()
        {
            txt_nome.Clear();
           txtCel.Clear();
           txtEmail.Clear();
           txtCep.Clear();
            txtRua.Clear();
           txtNumero.Clear();
           txtBairro.Clear();
           txtCidade.Clear();
           txtEstado.Clear();



        }
        public bool ValidaForm()
        {
            if (txt_nome.Text.Equals("")) return false;
            if (txtCel.Text.Equals("")) return false;
            if (txtEmail.Text.Equals("")) return false;
            if (txtCep.Text.Equals("")) return false;
            if (txtRua.Text.Equals("")) return false;
            if (txtNumero.Text.Equals("")) return false;
            if (txtBairro.Text.Equals("")) return false;
            if (txtCidade.Text.Equals("")) return false;
            if (txtEstado.Text.Equals("")) return false;
            return true;       
        }
        #endregion

    }
}
