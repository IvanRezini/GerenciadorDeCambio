using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeCambio.Model
{
    class MoedaModel
    {
        private Int32 id;
        private string nome;
        private string taxa;
        
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Taxa { get => taxa; set => taxa = value; }
      
    }
}
