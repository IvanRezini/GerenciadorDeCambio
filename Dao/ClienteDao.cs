using GerenciadorDeCambio.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeCambio.Dao
{
    class ClienteDao : Conexao
    {
        public static DataTable ListaClientes()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"SELECT * FROM tbCliente ORDER BY nome";
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

        public static void insert(ClientModel cliente)
        {
            SQLiteDataAdapter da = null;
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = string.Format(@"INSERT INTO tbCliente(nome, cpf, data)
                      VALUES('{0}', '{1}', '{2}')",
                      cliente.Nome, cliente.Cpf, cliente.Data);

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
