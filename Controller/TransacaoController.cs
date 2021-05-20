using GerenciadorDeCambio.Dao;
using GerenciadorDeCambio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeCambio.Controller
{
    class TransacaoController
    {
        /// <summary>
        /// recebe os valores que serão cnvertidos e os prosesa e deolve para serem exibidos
        /// </summary>
        public static string[] processar (string moedaOrigem, string moedaDestino,string valor)
        {
            string[] resposta = new string[3];
            string[] or = moedaOrigem.Split('-');
            string[] ds = moedaDestino.Split('-');
            decimal real = (Decimal.Parse(valor) / Decimal.Parse(or[2]));

            decimal total = real * (Decimal.Parse(ds[2]));
           
          
            resposta[0] = total.ToString("N2");
            resposta[1]= ((Decimal.Parse(valor) / Decimal.Parse(or[2]))/10).ToString("N2");
            resposta[2] = ((((Decimal.Parse(valor) / Decimal.Parse(or[2])) / 10) * 9) * (Decimal.Parse(ds[2]))).ToString("N2");

            return resposta;
        }

        /// <summary>
        /// recebe um objeto d tipo trancacaoModel e faz a inserção no banco de dados
        /// </summary>
        public static void salvar(TransacaoModel tra)
        {
            TransacaoDao.insert(tra);
        }

    }
}
