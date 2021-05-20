using GerenciadorDeCambio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorDeCambio.Controller;

namespace GerenciadorDeCambio.views
{
    public partial class FormCadastroCliente : Form
    {
        /// <summary>
        /// carega o formulario no carregamento 
        /// ele carega o campo data com a data atual
        /// </summary>
        public FormCadastroCliente()
        {
            InitializeComponent();
            string data = DateTime.Now.ToString("yyyy-MM-dd");
            textBoxData.Text = data;
        }

        /// <summary>
        /// quando clica no btn salvar inicializado um objeto novo do tipo clientModel
        /// esse cliet e mandado para o ControllerClient para fazer validação
        /// recebe de volta a resposta e exibi.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            ClientModel cli = new ClientModel();
           cli.Nome= textBox1.Text;
            cli.Cpf = maskedTextBoxCpf.Text;
            cli.Data = textBoxData.Text;
         
            string resposta = ClienteController.salvar(cli);
            if (resposta == "")
            {
                textBox1.Text = "";
                maskedTextBoxCpf.Text = "";
              
            }
            else
            {
                MessageBox.Show(resposta);
            }
        }

       
    }
}
