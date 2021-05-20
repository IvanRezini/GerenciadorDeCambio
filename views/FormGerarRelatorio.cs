using GerenciadorDeCambio.Controller;
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
    public partial class FormGerarRelatorio : Form
    {
        public FormGerarRelatorio()
        {
            InitializeComponent();
            this.popularcombobox();
            maskedTextBoxDatafim.Text = DateTime.Now.ToString("yyyy-MM-dd");
            maskedTextBoxDataInicio.Text= "0000-00-00";
        }

        private void popularcombobox()
        {
            comboBoxCliente.DataSource = null;
            comboBoxCliente.DataSource = ClienteController.select();
        }

        private void buttonGerar_Click(object sender, EventArgs e)
        {
            if (comboBoxCliente.Text != "Selecione")
            {
                FormRelatorio formRelatorio = new FormRelatorio(comboBoxCliente.Text, maskedTextBoxDataInicio.Text, maskedTextBoxDatafim.Text);
                formRelatorio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um cliente" + "\n");
            }
        }

    }
}
