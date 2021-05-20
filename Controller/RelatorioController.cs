using GerenciadorDeCambio.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeCambio.Controller
{
    class RelatorioController
    {
        public static DataTable relatorio(string id, string dataInicio, string dataFim)
        {
            decimal totalConvertido = 0;
            decimal totalCobrado = 0;
            DataTable dt = new DataTable();
            DataTable dataTable = new DataTable();


            if (id != "")
            {
                string[] aux = id.Split('-');
                int cod = Int32.Parse(aux[0].Trim());
                dt = RelatorioDao.relatorio(cod, dataInicio, dataFim);
            }
            else
            {
                dt = RelatorioDao.relatorioPeriodo(dataInicio, dataFim);
            }

            string[] pro = { "Cod", "Data","Valor de origem","Valor Convertido", "Cliente","Valor cobrado R$","Moeda de origem", "Moeda de destino" };
            //adiciona as colunas
            for (int i = 0; i < pro.Length; i++)
            {
                dataTable.Columns.Add(pro[i]);
            }


            //adiciona as linhas a tabela
            foreach (DataRow linha in dt.Rows)
            {
                pro[0] = linha[0].ToString();//codigo
                pro[1] = linha[1].ToString();//data
                pro[2] = linha[2].ToString();//ValorOrigem
                pro[3] = linha[3].ToString();//ValorConvertido
                pro[4] = linha[4].ToString();//Cliente
                pro[5] = linha[5].ToString();//Valor cobrado
                pro[6] = linha[6].ToString();//MoedaOrigem
                pro[7] = linha[7].ToString();//Moeda destino

                totalCobrado += decimal.Parse(pro[5]);
                totalConvertido += (decimal.Parse(pro[5]) * 10);
                dataTable.Rows.Add(pro);
            }

            pro[0] = "";
            pro[1] = "";
            pro[2] = "Total convertido em R$";
            pro[3] = totalConvertido.ToString("N2");
            pro[4] = "Total Recebido";
            pro[5] = totalCobrado.ToString("N2");
            pro[6] = "";
            pro[7] = "";
            dataTable.Rows.Add(pro);
           
            return dataTable;
        }
    }
}
