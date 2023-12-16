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
    public partial class NvSetores : Form
    {
        public NvSetores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Setores setores = new Setores();

                setores.id_empresa = 1;
                setores.nome = textBoxNome.Text;
                setores.id_responsavel = Convert.ToInt32(textBoxResponsavel.Text);

                setores.Insert();

                MessageBox.Show("Setor adicionado com sucesso!");

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

        private void NvSetor_Load(object sender, EventArgs e)
        {

        }
    }
}
