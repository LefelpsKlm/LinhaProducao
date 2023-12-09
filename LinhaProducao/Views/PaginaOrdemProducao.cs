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
    public partial class PaginaOrdemProducao : Form
    {
        public PaginaOrdemProducao()
        {
            InitializeComponent();

            try
            {

                Ordem_Producao OProducao = new Ordem_Producao();

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
                listViewClientes.Columns.Add("ID SETOR", -2, HorizontalAlignment.Left);
                listViewClientes.Columns.Add("ID CLIENTE", -2, HorizontalAlignment.Left);

                foreach (Ordem_Producao ordem_producao in OProducao.GetListaOrdemProducao())
                {
                    ListViewItem item = new ListViewItem("", 0);
                    item.Checked = true;
                    item.SubItems.Add(ordem_producao.id.ToString());
                    item.SubItems.Add(ordem_producao.setor.ToString());
                    item.SubItems.Add(ordem_producao.cliente.ToString());
                    listViewClientes.Items.Add(item);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void PaginaOrdemProducao_Load(object sender, EventArgs e)
        {

        }
    }
}
