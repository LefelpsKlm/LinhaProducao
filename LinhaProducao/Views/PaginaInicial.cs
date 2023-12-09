using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinhaProducao.Views
{
    public partial class PaginaInicial : Form
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }

        public void AbrirForm<Forms>() where Forms : Form, new()
        {

            Form formulario;

            panelConteudo.Controls.Clear();

            formulario = panelConteudo.Controls.OfType<Form>().FirstOrDefault();


            if (formulario == null)
            {

                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;

                formulario.Dock = DockStyle.Fill;

                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;
                
                formulario.Show();
                formulario.BringToFront();

            }
            else
            {

                if (formulario.WindowState == FormWindowState.Minimized)
                {

                    formulario.WindowState = FormWindowState.Normal;

                    formulario.BringToFront();

                }

            }

        }

        private void PaginaInicial_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirForm<PaginaClientes>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForm<PaginaProdutos>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirForm<PaginaLinhaProducao>();
        }

        private void panelConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirForm<PaginaOrdemProducao>();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirForm<PaginaSetores>();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirForm<PaginaProcessos>();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirForm<PaginaEtapas>();
        }
    }
}
