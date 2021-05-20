using GerenciadorDeCambio.Dao;
using GerenciadorDeCambio.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GerenciadorDeCambio.Controller
{
    class MoedaController
    {
        /// <summary>
        /// Faz a iserção de uma moeda no banco 
        /// recebe um objeto d tipo moeda
        /// 
        /// </summary>
        public static string salvar(MoedaModel mdo)
        {
            string resposta = "";
            string valor = mdo.Taxa;
            valor = valor.Replace(".", ",");
            string[] x = valor.Split(',');
            if (x.Length >= 0 && x.Length < 3) ///valida se foi digitado e se tem apenas uma virgula
            {
                if (Regex.IsMatch(x[0], @"^[0-9]+$"))
                {
                    if (x.Length > 1)
                    {
                        if (Regex.IsMatch(x[1], @"^[0-9]+$"))
                        {
                            MoedaDao.insert(mdo);
                        }
                        else
                        {
                            resposta = "Valor invalido";
                        }
                    }
                    else
                    {
                        MoedaDao.insert(mdo);

                    }
                }
                else
                {
                    resposta = "Valor invalido";
                }

            }
            else
            {
                resposta = "Valor invalido";
            }
            return resposta;
        }

        /// <summary>
        /// lista as moedas do banco monta um array para popular os combobox 
        /// onde são usadas
        /// </summary>
        /// <returns></returns>
        public static string[] select()
        {
            
            DataTable dt = new DataTable();
            dt = MoedaDao.ListaMoedas();
            string[] moeda = new string[dt.Rows.Count];
           
            int i = 0;
            foreach (DataRow linha in dt.Rows)
            {
                moeda[i]= linha["id"].ToString() + " - " + linha["nome"].ToString() + " - " + linha["taxa"].ToString();
             
                i++;
            }


            return moeda;
        }

        /// <summary>
        /// faz a alteraçao de valores das moedas
        /// </summary>
        public static void atualisar(string id, string valor)
        {
            MoedaDao.update(id, valor);
        }
    }
}
