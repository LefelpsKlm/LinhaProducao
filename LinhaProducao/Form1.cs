using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinhaProducao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Funcionarios funcionario = new Funcionarios();

                funcionario.nome = "Cuca Beludo";
                funcionario.id_empresa = 1;
                funcionario.email = "Ajacudo_ce@gmail.com";
                funcionario.SetNivel(4);
                funcionario.SetSenha("10conto");

                funcionario.Insert();

                MessageBox.Show("Funcionário adicionado com sucesso");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
