using GerenciadorDeCambio.Controller;
using GerenciadorDeCambio.Model;
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
    public partial class FormTransacao : Form
    {
        public FormTransacao()
        {
            InitializeComponent();
            this.popularcombobox();
            buttonSalvar.Enabled = false;
        }


        private void buttonProcessar_Click(object sender, EventArgs e)
        {
            string[] resposta;
            if (textBoxValor.Text != "")
            {
                string linha = comboBoxCliente.SelectedItem.ToString();
                string[] id = linha.Split('-');
                string valor = textBoxValor.Text;
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
                                resposta=TransacaoController.processar(comboBoxMoedaOrigem.SelectedItem.ToString(), comboBoxmoedaDestino.SelectedItem.ToString(),valor);
                                labelTotal.Text = resposta[0] + " $";
                                labelTaxa.Text = resposta[1] + " R$";
                                labelTotaMenosTaxa.Text = resposta[2] + " $";

                                labelTotal.Visible = true;
                                labelTaxa.Visible = true;
                                labelTotaMenosTaxa.Visible = true;
                                buttonSalvar.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Valor invalido" + "\n");
                            }
                        }
                        else
                        {
                           resposta= TransacaoController.processar(comboBoxMoedaOrigem.SelectedItem.ToString(), comboBoxmoedaDestino.SelectedItem.ToString(), valor);
                            labelTotal.Text = resposta[0] + " $";
                            labelTaxa.Text = resposta[1]+" R$";
                            labelTotaMenosTaxa.Text = resposta[2] + " $";
                            labelTotal.Visible =true;
                            labelTaxa.Visible = true;
                            labelTotaMenosTaxa.Visible = true;
                            buttonSalvar.Enabled = true;

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


                Console.WriteLine(id[0] + "\n\n\n");
            }
            else
            {
                MessageBox.Show("Valor em branco" + "\n");
            }
        }

    

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (comboBoxCliente.Text != "Selecione")
            {
                TransacaoModel tra = new TransacaoModel();

                string[] aux = comboBoxCliente.Text.Split('-');
                tra.IdClient = Int32.Parse(aux[0].Trim());
                aux = comboBoxMoedaOrigem.Text.Split('-');
                tra.IdMoedaOrigem = Int32.Parse(aux[0].Trim());
                aux = comboBoxmoedaDestino.Text.Split('-');
                tra.IdMoedaDestino = Int32.Parse(aux[0].Trim());
                tra.ValorOriginal = textBoxValor.Text;
                aux = labelTotal.Text.Split(' ');
                tra.ValorConvertido = aux[0];
                aux = labelTaxa.Text.Split(' ');
                tra.TaxaCobrada = aux[0];
                tra.Data = DateTime.Now.ToString("yyyy-MM-dd");


                TransacaoController.salvar(tra);
            }
            else
            {
                MessageBox.Show("Selecione um cliente" + "\n");
            }

        }
        private void popularcombobox()
        {
            comboBoxmoedaDestino.DataSource = null;
            comboBoxmoedaDestino.DataSource = MoedaController.select();
            comboBoxMoedaOrigem.DataSource = null;
            comboBoxMoedaOrigem.DataSource = MoedaController.select();
            comboBoxCliente.DataSource = null;
            comboBoxCliente.DataSource = ClienteController.select();
        }

        

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {
            buttonSalvar.Enabled = false;
        }
    }
}
