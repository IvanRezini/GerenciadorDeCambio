using GerenciadorDeCambio.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeCambio.Dao
{
    class TransacaoDao:Conexao 
    {
        public static void insert(TransacaoModel tra)
        {
            SQLiteDataAdapter da = null;
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = string.Format(@"INSERT INTO tbOberacao(idCliente, moedaOrigem, moedaDestino, dataOperacao, valorOriginal, valorConvertido, taxaCobrada)
                      VALUES({0}, {1}, {2}, '{3}', '{4}', '{5}', '{6}')",
                      tra.IdClient, tra.IdMoedaOrigem, tra.IdMoedaDestino, tra.Data, tra.ValorOriginal, tra.ValorConvertido, tra.TaxaCobrada);

                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQueryAsync();
                vcon.Close();
                MessageBox.Show("Cadastro efetuado co socesso" + "\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no cadastro" + "\n" + ex.Message);
                throw ex;
            }
        }
    }
}
