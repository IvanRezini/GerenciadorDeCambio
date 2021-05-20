using GerenciadorDeCambio.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeCambio.views
{
    public partial class FormAtualizarTaxa : Form
    {
         /// <summary>
         /// Inicializa o form, au inicialisar ele popula o menu combobox
         /// </summary>
        public FormAtualizarTaxa()
        {
            InitializeComponent();
            this.popularcombobox();
        }
        /// <summary>
        /// Au clicar em salvar fiz uma validação para ver se os valores de digitados são numericos
        /// e se sim salva a aleraçao e recarega o menu
        /// </summary>
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!= "")
            {
                string linha=comboBox1.SelectedItem.ToString();
                string[] id = linha.Split('-');
                string valor = textBox1.Text;
                valor = valor.Replace(".", ",");
                string[] x = valor.Split(',');
                if (x.Length >= 0 && x.Length < 3) ///valida se foi digitado e se tem apenas uma virgula
                {
                    MessageBox.Show(x.Length.ToString());
                    if (Regex.IsMatch(x[0], @"^[0-9]+$"))
                    {
                        if (x.Length > 1)
                        {
                            if (Regex.IsMatch(x[1], @"^[0-9]+$"))
                            {

                                MoedaController.atualisar(id[0], valor);
                                this.popularcombobox();
                            }
                            else
                            {
                                MessageBox.Show("Valor invalido" + "\n");
                            }
                        }
                        else
                        {
                            MoedaController.atualisar(id[0], valor);
                            this.popularcombobox();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valor invalido" + "\n");
                    }
                }
                else
                {
                    MessageBox.Show("Valor invalido" + "\n");
                }


                Console.WriteLine(id[0]+"\n\n\n");
            }
            else
            {
                MessageBox.Show("Digite nova taxa" + "\n");
            }
        }
        /// <summary>
        /// Faz o caregamento do menu com as iformaçoes do banco
        /// </summary>
        private void popularcombobox()
        {
            comboBox1.DataSource = null;
           comboBox1.DataSource = MoedaController.select();
        }

      
    }
}
