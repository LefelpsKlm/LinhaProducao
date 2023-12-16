using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinhaProducao.Views.AdcNv
{
    public partial class NvProdutos : Form
    {
        public NvProdutos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Produtos produtos = new Produtos();

                produtos.id_empresa = 1;
                produtos.nome = textBoxNome.Text;

                produtos.Insert();

                MessageBox.Show("Produto adicionado com sucesso!");

                this.Close();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
