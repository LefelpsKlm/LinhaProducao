using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinhaProducao.Views
{
    public partial class PaginaLogin : Form
    {
        public PaginaLogin()
        {
            InitializeComponent();
        }

        private void PaginaLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string email = TextBoxEmail.Text;
                string senha = TextBoxSenha.Text;

                Funcionarios funcionarios = new Funcionarios();

                funcionarios.email = email;
                funcionarios.SetSenha(senha);



                funcionarios.GetFuncionarioPorEmailESenha();

                if (funcionarios.logado)
                {
                    this.Hide();

                    PaginaInicial paginaInicial = new PaginaInicial();

                    paginaInicial.Show();

                }
                else
                {
                    throw new Exception("Erro ao realizar login, credenciais incorretas ou não encontradas");
                }

                MessageBox.Show("Seja bem vindo, " + funcionarios.nome);

            }
            catch (Exception expection)
            {
                MessageBox.Show(expection.Message);
            }
        }

        private void TextBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
