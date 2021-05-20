using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeCambio.Model
{
    /// <summary>
    /// cria um objeto de modelo 
    /// com gets e sets
    /// </summary>
    class ClientModel
    {
        private Int32 id;
        private string nome;
        private string data;
        private string cpf;


        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Data { get => data; set => data = value; }
        public string Cpf { get => cpf; set => cpf = value; }
    }
}
