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
        public static string salvar(MoedaModel mdo)
        {
            MoedaDao.insert(mdo);

            return "";
        }

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
        public static void atualisar(string id, string valor)
        {
            MoedaDao.update(id, valor);
        }
    }
}
