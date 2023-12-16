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
    public partial class PaginaLinhaProducao : Form
    {
        public PaginaLinhaProducao()
        {
            InitializeComponent();

            try
            {

                Linha_Producao linhas_producao = new Linha_Producao();

                listViewLProducao.Bounds = new Rectangle(new Point(15, 70), new Size(700, 500));

                listViewLProducao.View = View.Details;
                listViewLProducao.LabelEdit = true;
                listViewLProducao.AllowColumnReorder = true;
                listViewLProducao.FullRowSelect = true;
                listViewLProducao.GridLines = true;
                listViewLProducao.CheckBoxes = true;
                listViewLProducao.Sorting = SortOrder.Ascending;

                listViewLProducao.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewLProducao.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewLProducao.Columns.Add("NOME", -2, HorizontalAlignment.Left);

                foreach (Linha_Producao linhaProducao in linhas_producao.GetListaLinhaProducao())
                {
                    ListViewItem item = new ListViewItem("", 0);
                    item.Checked = true;
                    item.SubItems.Add(linhaProducao.id.ToString());
                    item.SubItems.Add(linhaProducao.nome);
                    listViewLProducao.Items.Add(item);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void PaginaLinhaProducao_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}