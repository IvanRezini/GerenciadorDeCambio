using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorDeCambio.views;

namespace GerenciadorDeCambio
{
    public partial class formPrincipal : Form
    {

        /// <summary>
        /// cada menu chama seu form corespondente
        /// e o btn chama seu form tambem
        /// </summary>
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroCliente_Click(object sender, EventArgs e)
        {
            FormCadastroCliente formCadastroCliente = new FormCadastroCliente();
            formCadastroCliente.ShowDialog();
        }

        private void cadastroMoeda_Click(object sender, EventArgs e)
        {
            FormCadastroMoeda formCadastroMoeda = new FormCadastroMoeda();
            formCadastroMoeda.ShowDialog();
        }

        private void atualizarMoeda_Click(object sender, EventArgs e)
        {
            FormAtualizarTaxa formAtualizarTaxa = new FormAtualizarTaxa();
            formAtualizarTaxa.ShowDialog();
        }

        private void buttonTransacao_Click(object sender, EventArgs e)
        {
            FormTransacao formTransacao = new FormTransacao();
            formTransacao.ShowDialog();
        }

        private void clienteToolStripMenuItemOperacao_Click(object sender, EventArgs e)
        {
            FormGerarRelatorio formRelatorio = new FormGerarRelatorio();
            formRelatorio.ShowDialog();
        }

        private void totaisToolStripMenuItemTotal_Click(object sender, EventArgs e)
        {
            FormRelatorioPeriodo formRelatorioPeriodo = new FormRelatorioPeriodo();
            formRelatorioPeriodo.ShowDialog();
        }
    }
}
