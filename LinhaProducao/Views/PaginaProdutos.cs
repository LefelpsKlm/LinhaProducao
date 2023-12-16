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
    public partial class PaginaProdutos : Form
    {
        public PaginaProdutos()
        {
            InitializeComponent();

            try
            {

                Produtos produtos = new Produtos();

                listViewProdutos.Bounds = new Rectangle(new Point(15, 70), new Size(700, 500));

                listViewProdutos.View = View.Details;
                listViewProdutos.LabelEdit = true;
                listViewProdutos.AllowColumnReorder = true;
                listViewProdutos.FullRowSelect = true;
                listViewProdutos.GridLines = true;
                listViewProdutos.CheckBoxes = true;
                listViewProdutos.Sorting = SortOrder.Ascending;

                listViewProdutos.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewProdutos.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewProdutos.Columns.Add("NOME", -2, HorizontalAlignment.Left);

                foreach (Produtos produto in produtos.GetListaProdutos())
                {
                    ListViewItem item = new ListViewItem("", 0);
                    item.Checked = true;
                    item.SubItems.Add(produto.id.ToString());
                    item.SubItems.Add(produto.nome);
                    listViewProdutos.Items.Add(item);
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

            listViewProdutos.Controls.Clear();

            formulario = listViewProdutos.Controls.OfType<Form>().FirstOrDefault();


            if (formulario == null)
            {

                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;

                formulario.Dock = DockStyle.Fill;

                listViewProdutos.Controls.Add(formulario);
                listViewProdutos.Tag = formulario;

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

        private void PaginaProdutos_Load(object sender, EventArgs e)
        {

        }

        private void listViewProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirNv<NvProdutos>();
        }
    }
}
