using GerenciadorDeCambio.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeCambio.views
{
    public partial class FormRelatorio : Form
    {
        public FormRelatorio(string id, string dataInicio, string dataFim)
        {
            InitializeComponent();
            this.populardataGridView(id, dataInicio, dataFim);
        }
        private void populardataGridView(string id, string dataInicio, string dataFim)
        {
            if (id != "")
            {
                string[] aux = id.Split('-');
                int cod = Int32.Parse(aux[0].Trim());

                dataGridView1.DataSource = RelatorioDao.relatorio(cod, dataInicio, dataFim);
                dataGridView1.AutoResizeColumn(0);
                dataGridView1.AutoResizeColumn(1);
                dataGridView1.AutoResizeColumn(2);
                dataGridView1.AutoResizeColumn(3);
                dataGridView1.AutoResizeColumn(4);
                dataGridView1.AutoResizeColumn(5);
                dataGridView1.AutoResizeColumn(6);
                dataGridView1.AutoResizeColumn(7);
                dataGridView1.ClearSelection();
            }
            else
            {
                dataGridView1.DataSource = RelatorioDao.relatorioPeriodo(dataInicio, dataFim);
                dataGridView1.AutoResizeColumn(0);
                dataGridView1.AutoResizeColumn(1);
                dataGridView1.AutoResizeColumn(2);
                dataGridView1.AutoResizeColumn(3);
                dataGridView1.AutoResizeColumn(4);
                dataGridView1.AutoResizeColumn(5);
                dataGridView1.AutoResizeColumn(6);
                dataGridView1.AutoResizeColumn(7);
                dataGridView1.ClearSelection();

            }
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
          
        }
    }
}
