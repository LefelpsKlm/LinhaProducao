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
    public partial class PaginaClientes : Form
    {
        public PaginaClientes()
        {
            InitializeComponent();

            try
            {

                Clientes clientes = new Clientes();

                listViewClientes.Bounds = new Rectangle(new Point(15, 70), new Size(700, 500));

                listViewClientes.View = View.Details;
                listViewClientes.LabelEdit = true;
                listViewClientes.AllowColumnReorder = true;
                listViewClientes.FullRowSelect = true;
                listViewClientes.GridLines = true;
                listViewClientes.CheckBoxes = true;
                listViewClientes.Sorting = SortOrder.Ascending;

                listViewClientes.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewClientes.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewClientes.Columns.Add("NOME", -2, HorizontalAlignment.Left);

                foreach (Clientes cliente in clientes.GetListaClientes())
                {
                    ListViewItem item = new ListViewItem("", 0);
                    item.Checked = true;
                    item.SubItems.Add(cliente.id.ToString());
                    item.SubItems.Add(cliente.nome);
                    item.SubItems.Add(cliente.email);
                    listViewClientes.Items.Add(item);
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

            listViewClientes.Controls.Clear();

            formulario = listViewClientes.Controls.OfType<Form>().FirstOrDefault();


            if (formulario == null)
            {

                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;

                formulario.Dock = DockStyle.Fill;

                listViewClientes.Controls.Add(formulario);
                listViewClientes.Tag = formulario;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listViewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PaginaClientes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            AbrirNv<NvClientes>();
        }
    }
}
