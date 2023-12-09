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

                foreach (Processos processo in processos.GetListaProcessos())
                {
                    ListViewItem item = new ListViewItem("", 0);
                    item.Checked = true;
                    item.SubItems.Add(processo.id.ToString());
                    item.SubItems.Add(processo.nome);
                    listViewClientes.Items.Add(item);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void PaginaProcessos_Load(object sender, EventArgs e)
        {

        }
    }
}
