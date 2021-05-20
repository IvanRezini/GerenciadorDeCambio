using GerenciadorDeCambio.Model;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GerenciadorDeCambio.Dao
{

    class MoedaDao : Conexao
    {
        /// <summary>
        /// cria uma lista das moedas cadastradas por ordem alfabetica
        /// retorna um DataTable
        /// </summary>
        /// <returns></returns>
        public static DataTable ListaMoedas()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"SELECT * FROM tbMoeda ORDER BY nome";
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
        /// Faz a inserção de uma nova moeda
        /// recebe um objeto do tipo MoedaModel
        /// </summary>
        public static void insert(MoedaModel moeda)
        {
            SQLiteDataAdapter da = null;
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = string.Format(@"INSERT INTO tbMoeda(nome, taxa)
                      VALUES('{0}', '{1}')",
                      moeda.Nome, moeda.Taxa );

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

        /// <summary>
        /// Faz a alteração do valor de uma moeda
        /// recebe o id da moeda e o novo valor
        /// </summary>
        public static void update(string id, string valor)
        {
            SQLiteDataAdapter da = null;
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = string.Format(@"UPDATE tbMoeda SET taxa = '{0}' WHERE id = '{1}' ",
                        valor, id);
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQueryAsync();
                vcon.Close();
                MessageBox.Show("Cadastro atualiçado com suscesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na atualização" + "\n" + ex.Message);
                throw ex;
            }
        }
    }
}
