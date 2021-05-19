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
        public FormAtualizarTaxa()
        {
            InitializeComponent();
            this.popularcombobox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!= "")
            {
                string linha=comboBox1.SelectedItem.ToString();
                string[] id = linha.Split('-');
                string valor = textBox1.Text;
                valor = valor.Replace(".", ",");
                string[] x = valor.Split(',');
                if (x.Length >= 0)
                {
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
        private void popularcombobox()
        {
            comboBox1.DataSource = null;
           comboBox1.DataSource = MoedaController.select();
        }
    }
}
