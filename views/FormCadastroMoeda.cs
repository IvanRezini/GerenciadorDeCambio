using GerenciadorDeCambio.Controller;
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

namespace GerenciadorDeCambio.views
{
    public partial class FormCadastroMoeda : Form
    {
        public FormCadastroMoeda()
        {
            InitializeComponent();
        }

        /// <summary>
        /// au ser clicado o btn, é caregado um obj do tipo moeda
        /// e enviado para validação se a reposta for real ele carega as informaçoes no banco
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            MoedaModel mdo = new MoedaModel();
            mdo.Nome = textBoxNome.Text;
            mdo.Taxa = textBoxValor.Text;
            

            string resposta = MoedaController.salvar(mdo);
            if (resposta == "")
            {
                textBoxNome.Text = "";
                textBoxValor.Text = "";
               
            }
            else
            {
                MessageBox.Show(resposta);
            }
        }
    }
    
}
