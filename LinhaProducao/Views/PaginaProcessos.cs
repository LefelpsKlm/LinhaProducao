using LinhaProducao.Views.AdcNv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinhaProducao.Views
{
    public partial class PaginaProcessos : Form
    {
        public PaginaProcessos()
        {
            InitializeComponent();

            try
            {

                Processos processos = new Processos();

                listViewProcessos.Bounds = new Rectangle(new Point(15, 70), new Size(700, 500));

                listViewProcessos.View = View.Details;
                listViewProcessos.LabelEdit = true;
                listViewProcessos.AllowColumnReorder = true;
                listViewProcessos.FullRowSelect = true;
                listViewProcessos.GridLines = true;
                listViewProcessos.CheckBoxes = true;
                listViewProcessos.Sorting = SortOrder.Ascending;

                listViewProcessos.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewProcessos.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewProcessos.Columns.Add("NOME", -2, HorizontalAlignment.Left);

                foreach (Processos processo in processos.GetListaProcessos())
                {
                    ListViewItem item = new ListViewItem("", 0);
                    item.Checked = true;
                    item.SubItems.Add(processo.id.ToString());
                    item.SubItems.Add(processo.nome);
                    listViewProcessos.Items.Add(item);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        public void AbrirNv<Forms>() where Forms : Form, new()
        {

            Form formulario;

            listViewProcessos.Controls.Clear();

            formulario = listViewProcessos.Controls.OfType<Form>().FirstOrDefault();


            if (formulario == null)
            {

                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;

                formulario.Dock = DockStyle.Fill;

                listViewProcessos.Controls.Add(formulario);
                listViewProcessos.Tag = formulario;

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

        private void PaginaProcessos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirNv<NvProcesso>();
        }
    }
}
