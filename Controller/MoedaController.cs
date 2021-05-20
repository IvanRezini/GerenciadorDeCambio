using GerenciadorDeCambio.Dao;
using GerenciadorDeCambio.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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
            MoedaDao.insert(mdo);

            return "";
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
