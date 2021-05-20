using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeCambio.Dao
{
    class RelatorioDao :Conexao
    {
        /// <summary>
        /// Faz um select no banco de dados com INNER JOIN  nas duas tabelas 
        /// recebe como parametro o id do cliente
        /// data de inicio e fim para filtra 
        /// retorna um DataTable com o resultado
        /// </summary>
        /// 
        public static DataTable relatorio(int id, string dataInicio, string dataFinal)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = string.Format(@"SELECT tbOberacao.id as 'Cod', tbOberacao.dataOperacao as 'Data',tbOberacao.valorOriginal as 'Valor de origem',tbOberacao.valorConvertido as 'Valor Convertido', tbCliente.nome as 'Cliente',
                                      tbOberacao.taxaCobrada as 'Valor cobrado R$', rt.nome as 'Moeda de origem', sr.nome as 'Moeda de destino'
                                      FROM tbOberacao INNER JOIN tbCliente
                                      ON tbOberacao.idCliente = tbCliente.id
                                      INNER JOIN tbMoeda as rt
                                      ON tbOberacao.moedaOrigem = rt.id 
                                      INNER JOIN tbMoeda as sr
                                      ON tbOberacao.moedaDestino = sr.id 
                                      WHERE tbOberacao.idCliente = {0} and tbOberacao.dataOperacao >= '{1}' and tbOberacao.dataOperacao <= '{2}'",
                                      id, dataInicio, dataFinal);
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

        /// <summary>
        /// Faz um select no banco de dados com INNER JOIN  nas duas tabelas 
        /// recebe como parametro data de inicio e fim para filtra apenas por data
        /// retorna um DataTable com o resultado
        /// </summary>
        public static DataTable relatorioPeriodo( string dataInicio, string dataFinal)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = string.Format(@"SELECT tbOberacao.id as 'Cod', tbOberacao.dataOperacao as 'Data',tbOberacao.valorOriginal as 'Valor de origem',tbOberacao.valorConvertido as 'Valor Convertido', tbCliente.nome as 'Cliente',
                                      tbOberacao.taxaCobrada as 'Valor cobrado R$', rt.nome as 'Moeda de origem', sr.nome as 'Moeda de destino'
                                      FROM tbOberacao INNER JOIN tbCliente
                                      ON tbOberacao.idCliente = tbCliente.id
                                      INNER JOIN tbMoeda as rt
                                      ON tbOberacao.moedaOrigem = rt.id 
                                      INNER JOIN tbMoeda as sr
                                      ON tbOberacao.moedaDestino = sr.id 
                                      WHERE tbOberacao.dataOperacao >= '{0}' and tbOberacao.dataOperacao <= '{1}'",
                                      dataInicio, dataFinal);
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

    }
}
