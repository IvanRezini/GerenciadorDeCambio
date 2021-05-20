using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace GerenciadorDeCambio.Dao
{
    class Conexao
    {
        /// <summary>
        /// cria um objeto do tipo conexao 
        /// busca o caminho do banco e criaessa conexao
        /// as classes que fazem conexao com o banco são extendidas a partir dessa
        /// </summary>
        private static SQLiteConnection conexao;

        public static string caminho = System.Environment.CurrentDirectory;//lista o caminho do executavel

       public static string nomeBanco = "banco.db";

        public static string caminhoBanco = caminho + @"\banco\";

        public static SQLiteConnection conexaoBanco()
        {
        conexao = new SQLiteConnection("Data Source=" + caminhoBanco + nomeBanco);
        conexao.Open();
            return conexao;
        }
    }
}
