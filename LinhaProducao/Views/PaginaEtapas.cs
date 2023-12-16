using LinhaProducao.Views.AdcNv;
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
    public partial class PaginaEtapas : Form
    {
        public PaginaEtapas()
        {
            InitializeComponent();

            try
            {

                Etapas etapas = new Etapas();

                listViewEtapas.Bounds = new Rectangle(new Point(15, 70), new Size(700, 500));

                listViewEtapas.View = View.Details;
                listViewEtapas.LabelEdit = true;
                listViewEtapas.AllowColumnReorder = true;
                listViewEtapas.FullRowSelect = true;
                listViewEtapas.GridLines = true;
                listViewEtapas.CheckBoxes = true;
                listViewEtapas.Sorting = SortOrder.Ascending;

                listViewEtapas.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewEtapas.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewEtapas.Columns.Add("NOME", -2, HorizontalAlignment.Left);

                foreach (Etapas etapa in etapas.GetListaEtapas())
                {
                    ListViewItem item = new ListViewItem("", 0);
                    item.Checked = true;
                    item.SubItems.Add(etapa.id.ToString());
                    item.SubItems.Add(etapa.nome);
                    listViewEtapas.Items.Add(item);
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

            listViewEtapas.Controls.Clear();

            formulario = listViewEtapas.Controls.OfType<Form>().FirstOrDefault();


            if (formulario == null)
            {

                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;

                formulario.Dock = DockStyle.Fill;

                listViewEtapas.Controls.Add(formulario);
                listViewEtapas.Tag = formulario;

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

        private void PaginaEtapas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirNv<NvEtapa>();
        }
    }
}
