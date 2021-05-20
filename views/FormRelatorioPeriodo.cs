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
    public partial class FormRelatorioPeriodo : Form
    {
        public FormRelatorioPeriodo()
        {
            InitializeComponent();
            maskedTextBoxDatafim.Text = DateTime.Now.ToString("yyyy-MM-dd");
            maskedTextBoxDataInicio.Text = "0000-00-00";
        }

        private void buttonGerar_Click(object sender, EventArgs e)
        {
            FormRelatorio formRelatorio = new FormRelatorio("", maskedTextBoxDataInicio.Text, maskedTextBoxDatafim.Text);
            formRelatorio.ShowDialog();
        }
    }
}
