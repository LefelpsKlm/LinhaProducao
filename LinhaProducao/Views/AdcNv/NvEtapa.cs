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
    public partial class NvEtapa : Form
    {
        public NvEtapa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Etapas etapas = new Etapas();

                etapas.nome = textBoxNome.Text;
                etapas.ordem = Convert.ToInt32(textBoxOrdem.Text);
                etapas.id_processo = Convert.ToInt32(textBoxOrdem.Text);

                etapas.Insert();

                MessageBox.Show("Etapa adicionado com sucesso!");

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
