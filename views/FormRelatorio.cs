using GerenciadorDeCambio.Controller;
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
        /// <summary>
        /// Recebe as informações dos formularios
        /// e carega a exibição
        /// </summary>
        public FormRelatorio(string id, string dataInicio, string dataFim)
        {
            InitializeComponent();
            this.populardataGridView(id, dataInicio, dataFim);
        }
        /// <summary>
        /// carega o dataGrid com as informçoes do relaatorio gerado pelo controller
        /// </summary>
        private void populardataGridView(string id, string dataInicio, string dataFim)
        {
                dataGridView1.DataSource = RelatorioController.relatorio(id, dataInicio, dataFim);

                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoResizeRows();;
                dataGridView1.ClearSelection();
            
            
        }

    }
}
