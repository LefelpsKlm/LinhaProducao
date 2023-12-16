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
    public partial class PaginaSetores : Form
    {
        public PaginaSetores()
        {
            InitializeComponent();

            try
            {

                Setores setores = new Setores();

                listViewSetor.Bounds = new Rectangle(new Point(15, 70), new Size(700, 500));

                listViewSetor.View = View.Details;
                listViewSetor.LabelEdit = true;
                listViewSetor.AllowColumnReorder = true;
                listViewSetor.FullRowSelect = true;
                listViewSetor.GridLines = true;
                listViewSetor.CheckBoxes = true;
                listViewSetor.Sorting = SortOrder.Ascending;

                listViewSetor.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewSetor.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewSetor.Columns.Add("NOME", -2, HorizontalAlignment.Left);

                foreach (Setores setor in setores.GetListaSetores())
                {
                    ListViewItem item = new ListViewItem("", 0);
                    item.Checked = true;
                    item.SubItems.Add(setor.id.ToString());
                    item.SubItems.Add(setor.nome);
                    listViewSetor.Items.Add(item);
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

            listViewSetor.Controls.Clear();

            formulario = listViewSetor.Controls.OfType<Form>().FirstOrDefault();


            if (formulario == null)
            {

                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;

                formulario.Dock = DockStyle.Fill;

                listViewSetor.Controls.Add(formulario);
                listViewSetor.Tag = formulario;

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

        private void PaginaSetores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirNv<NvSetores>();
        }
    }
}
